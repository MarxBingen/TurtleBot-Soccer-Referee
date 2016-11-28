using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ros_CSharp;
using m = Messages;

namespace TurtleSoccerReferee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Subscriber<m.std_msgs.String> sub;
        private Subscriber<m.nav_msgs.OccupancyGrid> mapSub;

        
        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void startupMapListener()
        {
            mapControl1.subscribeTopic("/map");
        }

        

        private void startup()
        {
            try
            {
                if (ROS.isStarted())
                {
                    ROS.waitForShutdown();
                }
                ROS.ROS_MASTER_URI = "http://"+masterTextBox.Text+":11311";
                ROS.ROS_IP = rosIPTextBox.Text; // "192.168.64.209";
                ROS.Init(null, "Schiedsrichter");
                findRobots();
                sucheSpielerToolStripMenuItem.Enabled = true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findRobots()
        {
            TopicInfo[] topics=new TopicInfo[0];
            master.getTopics(ref topics);
            foreach (TopicInfo i in topics)
            {
                System.Diagnostics.Debug.WriteLine(i.name);
                if (i.name.Contains("/IWantToPlaySoccer"))
                {
                    var n = i.name.Replace("/IWantToPlaySoccer", "");
                    if (n.Length == 0)
                        System.Diagnostics.Debug.WriteLine("Player falsch gestartet");
                    n = n.Remove(0,1);
                    Robots.Robot newRobot = new Robots.Robot(n);
                    TabPage newRobotPage = new TabPage(newRobot.robotName);
                    newRobotPage.Controls.Add(new Controls.RobotControl(newRobot, mapControl1));
                    tabControlRobots.TabPages.Add(newRobotPage);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ROS.shutdown();
        }

        private void sucheSpielerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlRobots.TabPages.Clear();
            findRobots();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tbc in tabControlRobots.TabPages)
            {
                Controls.RobotControl r = (Controls.RobotControl)tbc.Controls[0];
                r.stopRobot();
            }
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tbc in tabControlRobots.TabPages)
            {
                Controls.RobotControl r = (Controls.RobotControl)tbc.Controls[0];
                r.startRobot();
            }
        }

        private void resetAllButton_click(object sender, EventArgs e)
        {
            foreach (TabPage tbc in tabControlRobots.TabPages)
            {
                Controls.RobotControl r = (Controls.RobotControl)tbc.Controls[0];
                r.resetRobot();
            }
        }

        private void startAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startup();
            startupMapListener();
        }
    }
}
