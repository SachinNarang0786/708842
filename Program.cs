using System;

namespace _708842
{
}
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter one digit");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second digit");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            int e = a * b;
            int d = a / b;

            Console.WriteLine("add " + c);
            Console.WriteLine("add " + e);
            Console.WriteLine("add " + d);

            //Question C

            Console.WriteLine("Enter one digit");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second digit");
            int bb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("one digit is {0} and second digit is {1}", aa, bb);
            int swap;

            swap = aa;
            aa = bb;
            bb = swap;

            Console.WriteLine("After swapping one digit is {0} and second digit is {1}", aa, bb);


            //Question D

            Console.WriteLine("Enter one digit");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second digit");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one digit");
            int s = Convert.ToInt32(Console.ReadLine());

            int p = q * r * s;
            Console.WriteLine("Multiplication of three number is " + p);

            //Question E

            Console.WriteLine("add digit");
            int ee = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int ii = ee * i;
                Console.WriteLine(ii);
            }

            //Question F
            Console.WriteLine("Enter 1st digit");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd digit");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd digit");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4th digit");
            int x = Convert.ToInt32(Console.ReadLine());

            int z = (u + v + w + x);

            int zz = (u / 4);
            Console.WriteLine("Average of 4 numbers is " + z);
            
           
            //Question G
            Console.WriteLine("Enter you name please");
            String name2 = Console.ReadLine();
            Console.WriteLine("{0}, you look older than 20", name2);

            {

                {

                    { 
            //Question I

            int h = Convert.ToInt32(Console.ReadLine());
            if (h > 20 && h < 100)
            {
                Console.WriteLine("In the range of 20 to 100");
            }
            else
            {
                Console.WriteLine("Not In Range");
            }


        }
    }
}
        }
    }
