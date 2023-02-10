namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            Console.Write("Massivin uzunlugunu daxil et:");
            int n = int.Parse(Console.ReadLine());
            double[] realNumber = new double[n];

            for (int i = 0; i < realNumber.Length; i++)
            {
                Console.Write($"realNumber[{i}]=");
                realNumber[i] = double.Parse(Console.ReadLine());
                int i2 = i;
            }

            for (int i2 = realNumber.Length - 1; i2 >= 0; i2--)
            {
                Console.Write(realNumber[i2] + " ");
            }
            #endregion
        }
    }
}