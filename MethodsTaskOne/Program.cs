//1)taskOne

//namespace MethodsTaskOne
//{
//    internal class Program
//    {
//        static void Main()
//        {

//            Console.WriteLine(Min());
//        }
//        public static int Min()
//        {
//            int[] numbers = {-2, 3,-5, 5, 9, 15, 128, 900 };
//            int min = numbers[0];
//            int max = numbers[0];
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (numbers[i] < min)
//                {
//                    min = numbers[i];
//                }
//                if (numbers[i] > max)
//                {
//                    max = numbers[i];
//                }
//            }
//            return min;
//        }
//    }
//}





//2) taskTwo
//using System.Drawing;

//namespace MethodsTaskOne
//{
//    internal class Program
//    {
//        static void Main(string[] num)
//        {
//            int circle = Area(8);
//            Console.WriteLine(circle);

//            int rectangle = Area(8, 10);
//            Console.WriteLine(rectangle);

//            int paralelogram = Area(5, 3, 2);
//            Console.WriteLine(paralelogram);

//            int triangle = Area(9, 6, 2, 3);
//            Console.WriteLine(triangle);

//        }

//        public static int Area(int r)
//        {
//            int s = 0;
//            int p = 3;
//            return s = p * (r * r); 
//        }
//        public static int Area(int a, int b)
//        {
//            int s = 0;
//            return s = a * b;
//        }
//        public static int Area(int a, int b, int c)
//        {
//            int s = 0;
//            return s = 2 * (a * b + a * c + b * c);
//        }
//        public static int Area(int a, int b, int c, int r)
//        {
//            int s = 0;
//            int p = (a + b + c) / 2;
//            return s = p * r;
//        }
//    }
//}
