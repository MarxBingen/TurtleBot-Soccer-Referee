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

namespace TurtleSoccerReferee.Controls
{
    public partial class MapControl : UserControl
    {

        List<Robots.Robot> robots = new List<Robots.Robot>();
        RobotControl setupRobot = null;

        const float tor_breite = 40.0f;
        const float tor_hoehe = 20.0f;
        public m.geometry_msgs.Point tor1 = null;
        public m.geometry_msgs.Point tor2 = null;
        bool mouseAtTor1 = false;
        bool mouseAtTor2 = false;
        Image torImage;
        Pen torPen = new Pen(Color.Black);

        Point setPosStart = Point.Empty;
        Point setPosAktuell = Point.Empty;
        Pen startPosPen = new Pen(Color.Blue);

        private MAPMODUS modus = MAPMODUS.none;

        /// <summary>
        /// Modi für die MapControl
        /// </summary>
        enum MAPMODUS
        {
            /// <summary>
            /// normale Map Interaktion, also Zoomen und Verschieben
            /// </summary>
            none,
            setTorBlue,
            setTorYellow,
            setStartPos,
            getTor
        }

        Image img;
        Point mouseDown;
        int startx = 0;             // offset of image when mouse was pressed
        int starty = 0;
        int imgx = 0;               // current offset of image
        int imgy = 0;

        bool mousepressed = false;  // true as long as left mousebutton is pressed
        float zoom = 1;



        public MapControl()
        {
            InitializeComponent();
            torImage = new Bitmap(Properties.Resources.Tor);
        }

        private Subscriber<m.nav_msgs.OccupancyGrid> mapSub;

        /// <summary>
        /// Dieses Steuerelement soll das angegebene Topic subscriben
        /// </summary>
        /// <param name="topic"></param>
        public void subscribeTopic(string topic)
        {
            NodeHandle node = new NodeHandle();
            this.mapSub = node.subscribe<m.nav_msgs.OccupancyGrid>(topic, 1, mapCallback);
        }

        private m.geometry_msgs.Point bottomLeftCoords = new m.geometry_msgs.Point();
        private m.geometry_msgs.Point topRightCoords = new m.geometry_msgs.Point();
        private m.geometry_msgs.Point lengthAxis = new m.geometry_msgs.Point();
        private float map_res = 1;

        /// <summary>
        /// Die Callback-Funktion für den Empfang von Daten
        /// </summary>
        /// <param name="m"></param>
        private void mapCallback(m.nav_msgs.OccupancyGrid m)
        {
            if (ROS.shutting_down)
                return;
            int w = (int)m.info.width;
            int h = (int)m.info.height;
            Bitmap b = new Bitmap(w, h);
            int px = 0, py = h - 1;
            //System.Diagnostics.Debug.WriteLine(m.info.origin.position.x);
            //System.Diagnostics.Debug.WriteLine(m.info.origin.position.y);
            //System.Diagnostics.Debug.WriteLine(m.info.origin.position.z);
            //System.Diagnostics.Debug.WriteLine(m.info.resolution);
            //System.Diagnostics.Debug.WriteLine(m.info.width);
            //System.Diagnostics.Debug.WriteLine(m.info.height);
            this.bottomLeftCoords.x = m.info.origin.position.x;
            this.bottomLeftCoords.y = m.info.origin.position.y + (h * m.info.resolution);
            this.topRightCoords.x = m.info.origin.position.x + (w * m.info.resolution);
            this.topRightCoords.y = m.info.origin.position.y;

            this.lengthAxis.x = this.topRightCoords.x - this.bottomLeftCoords.x;
            this.lengthAxis.y = this.topRightCoords.y - this.bottomLeftCoords.y;

            this.map_res = m.info.resolution;
            foreach (sbyte pixel in m.data)
            {
                if (pixel == -1)
                    b.SetPixel(px, py, Color.FromArgb(255, Color.WhiteSmoke));
                else
                    b.SetPixel(px, py, Color.FromArgb(pixel * 2, Color.Black));
                px++;
                if (px == w)
                {
                    px = 0;
                    py--;
                }

            }
            //neues Image nicht direkt für das Control festlegen, da manual paint
            img = Image.FromHbitmap(b.GetHbitmap());
            if (this.InvokeRequired) //sollte immer eintreten
            {
                this.Invoke(new Action(() =>
                {
                    initImageControl();

                    mapWidthLabel.Text = String.Format("{0}m", m.info.width * m.info.resolution);
                    mapHeightLabel.Text = String.Format("{0}m", m.info.height * m.info.resolution);
                    mapResolutionLabel.Text = String.Format("{0}m / Pixel", m.info.resolution);
                }));
                return;
            }
            initImageControl();
        }

        private void initImageControl()
        {
            Graphics g = this.CreateGraphics();

            // Fit width
            //zoom = ((float)mapPictureBox.Width / (float)img.Width);

            mapPictureBox.Paint += mapPictureBox_Paint; ;
            mapPictureBox.Refresh();
        }

        private void mapPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.ScaleTransform(zoom, zoom);
            e.Graphics.DrawImage(img, imgx, imgy);
            //Tore zeichnen
            e.Graphics.ResetTransform();
            if (tor1 != null)
            {
                var p = transformToMap(new PointF((float)tor1.x,(float)tor1.y));
                e.Graphics.DrawImage(torImage, p.X-tor_breite/2,p.Y-tor_hoehe/2,tor_breite,tor_hoehe);
                if (modus == MAPMODUS.getTor)
                {
                    e.Graphics.DrawEllipse(torPen, p.X - (tor_breite * 1.5f) / 2, p.Y - (tor_hoehe * 1.5f) / 2, tor_breite * 1.5f, tor_hoehe * 1.5f);
                    if (mouseAtTor1)
                        e.Graphics.FillEllipse(torPen.Brush, p.X - (tor_breite * 1.5f) / 2, p.Y - (tor_hoehe * 1.5f) / 2, tor_breite * 1.5f, tor_hoehe * 1.5f);
                }
            }
            if (tor2 != null)
            {
                var p = transformToMap(new PointF((float)tor2.x, (float)tor2.y));
                e.Graphics.DrawImage(torImage, p.X - tor_breite / 2, p.Y - tor_hoehe / 2, tor_breite, tor_hoehe);
                if (modus == MAPMODUS.getTor)
                {
                    e.Graphics.DrawEllipse(torPen, p.X - (tor_breite * 1.5f) / 2, p.Y - (tor_hoehe * 1.5f) / 2, tor_breite * 1.5f, tor_hoehe * 1.5f);
                    if (mouseAtTor2)
                        e.Graphics.FillEllipse(torPen.Brush, p.X - (tor_breite * 1.5f) / 2, p.Y - (tor_hoehe * 1.5f) / 2, tor_breite * 1.5f, tor_hoehe * 1.5f);
                }
            }
            if (modus == MAPMODUS.setStartPos && !setPosStart.IsEmpty)
            {
                e.Graphics.DrawLine(startPosPen, setPosStart, setPosAktuell);
            }
        }

        void mapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (img == null)
                return;
            

            if (e.Button == MouseButtons.Left && modus==MAPMODUS.none)
            {
                Point mousePosNow = e.Location;

                // the distance the mouse has been moved since mouse was pressed
                int deltaX = mousePosNow.X - mouseDown.X;
                int deltaY = mousePosNow.Y - mouseDown.Y;

                // calculate new offset of image based on the current zoom factor
                imgx = (int)(startx + (deltaX / zoom));
                imgy = (int)(starty + (deltaY / zoom));
             }

            //Koordinaten anzeigen
            PointF real = transformToWorld(e.Location);
            mapXCoordLabel.Text = real.X.ToString();
            mapYCoordLabel.Text = real.Y.ToString();

            if (e.Button == MouseButtons.Left && modus==MAPMODUS.none)
                mapPictureBox.Refresh();

            if (modus == MAPMODUS.setTorBlue || modus == MAPMODUS.setTorYellow)
            {
                m.geometry_msgs.Point p = new m.geometry_msgs.Point();
                var np = transformToWorld(e.Location);
                p.x = np.X;
                p.y = np.Y;
                if (modus == MAPMODUS.setTorBlue)
                    tor1 = p;
                else
                    tor2 = p;
                mapPictureBox.Refresh();
            }
            if (modus == MAPMODUS.getTor)
            {
                
                var p1 = transformToMap(new PointF((float)tor1.x, (float)tor1.y));
                var p2 = transformToMap(new PointF((float)tor2.x, (float)tor2.y));
                RectangleF r = new RectangleF(e.Location, new Size(1, 1));
                RectangleF t1 = new RectangleF(p1.X - tor_breite / 2, p1.Y - tor_hoehe / 2, tor_breite, tor_hoehe);
                RectangleF t2 = new RectangleF(p2.X - tor_breite / 2, p2.Y - tor_hoehe / 2, tor_breite, tor_hoehe);
                mouseAtTor1 = r.IntersectsWith(t1);
                mouseAtTor2 = r.IntersectsWith(t2);
                //if (mouseAtTor1 || mouseAtTor2)
                    mapPictureBox.Refresh();
            }
            if (modus == MAPMODUS.setStartPos || e.Button==MouseButtons.Left)
            {
                setPosAktuell = e.Location;
                mapPictureBox.Refresh();
            }
        }

        /// <summary>
        /// Transformiert einen Welt-Punkt in einen Kartenpunkt
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private Point transformToMap(PointF p)
        {
            Point result = new Point();
            double dx = (((p.X-bottomLeftCoords.x) / map_res)+ imgx)*zoom;
            double dy = (((bottomLeftCoords.y-p.Y) / map_res)+ imgy)*zoom;
            result.X = (int)dx;
            result.Y = (int)dy;
            return result;
        }

        /// <summary>
        /// Transformiert einen Kartenpunkt in einen Welt-Punkt
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private PointF transformToWorld(Point p)
        {
            PointF result = new PointF();
            double dx = ((p.X / zoom - imgx) * map_res) + bottomLeftCoords.x;
            double dy = ((p.Y / zoom - imgy) * map_res) - bottomLeftCoords.y;
            dy *= -1.0;
            result.X = (float)dx;
            result.Y = (float)dy;
            return result;
        }

        private void mapPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!mousepressed && modus==MAPMODUS.none)
                {
                    mousepressed = true;
                    mouseDown = e.Location;
                    startx = imgx;
                    starty = imgy;
                }
                if (modus==MAPMODUS.setStartPos)
                {
                    setPosStart = e.Location;
                }
            }
        }

        private void mapPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mousepressed = false;
            if (modus == MAPMODUS.setTorBlue || modus == MAPMODUS.setTorYellow)
            {
                modus = MAPMODUS.none;
                if (tor1 != null)
                    buttonTorBlue.BackColor = Color.LightBlue;
                if (tor2 != null)
                    buttonTorYellow.BackColor = Color.LightYellow;
            }

            if (modus == MAPMODUS.setStartPos)
            {
                modus = MAPMODUS.none;
                PointF p1 = transformToWorld(setPosStart);
                PointF p2 = transformToWorld(e.Location);
                double a = Math.Atan2(p2.Y - p1.Y , p2.X - p1.X);
                m.geometry_msgs.Pose newP = new Messages.geometry_msgs.Pose();
                newP.position = new m.geometry_msgs.Point();
                newP.position.x = p1.X;
                newP.position.y = p1.Y;
                newP.orientation = new m.geometry_msgs.Quaternion();
                newP.orientation.w = Math.Cos(a / 2);
                newP.orientation.z = Math.Sin(a / 2);
                System.Diagnostics.Debug.WriteLine(newP.position.x);
                System.Diagnostics.Debug.WriteLine(newP.position.y);
                System.Diagnostics.Debug.WriteLine("z:{0}", newP.orientation.z);
                System.Diagnostics.Debug.WriteLine("w:{0}",newP.orientation.w);
                setupRobot.setStartPosition(newP);
                modus = MAPMODUS.none;
                setPosStart = Point.Empty;
                setPosAktuell = Point.Empty;
            }

        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            float oldzoom = zoom;

            if (e.Delta > 0)
            {
                zoom += 0.1F;
            }
            else if (e.Delta < 0)
            {
                zoom = Math.Max(zoom - 0.1F, 0.01F);
            }

            Point mousePosNow = e.Location;

            // Where location of the mouse in the pictureframe
            int x = mousePosNow.X - mapPictureBox.Location.X;
            int y = mousePosNow.Y - mapPictureBox.Location.Y;

            // Where in the IMAGE is it now
            int oldimagex = (int)(x / oldzoom);
            int oldimagey = (int)(y / oldzoom);

            // Where in the IMAGE will it be when the new zoom i made
            int newimagex = (int)(x / zoom);
            int newimagey = (int)(y / zoom);

            // Where to move image to keep focus on one point
            imgx = newimagex - oldimagex + imgx;
            imgy = newimagey - oldimagey + imgy;

            mapPictureBox.Refresh();  // calls imageBox_Paint
        }

        private void buttonTore_Click(object sender, EventArgs e)
        {
            if (modus != MAPMODUS.none)
                return;
            if (sender == this.buttonTorBlue)
                modus = MAPMODUS.setTorBlue;
            if (sender == this.buttonTorYellow)
                modus = MAPMODUS.setTorYellow;
        }

        public void selectTor(RobotControl r)
        {
            if (tor1 == null || tor2 == null)
                return;
            setupRobot = r;
            modus = MAPMODUS.getTor;
        }

        public void selectStartPosition(RobotControl r)
        {
            setupRobot = r;
            modus = MAPMODUS.setStartPos;
        }
    }
}
