// See https://aka.ms/new-console-template for more information
using System.Reflection;
using LinkedinLearning.DelegatesEventsLambdas;
using LinkedinLearning.InterfacesCasting;

namespace LinkedinLearning
{
    public class Progam
    {
        public delegate float shippingDelegate(int cost);

        public static void Listenbalance(object sender, MyEventArgs e)
        {
            Console.WriteLine("Your balance is : " + e.balance);
        }

        public static void ListenbalanceEvent(int balance)
        {
            if (balance >= 500.0m)
            {
                Console.WriteLine("You have reached your target " + balance);
            }
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
            //bank.BalanceChanged += delegate (object sender, MyEventArgs e) { Console.WriteLine("Your balance is : " + e.balance); };
            //bank.BalanceChanged += new EventHandler<MyEventArgs>(ListenbalancelimitEvent);
            //bank.BalanceChanged += delegate (int balance) { Console.WriteLine("Your balance is : " + balance); };
            //bank.BalanceChanged += new BalanceEventHandler(ListenbalanceEvent);

            //bank.BalanceChanged += (balance) => { Console.WriteLine("Your balance is : " + balance); };
            //bank.BalanceChanged += (balance) => {
            //    if (balance >= 500.0m) Console.WriteLine("You have reached your target : " + balance);
            //};

            //int deposit;
            //while (true)
            //{
            //    Console.WriteLine(" Enter amount to deposit : ");
            //    string response = Console.ReadLine();
            //    if (response == "exit")
            //    {
            //        break;
            //    }
            //    deposit = int.Parse(response);
            //    bank.Balance += deposit;

            //}

            //InterfaceDef i = new InterfaceImpl("abdul");
            //i.PrintName();

            IRandomisable randomgenerator = new IRandomImpl();
            String response;
            int upper;
            while (true)
            {
                Console.WriteLine("Enter the upperbound: ");
                response = Console.ReadLine();
                if (int.TryParse(response, out upper))
                {
                    Console.WriteLine("Random number : " + randomgenerator.GetRandomNum(upper).ToString());
                }
                if (response == "exit") break;

            }

        }
    }

}