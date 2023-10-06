using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Montoya
{
    internal class DeskQuote
    {
        public string customerName;
        public List<Desk> desks;
        public float quoteAmount = 0.0F;
        public int rushOrderDays = 0;


        public double CalculatePrice(Desk targetDesk)
        {
            //FIXME
            int[,] RUSH_FEES = new int[0,0];

            double price = 200.00;
            double area = targetDesk.deskWidth * targetDesk.deskDepth;
            price += (area - 1000) * 1;
            price += targetDesk.deskDrawerCount * 50;

            switch (targetDesk.material)
            {
                case MaterialType.Pine:
                    price += 50;
                    break;
                case MaterialType.Oak:
                    price += 200;
                    break;
                case MaterialType.Laminate:
                    price += 100;
                    break;
                case MaterialType.Rosewood:
                    price += 300;
                    break;
                case MaterialType.Veneer:
                    price += 125;
                    break;
            }

            if (rushOrderDays != 0)
            {
                int dim0 = 0;
                int dim1 = 0;

                switch (rushOrderDays)
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

                if (area < 1000) { dim1 = 0; }
                else if (area <= 2000) { dim1 = 1; }
                else if (area >= 2000) { dim1 = 2; }

                price += RUSH_FEES[dim0, dim1];
            }

            return price;
        }
        public void AddDesk() { }
    }
}

