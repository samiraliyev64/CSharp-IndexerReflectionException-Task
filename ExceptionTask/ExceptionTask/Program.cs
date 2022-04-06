using System;
using ExceptionTask.Models.Utilies;

namespace ExceptionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OutOfBoxException

            int[] box = new int[4];

            try
            {
                box[4] = 5;
            }
            catch (IndexOutOfRangeException)
            {
                throw new OutOfBoxException("box has overflowed");
            }

            #endregion

            #region OutOfTextException

            Text text1 = new Text();

            text1[5] = "salam";
            Console.WriteLine(text1[5]);

            #endregion

        }
    }
}
