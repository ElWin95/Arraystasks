namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            //Console.Write("Massivin uzunlugunu daxil et:");
            //int n = int.Parse(Console.ReadLine());
            //double[] realNumber = new double[n];

            //for (int i = 0; i < realNumber.Length; i++)
            //{
            //    Console.Write($"realNumber[{i}]=");
            //    realNumber[i] = double.Parse(Console.ReadLine());
            //    int i2 = i;
            //}

            //for (int i2 = realNumber.Length - 1; i2 >= 0; i2--)
            //{
            //    Console.Write(realNumber[i2] + " ");
            //}
            #endregion
            #region Task3
            //Console.Write("Massivin uzunlugunu daxil et:");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //bool dogrudur = true;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"Number[{i}]=");
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //int ferq1;
            //int ferq = (int)(number[1] - number[0]);
            //for (int i = 1; i < number.Length - 1; i++)
            //{
            //    ferq1 = (int)(number[i + 1] - number[i]);
            //    if (ferq != ferq1)
            //    {
            //        Console.WriteLine("Ededi silsile deyil");
            //        dogrudur = false;
            //        break;
            //    }
            //    if (dogrudur)
            //        Console.WriteLine("Ededi silsiledir");
            #endregion
            #region Task2a

            //Console.Write("Massivin uzunlugunu daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"Number[{i}]=");
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 1)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            #endregion
            #region Task2b
            //Console.Write("Massivin uzunlugunu daxil edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //bool musbetdirse = true;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"Number[{i}]=");
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] * -1 > number[i])
            //    {
            //        Console.WriteLine("Verilen ededlerin arasinda menfi eded var.");
            //        musbetdirse = false;
            //        break;
            //    }
            //}
            //if (musbetdirse)
            //{
            //    Console.WriteLine("Verilen ededler musbetdir.");
            //}
            #endregion
            #region Task2c
            //Console.Write("Massivin uzunlugunu daxil edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //bool kokAlti = false;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"Number[{i}]=");
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    double kok = (double)Math.Sqrt(number[i]);
            //    if (kok % 1 == 0)
            //    {
            //        Console.WriteLine($"Number[{i}]= {number[i]} Tam ededdir");
            //        kokAlti = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Number[{i}]= {number[i]} Tam eded deyil");
            //    }
            //}
            #endregion
            #region Task1
            Console.WriteLine("Sutunun sayini daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Setirin sayini daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int[,] mass = new int[(b), (a)];

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"Number[{i},{j}]=");
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < b; i++)
            {
                int max = mass[i, 0];
                for (int j = 0; j < a; j++)
                {
                    if (mass[i, j] > max)
                    {
                        max = mass[i, j];
                    }
                }
                Console.WriteLine($"{i + 1}-ci sutunun en buyuk elementi: {max}-dir");
            }
            #endregion
        }
    }
}