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
            firstfloor.floornumber = "First Floor";
            Console.WriteLine
            firstfloor.elevatorup = secondfloor;
            secondfloor.floornumber = "Second Floor";
            

        }

    }
}
