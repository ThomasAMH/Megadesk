using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    internal class Desk
    {
        public Desk() { }
        static public int WIDTH_MIN = 24;
        static public int WIDTH_MAX = 96;

        static public int DEPTH_MIN = 12;
        static public int DEPTH_MAX = 48;

        static public int DRAWERS_MIN = 0;
        static public int DRAWERS_MAX = 7;

        static public int[] RUSH_ORDER_DAYS = { 3, 5, 7 };
    }
}
        public enum MaterialType
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
