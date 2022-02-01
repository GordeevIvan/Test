using System;




namespace Тест_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] mas = new int[10];
            Random rnd = new Random();
            int k = 0; // положительные
            int a = 0;  // отрицательные
            int b = 0;  // нулевые

            Console.WriteLine("Наш массив ");

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-100, 101);
                Console.Write("\t" + mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    k = k + 1; 
                    
                }
                if (mas[i] < 0)
                {
                    a = a + 1;
                }
                if (mas[i] == 0)
                {
                    b = b + 1;
                }
                    
            }
            Console.WriteLine("Количество положительных элементов " + k);
            Console.WriteLine("Количество отрицательных элементов " + a);
            Console.WriteLine("Количество нулевых элементов " + b);






                

           
        
                 


        }
    }
}
