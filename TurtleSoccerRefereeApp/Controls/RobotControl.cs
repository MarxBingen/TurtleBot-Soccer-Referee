using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using m = Messages;
using Ros_CSharp;
using Messages.daniels;
using System.Threading;

namespace TurtleSoccerReferee.Controls
{
    public partial class RobotControl : UserControl
    {

        Robots.Robot robot;
        MapControl map;

        Publisher<m.daniels.SoccerPlayerSetup> pub;
        NodeHandle node = new NodeHandle();

        private string ServicePlayerSetup
        {
            get
            {
                return String.Format("/{0}/PlayerSetup", robot.robotName);
            }
        }

        private string RobotTextTopic
        {
            get
            {
                return String.Format("/{0}/IWantToPlaySoccer", robot.robotName);
            }
        }

        private string ServiceStart
        {
            get
            {
                return String.Format("/{0}/Start", robot.robotName);
            }
        }

        private string KIList
        {
            get
            {
                return String.Format("/{0}/KIList", robot.robotName);
            }
        }

        private string ServiceStop
        {
            get
            {
                return String.Format("/{0}/Stop", robot.robotName);
            }
        }

        private string ServiceReset
        {
            get
            {
                return String.Format("/{0}/Reset", robot.robotName);
            }
        }

        private Subscriber<m.std_msgs.String> robSub;

        public RobotControl(Robots.Robot r,MapControl map)
        {
            InitializeComponent();
            this.robot = r;
            this.map = map;
            //pub = node.advertise<m.daniels.SoccerPlayerSetup>(PlayerSetupTopic, 1);
            this.checkAvailableKIs();
            NodeHandle node = new NodeHandle();
            this.robSub = node.subscribe<m.std_msgs.String>(RobotTextTopic, 1, robotTextCallback);
            this.Dock = DockStyle.Fill;
        }

        private void robotTextCallback(m.std_msgs.String text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action(() =>
                {
                    textBox1.Text += "\n"+text.data;
                }));
                return;
            }
        }

        private SETUPMODE modus = SETUPMODE.none;

        enum SETUPMODE
        {
            none,
            ZielTor,
            EigenesTor,
            StartPosition
        }

        public void setStartPosition(m.geometry_msgs.Pose startPosition)
        {
            this.robot.StartPosition = startPosition;
        }

        public void setTorPosition(m.geometry_msgs.Point tor)
        {
            if (modus==SETUPMODE.EigenesTor)
                this.robot.EigenesTor = tor;
            if (modus == SETUPMODE.ZielTor)
                this.robot.ZielTor = tor;
        }

        private void buttonStartPosition_Click(object sender, EventArgs e)
        {
            modus = SETUPMODE.StartPosition;
            map.selectStartPosition(this);
        }

        /// <summary>
        /// Sendet die Setup-Daten des Robot, eventuell in Robot.cs verlagern
        /// </summary>
        private void publishSetup()
        {
            m.daniels.SoccerPlayerSetup setup = new Messages.daniels.SoccerPlayerSetup();
            setup.eigenesTor = robot.EigenesTor;
            setup.human = robot.HumanControlled;
            setup.startPosition = robot.StartPosition;
            setup.zielTor = robot.ZielTor;
            setup.team = (byte)robot.Team;
            setup.funktion = (byte)robot.Funktion;
            playerSetup.Request req = new playerSetup.Request(){ sps = setup};
            playerSetup.Response resp = new playerSetup.Response();
            bool res = node.serviceClient<playerSetup.Request, playerSetup.Response>(ServicePlayerSetup).call(req, ref resp);
            if (!res)
                System.Diagnostics.Debug.WriteLine("Fehler beim Senden der SetupDaten");
            else
                System.Diagnostics.Debug.WriteLine("Antwort: {0}", resp.sps);
        }

        public void startRobot()
        {
            m.std_srvs.Trigger.Request req = new m.std_srvs.Trigger.Request();
            m.std_srvs.Trigger.Response resp = new m.std_srvs.Trigger.Response();
            bool res = node.serviceClient<m.std_srvs.Trigger.Request, m.std_srvs.Trigger.Response>(ServiceStart).call(req, ref resp);
            if (!res)
                System.Diagnostics.Debug.WriteLine("Fehler beim Senden des Startbefehls");
            else
                System.Diagnostics.Debug.WriteLine("Antwort: {0} {1}",resp.success,resp.message);
        }

        public void stopRobot()
        {
            m.std_srvs.Trigger.Request req = new m.std_srvs.Trigger.Request();
            m.std_srvs.Trigger.Response resp = new m.std_srvs.Trigger.Response();
            bool res = node.serviceClient<m.std_srvs.Trigger.Request, m.std_srvs.Trigger.Response>(ServiceStop).call(req, ref resp);
            if (!res)
                System.Diagnostics.Debug.WriteLine("Fehler beim Senden des Stopbefehls");
            else
                System.Diagnostics.Debug.WriteLine("Antwort: {0} {1}", resp.success, resp.message);
        }

        public void resetRobot()
        {
            m.std_srvs.Trigger.Request req = new m.std_srvs.Trigger.Request();
            m.std_srvs.Trigger.Response resp = new m.std_srvs.Trigger.Response();
            bool res = node.serviceClient<m.std_srvs.Trigger.Request, m.std_srvs.Trigger.Response>(ServiceReset).call(req, ref resp);
            if (!res)
                System.Diagnostics.Debug.WriteLine("Fehler beim Senden des Resetbefehls");
            else
                System.Diagnostics.Debug.WriteLine("Antwort: {0} {1}", resp.success, resp.message);
        }

        private void checkAvailableKIs()
        {
            m.daniels.playerKIs.Request req = new m.daniels.playerKIs.Request();
            m.daniels.playerKIs.Response resp = new m.daniels.playerKIs.Response();
            bool res = node.serviceClient<m.daniels.playerKIs.Request, m.daniels.playerKIs.Response>(KIList).call(req, ref resp);
            if (!res)
                System.Diagnostics.Debug.WriteLine("Fehler beim Abfragen der KIs");
            else
            {
                //if (comboBoxFunktion.InvokeRequired)
                //{
                //    comboBoxFunktion.Invoke(new Action(() =>
                //    {
                        foreach (string s in resp.kis)
                        {
                            this.comboBoxFunktion.Items.Add(s);
                        }
                //    }));
                //    return;
                //}
            }

        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            robot.Team = (Robots.Robot.TEAM)((ComboBox)sender).SelectedIndex;
            if (robot.Team == 0)
            {
                robot.EigenesTor = map.tor1;
                robot.ZielTor = map.tor2;
            }
            else
            {
                robot.EigenesTor = map.tor2;
                robot.ZielTor = map.tor1;
            }
        }

        private void comboBoxFunktion_SelectedIndexChanged(object sender, EventArgs e)
        {
            robot.Funktion = (Robots.Robot.FUNKTION)((ComboBox)sender).SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            publishSetup();
        }

        private void checkBoxHuman_CheckStateChanged(object sender, EventArgs e)
        {
            robot.HumanControlled = checkBoxHuman.Checked;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startRobot();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopRobot();
        }

        private void buttonAufstellung_Click(object sender, EventArgs e)
        {
            resetRobot();
        }
    }
}
