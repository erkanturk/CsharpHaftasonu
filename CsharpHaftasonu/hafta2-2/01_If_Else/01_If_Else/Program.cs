namespace _01_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-50 arasındaki sayıların 7 ye tam bölünenleri ekrana yazdıralım.
            int sayi = 1;
            basla:
            if (sayi%7==0)
            {
                Console.WriteLine(sayi);
            }
            sayi++;
            if (sayi<50)
            {
                goto basla;
            }
        }
    }
}
