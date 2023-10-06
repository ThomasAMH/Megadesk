using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    static internal class Validator
    {
        static public int WIDTH_MIN = 24;
        static public int WIDTH_MAX = 96;

        static public int DEPTH_MIN = 12;
        static public int DEPTH_MAX = 48;

        static public int DRAWERS_MIN = 0;
        static public int DRAWERS_MAX = 7;

        public bool ValidateQuantity(string quantityName, double quantityValue) 
        {
            return false;
        }

    }
}
