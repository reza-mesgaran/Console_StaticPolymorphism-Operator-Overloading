using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_StaticPolymorphism_Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(11, 10);
            Box b2 = new Box(21, 20);
            Box b3 = b1 + b2;

            /// Operator+
            Console.Write("1st Box Height:{0} -- ", b1.Height);
            Console.WriteLine("1st Box Width:{0} ", b1.Width);

            Console.Write("2th Box Height:{0} -- ", b2.Height);
            Console.WriteLine("2th Box Width:{0}", b2.Width);
            Console.WriteLine("\n");
            Console.WriteLine("The 3rd Box's Height is:{0} -- Width is:{1}", b3.Height, b3.Width);
            Console.WriteLine("\n");


            ///   Operator== 
            Console.ForegroundColor = ConsoleColor.Green;
            if (b1==b2)
                Console.WriteLine("Those Boxes are Equal");

            ///    Operator!=
            Console.ForegroundColor = ConsoleColor.Red;
            if (b1 != b2)
                Console.WriteLine("Those Boxes are Different");

            Console.ReadKey();
        }
    }

    class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Box(int H, int W)
        {
            this.Height = H;
            this.Width = W;
        }
        // Note 1 : Operator Overloading method should be Static & Public !!!!

        public static Box operator +(Box box1, Box box2)    //Operator Overloading (Static Polymorphism - compile time 
        {
            int Temp_Height = box1.Height + box2.Height;
            int Temp_Width = box1.Width + box2.Width;

            Box B = new Box(Temp_Height, Temp_Width);
            return B;
        }


        //Note 2 : while we define == ; we should define != too (compulsory)
        //   and when overloading the greater than operator, the less than operator should also be defined.
        public static bool operator ==(Box box1, Box box2)    //Operator== for compare equality of two box 
        {
            bool state;
            if ((box1.Height == box2.Height) && (box1.Width == box2.Width))
                state = true;
            else
                state = false;

            return state;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            bool state;
            if ((box1.Height != box2.Height) || (box1.Width != box2.Width))
                state = true;
            else
                state = false;

            return state;
        }
    }
}
