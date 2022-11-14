using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericOperation
    {
        //Multiple methods for multiple Datatypes
      /*  public void ToPrintArray(int[] intArr)
        {
            foreach(var data in intArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(double[] doubleArr)
        {
            foreach (var data in doubleArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(char[] charArr)
        {
            foreach (var data in charArr)
            {
                Console.WriteLine(data);
            }
        }*/
      public void ToPrintArray<T>(T[] Array)// single method for multiple datatypes using Generic
      {
          foreach(var data in Array)
            {
                Console.WriteLine(data);
            }
      }
    }
}
