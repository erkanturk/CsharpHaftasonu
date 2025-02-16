namespace _01_OverLoad_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IslemYap Adlı Void Method Tanımlayacağız Bu methodlar 1.Si 2 Sayıyı toplayacak 2.si 2 sayıyı çarpacak 
            //3.sü metinsel bir yazı yazıp Karşılığında Sayıları çıkaracak 4.sü ekrana yazı yazdırsın.
            IslemYap(20.5,10);
            IslemYap(20,10.5);
            IslemYap();
            IslemYap("Sonuc",25.5,21.1);
        }
        static void IslemYap(double s1, int s2)
        {
            Console.WriteLine(s1+s2);
        }
        static void IslemYap(int s1, double s2)
        {
            Console.WriteLine(s1*s2);
        }
        static void IslemYap(string metin, double s1, double s2)
        {
            Console.WriteLine($"{metin}: {s1-s2}");
        }
        static void IslemYap()
        {
            Console.WriteLine("Merhaba OverLoad Method.");
        }


    }
}
