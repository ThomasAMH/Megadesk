using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
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
        private static int pricePerDrawer = 50;
        private static int[,] rushOrderPrices = FileHandler.GetRushOrderPrices();
        
        public static double CalculatePrice(MaterialType material, double surfaceArea, int drawerCount, int rushDays)
        {
            double subTotal = 0.0;
            subTotal += baseCost;

            if(surfaceArea - sqInCostThreshold > 0) {
                subTotal += (surfaceArea - sqInCostThreshold) * sqInCostOverThreshhold;
            }

            subTotal += pricePerDrawer * drawerCount;

            switch(material)
            {
                case MaterialType.Oak:
                    subTotal += 200;
                    break;
                case MaterialType.Laminate:
                    subTotal += 100;
                    break;
                case MaterialType.Pine:
                    subTotal += 50;
                    break;
                case MaterialType.Rosewood:
                    subTotal += 300;
                    break;
                case MaterialType.Veneer:
                    subTotal += 125;
                    break;
            }

            if (rushDays != 0)
            {
                int dim0 = 0;
                int dim1 = 0;

                switch(rushDays)
                {
                    case 3:
                        dim0 = 0;
                        break;
                    case 5:
                        dim0 = 1;
                        break;
                    case 7:
                        dim0 = 2;
                        break;
                }

                if (surfaceArea < 1000) { dim1 = 0; }
                else if (surfaceArea <= 2000) { dim1 = 1; }
                else if (surfaceArea >= 2000) { dim1 = 2; }

                subTotal += rushOrderPrices[dim0, dim1];
            }
            return subTotal;
        }

    }
}
