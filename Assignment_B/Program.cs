using System;

namespace Assignment_B
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------------------------------- TASK 1 ----------------------------------------");
            //input for child tickets
            Console.Write("\nPlease input number of children tickets >> ");
            int child_tickets = Convert.ToInt32(Console.ReadLine());

            while (child_tickets < 0)
            {
                Console.Write("\nPlease input non negative value for number of children tickets >> ");
                child_tickets = Convert.ToInt32(Console.ReadLine());
            }

            //input for adult tickets
            Console.Write("\nPlease input number of adult tickets >> ");
            int adult_tickets = Convert.ToInt32(Console.ReadLine());

            while (adult_tickets < 0)
            {
                Console.Write("\nPlease input non negative value for number of adult tickets >> ");
                adult_tickets = Convert.ToInt32(Console.ReadLine());
            }

            //input for senior tickets
            Console.Write("\nPlease input number of adult tickets >> ");
            int senior_tickets = Convert.ToInt32(Console.ReadLine());

            while (senior_tickets < 0)
            {
                Console.Write("\nPlease input non negative value for number of adult tickets >> ");
                senior_tickets = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\n---------------------------------------- TASK 2 ----------------------------------------");
            //TICKET PRICE CALCULATION
            double adult_ticket_price = 20.00;
            double child_ticket_price = (adult_ticket_price * 0.50); //50%
            double senior_ticket_price = (adult_ticket_price * 0.75); //75%

            Console.WriteLine("Number of tickets for children is " + child_tickets + ", for adult is " + adult_tickets + ", and for senior is " + senior_tickets);
            double revenue = (child_tickets * child_ticket_price) + (adult_tickets * adult_ticket_price) + (senior_tickets * senior_ticket_price);
            Console.WriteLine("Revenue from selling ticket is $" + revenue);

            Console.WriteLine("\n---------------------------------------- TASK 3 ----------------------------------------");

            if (adult_tickets <= (child_tickets + senior_tickets))
            {
                Console.WriteLine("The event is becoming a festival for everyone!");

            }else if(child_tickets >= senior_tickets)
            {
                Console.WriteLine("The event is attracting more and more young people!");
            }
            else
            {
                Console.WriteLine("The event should have more space for kids! ");
            }
            
            Console.WriteLine("\n---------------------------------------- TASK 4 ----------------------------------------");

            Console.Write("Enter number of participants >> ");
            int participants = Convert.ToInt32(Console.ReadLine());
            while (participants < 0 || participants > 40)
            {
                Console.Write("\t Invalid value- Number must be between 0 and 40. Enter a valid value >> ");
                participants = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n---------------------------------------- TASK 5 ----------------------------------------");
            Console.WriteLine("Entering participant information: ");

            for (int i = 0; i < participants; i++)
            {
                Console.Write("\nEnter Participant name >> ");
                string participant_name = Console.ReadLine();
                Console.WriteLine("Event codes are:");
                Console.WriteLine("    S for Swimming");
                Console.WriteLine("    B for Badminton");
                Console.WriteLine("    F for Football");
                Console.Write("\tEnter event code for this participant >> ");
                string event_code = Console.ReadLine();
                while ((event_code != "S") && (event_code != "B") && (event_code != "F") )
                {
                    Console.WriteLine("\t"+event_code + " is not a valid code");
                    Console.Write("\tEnter a valid event code >> ");
                    event_code = Console.ReadLine();
                }




            }

        }
    }
}
