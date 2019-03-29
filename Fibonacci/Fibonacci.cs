using System;

namespace Fibonacci
{
    public class Fibonacci
    {
        private long num1 = 0;
        private long num2 = 1;
        private long num3;
        private int value;
        private int type;

        public void ChooseGenerationType()
        {
            Console.WriteLine("Введіть 1 щоб генерувати числа кількість яких = заданому числу," +
                    " або 2 щоб генерувати числа до заданого значення");
            type = Convert.ToInt32(Console.ReadLine());
        }
        public void ChooseValue()
        {
            value = InputService.GetParam("Введіть значення");
            GenerateNumbers(value);
        }
        public void GenerateNumbers(int value)
        {
            if (value > 0 && type == 1)
            {
                num3 = num1 + num2;
                Console.Write(" " + num3);
                num1 = num2;
                num2 = num3;
                GenerateNumbers(value - 1);
            }
            if (value >= num3 && type == 2)
            {
                num3 = num1 + num2;
                if (value >= num3)
                {
                    Console.Write(" " + num3);
                }
                num1 = num2;
                num2 = num3;
                GenerateNumbers(value - 1);
            }
        }
    }
}
