// See https://aka.ms/new-console-template for more information
using LinkedinLearning;

namespace Linked
{
    public class Progam {
        public delegate float shippingDelegate(int cost);
        public static void Main(string[] args) {
            

            shippingDelegate shipping;
            Console.WriteLine("Enter the zone : ");

            int zone = int.Parse(Console.ReadLine());

            switch(zone)
            {
                case 1:
                    shipping = new ShippingZones(25).shippingcost;
                    break;
                case 2:
                    shipping = new ShippingZones(12,true, 25).shippingcost;
                    break;
                case 3:
                    shipping = new ShippingZones(8).shippingcost;
                    break;
                case 4:
                    shipping = new ShippingZones(4, true, 25).shippingcost;
                    break;

                default:
                    shipping = new ShippingZones(zone).shippingcost;
                    break;


            }

            Console.WriteLine("Enter the Cost : ");

            int cost = int.Parse(Console.ReadLine());
            Console.WriteLine("The total shipping charges are : " + shipping(cost));

        }
}

}