using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            ArraySumCalculator calculator = new ArraySumCalculator(array);
            Console.WriteLine("Сумма элементов массива равна: " + calculator.CalculateSum());
            Console.ReadKey();

        }
    }

    abstract class ArrayCalculator
    {
        protected int[] array;

        public ArrayCalculator(int[] array)
        {
            this.array = array;
        }

        public abstract int CalculateSum();
    }

    class ArraySumCalculator : ArrayCalculator
    {
        public ArraySumCalculator(int[] array) : base(array) { }

        public override int CalculateSum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt32(array.GetValue(i));
            }
            return sum;
        }
    }
}
