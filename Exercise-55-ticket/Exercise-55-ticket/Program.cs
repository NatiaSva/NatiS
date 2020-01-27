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
            try
            {
                int amount = int.Parse(Console.ReadLine());
                TicketMachin.CheckAmount(amount, ticket, Price);
            }
            catch
            {
                Console.WriteLine("Must type an integer");
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

        public static void CheckAmount(int amount, int t, int price)
        {
            int ticket = t * price;
            int excess = amount - ticket;
            int addMoney = ticket - amount;
            if (amount == ticket)
                Console.WriteLine(t+ " Tickets wait you at the box office");
            if (amount > ticket)
                Console.WriteLine(t+ " Tickets wait you at the box office and you deserve "+excess+" shekel in excess" );
            if (amount < ticket)
                Console.WriteLine("You are missed "+addMoney+" shekel");
             
        }

    }
}
