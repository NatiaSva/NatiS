using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_55_ticket
{
    class Program
    {
        public const int Price = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("The price of the ticket is: "+ Price);
            Console.WriteLine("How many tickets you want?");
            int ticket =int.Parse(Console.ReadLine());
            Console.WriteLine("You have to pay:" + TicketMachin.PriceOfTickets(ticket,Price));

            Console.WriteLine("Enter the amount");
            bool chechAmount = true;
            while (chechAmount)
            {
                try
                {

                    int amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(TicketMachin.CheckAmount(amount, ticket, Price));
                    break;
                }
                catch
                {
                    Console.WriteLine("Must type an integer");
                }
            }



            Console.ReadKey();
        }

    }

    public class TicketMachin
    {
        public static int  PriceOfTickets(int t,int price)
        {
            int calculate = price * t;
            return calculate;
        }

        public static string CheckAmount(int amount, int t, int price)
        {
            int ticket = t * price;
            int excess = amount - ticket;
            int addMoney = ticket - amount;
           
            if (amount == ticket)
                return t + " Tickets wait you at the box office";
            if (amount > ticket)
            {
                string excess1 = excess.ToString();
                return t + " Tickets wait you at the box office and you deserve " + excess1 + " shekel in excess";
            }
            if (amount < ticket)
            {
                string addMoney1 = addMoney.ToString();
                return "You are missed " + addMoney1 + " shekel";
            }
            return ""; //we will never get here anyay
             
        }

    }
}
