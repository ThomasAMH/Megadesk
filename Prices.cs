using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    static internal class Prices
    {
        private static int baseCost = 200;
        private static int sqInCostOverThreshhold = 1;
        private static int sqInCostThreshold = 1000;
        private static int[,] rushOrderPrices = new int[0,0];
        
        public static double CalculatePrice(MaterialType material, double surfaceArea, int drawerCount, int rushDays)
        {
            double subTotal = 0.0;

            return subTotal;
        }

        private static double CalculateRushDays(double sqIn, int dayCount)
        {
            double subTotal = 0.0;
            return subTotal;
        }
    }
}
