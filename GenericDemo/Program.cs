using System;
namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
             GenericOperation generic = new GenericOperation();
             generic.ToPrintArray(intArr);
             generic.ToPrintArray(doubleArr);
             generic.ToPrintArray(charArr);
        }
    }
}