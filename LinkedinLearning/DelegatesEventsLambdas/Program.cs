// See https://aka.ms/new-console-template for more information
namespace LinkedinLearning.DelegatesEventsLambdas
{
    public class Progam
    {
        public delegate float shippingDelegate(int cost);

        public static void Listenbalance(object sender, MyEventArgs e)
        {
            Console.WriteLine("Your balance is : " + e.balance);
        }

        public static void Listenbalancelimit(object sender, MyEventArgs e)
        {
            if (e.balance >= ((BankEvent)sender).Limit)
            {
                Console.WriteLine("You have reached your target " + e.balance);
            }
        }

        public static void Main(string[] args)
        {

            //shippingDelegates

            //bool quit = false;
            //do
            //{
            //    shippingDelegate shipping;
            //    Console.WriteLine("Enter the zone : ");

            //    int zone = int.Parse(Console.ReadLine());

            //    switch (zone)
            //    {
            //        case 1:
            //            shipping = new ShippingZones(25).shippingcost;
            //            break;
            //        case 2:
            //            shipping = new ShippingZones(12, true, 25).shippingcost;
            //            break;
            //        case 3:
            //            shipping = new ShippingZones(8).shippingcost;
            //            break;
            //        case 4:
            //            shipping = new ShippingZones(4, true, 25).shippingcost;
            //            break;

            //        default:
            //            shipping = null;
            //            quit = true;
            //            break;


            //    }

            //    Console.WriteLine("Enter the Cost : ");

            //    int cost = int.Parse(Console.ReadLine());
            //    Console.WriteLine("The total shipping charges are : " + shipping(cost));
            //} while (!quit);

            //BankEvent

            BankEvent bank = new BankEvent();
            bank.BalanceChanged += delegate (object sender, MyEventArgs e) { Console.WriteLine("Your balance is : " + e.balance); };
            bank.BalanceChanged += new EventHandler<MyEventArgs>(Listenbalancelimit);
            int deposit;
            while (true)
            {
                Console.WriteLine(" Enter amount to deposit : ");
                string response = Console.ReadLine();
                if (response == "exit")
                {
                    break;
                }
                deposit = int.Parse(response);
                bank.Balance += deposit;

            }

        }
    }

}