namespace _03_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteri

            Console.WriteLine("Aylık Geliriniz");
            double maas = Convert.ToDouble(Console.ReadLine());
            if (maas > 40000)
            {
                Console.WriteLine($"%12 Vergi uygulanmış maaş miktarı {maas*0.88}");
            }
            else
            {
                Console.WriteLine($"%9 Vergi uyğulanmış maaş miktarı {maas*0.91}");
            }


        }
    }
}
