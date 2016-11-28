using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages.geometry_msgs;
using m = Messages;

namespace TurtleSoccerReferee.Robots
{
    /// <summary>
    /// Definiert einen Spieler
    /// </summary>
    public class Robot
    {

        public string robotName ="" ;

        public enum TEAM : int
        {
            blau = 0,
            gelb = 1
        }

        public enum FUNKTION : int
        {
            Angreifer = 0,
            Verteidiger = 1
        }

        private bool humanControlled = false;

        private TEAM team;

        private FUNKTION funktion;

        private m.geometry_msgs.Pose startPosition;

        private m.geometry_msgs.Point zielTor;
        private m.geometry_msgs.Point eigenesTor;


        public Robot(string name)
        {
            this.robotName = name;
        }

        #region Properties

        public bool HumanControlled
        {
            get
            {
                return humanControlled;
            }
            set
            {
                this.humanControlled = value;
            }
        }

        public TEAM Team
        {
            get
            {
                return team;
            }

            set
            {
                team = value;
            }
        }

        public FUNKTION Funktion
        {
            get
            {
                return funktion;
            }

            set
            {
                funktion = value;
            }
        }

        public Pose StartPosition
        {
            get
            {
                return startPosition;
            }

            set
            {
                startPosition = value;
            }
        }

        public Point ZielTor
        {
            get
            {
                return zielTor;
            }

            set
            {
                zielTor = value;
            }
        }

        public Point EigenesTor
        {
            get
            {
                return eigenesTor;
            }

            set
            {
                eigenesTor = value;
            }
        }

        #endregion
    }
}
