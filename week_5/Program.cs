using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            elevator e = new elevator();
            e.run();
            Console.ReadKey();


        }

    }

    class node
    {
        public node() { }
        public node floor;
        public node elevatorup;
        public  string floornumber;
    }
    class elevator
    {
        node firstfloor;
        node secondfloor;
        node thirdfloor;
        node fourthfloor;

        public void run()
        {
            firstfloor = new node();
            secondfloor = new node();
            thirdfloor = new node();
            fourthfloor = new node();

            firstfloor.floornumber = "First Floor";
            Console.WriteLine("The floor number is {0}", firstfloor.floornumber);
            firstfloor.elevatorup = secondfloor;
            secondfloor.floornumber = "Second Floor";
            Console.WriteLine("The floor number is {0}", secondfloor.floornumber);
            secondfloor.elevatorup = thirdfloor;
            thirdfloor.floornumber = "Third Floor";
            Console.WriteLine("The floor number is {0}", thirdfloor.floornumber);
            thirdfloor.elevatorup = fourthfloor;
            fourthfloor.floornumber = "Fourth Floor";
            Console.WriteLine("The floor number is {0}", fourthfloor.floornumber);
            fourthfloor.elevatorup = null;
        }

    }
}
