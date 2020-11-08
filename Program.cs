using System;

namespace nullvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketOnSale = 500;
            int Availabletickets;

            if(TicketOnSale==null)
            {
                Availabletickets = 0;
            }
            else
            {
                Availabletickets = (int)TicketOnSale;
            }
            Console.WriteLine("Available Tickets = {0}", Availabletickets);
        }
    }
}
