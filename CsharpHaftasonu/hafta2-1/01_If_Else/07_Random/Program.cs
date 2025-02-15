namespace _07_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bilgisayarın ram tarafıdan random olarak belirtiğimiz değere aralığına göre rasgele sayı üretmesi
            //bu işlem genelde şans oyunları similasyonlar vb.yapılarda kullanılır

            Random random = new Random();//instance
            int rasgele = random.Next(0, 100);
            Console.WriteLine(rasgele);

        }
    }
}
