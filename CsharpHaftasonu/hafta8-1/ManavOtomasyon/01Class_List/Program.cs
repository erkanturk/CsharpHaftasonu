namespace _01Class_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            List<Kisi> kisiler = new List<Kisi>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bilgilerinizi giriniz");
                kisi.Ad=Console.ReadLine();
                kisi.Soyad=Console.ReadLine();
                kisi.Yas=Convert.ToInt32(Console.ReadLine());

               
                kisiler.Add(kisi);
            }
         
            foreach (var value in kisiler)
            {
                Console.WriteLine($"{value.Ad} {value.Soyad} {value.Yas}");
            }

        }
    }
}
