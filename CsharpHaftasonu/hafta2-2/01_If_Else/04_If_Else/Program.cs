namespace _04_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
           0-100 harcamışsa 0.35 ile fiyatlandırılacak
           101-250=> 0.38 üzerinde hesaplandırılacak
           251-400=> 0.41 üzerinde 
           401-600=> 0.42
           600 üstü ise 120 tl indirim yapılacak ve fiyatlandırma 0.43 üzerinde verilecek
           */

            Console.WriteLine("Yapılan Harcama mikarı");
            double harcama = Convert.ToDouble(Console.ReadLine());

            if (harcama>0 && harcama<101)
            {
                Console.WriteLine(harcama*0.35);
            }
            else if (harcama>101 && harcama<250)
            {
                Console.WriteLine(harcama*0.38);
            }
            else if (harcama>251&&harcama<400)
            {
                Console.WriteLine(harcama*0.41);
            }
            else if (harcama>401 && harcama<600)
            {
                Console.WriteLine(harcama*0.42);
            }
            else
            {
                Console.WriteLine((harcama*0.43)-120);
            }
        }
    }
}
