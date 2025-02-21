using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate_AnonymousFunction
{
    internal class DemoDelegate
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("Add function.");
            return a + b; 
        }

        public static int Sub(int a, int b)
        {
            Console.WriteLine("Sub function.");
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            Console.WriteLine("Mul function.");
            return a * b;
        }

        public static void Calculate(int a, int b, Calculation c)
        {
            Console.WriteLine(c(a, b));
        }

        public static void DemoBasicDelegate()
        {
            Calculation c;//c la 1 doi tuong delegate thuoc ve kieu Calculation
            c = new Calculation(Add); //gan c vao ham Add.
            int k = c(5, 4); //tuong duong goi Add(5,4);
            Console.WriteLine($"Result: {k}");

            c = Sub; //gan c vao ham Sub;
            k = c(5, 4); //tuong duong goi Sub(5,4);
            Console.WriteLine($"Result: {k}");

            Calculate(10, 5, Mul);
        }

        public static void DemoMulticast()
        {
            Console.WriteLine("\nDemo multicast:");
            Calculation c = Add;
            c += Sub;
            Console.WriteLine(c(10, 7)); //Goi ham Add(10, 7) sau do tiep tuc goi ham Sub(10, 7)

            c += Add;//them 1 lan goi ham Add nua vao cuoi cung
            Console.WriteLine(c(10, 7));

            c -= Add;//bo bot 1 lan goi ham Add (cuoi cung) trong ds ham dc goi
            Console.WriteLine(c(10, 7));

            c -= Add;
            c -= Sub;
            Console.WriteLine(c(10, 7));//runtime err vi luc nay c khong tro vao bat ky ham nao?
        }
    }
}
