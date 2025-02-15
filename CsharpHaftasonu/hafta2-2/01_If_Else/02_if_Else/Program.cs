namespace _02_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.

               Eğer kulanıcının yaşı 45'in altındaysa;
               Çocuk sayısına bakılacak. Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                         3'ten çok ise çocuk başına 2000₺ 
                                                               maaşa ekleme yapılacak.
               45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
               Son olarak ekrana : "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak. 
            */

            Console.WriteLine("Adınız:");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaşınız:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç Çocuğunuz var:");
            int cocukSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaşınız:");
            double maas = Convert.ToDouble(Console.ReadLine());

            if (yas >0 && yas<45)
            {
                if (cocukSayisi<=3 || cocukSayisi>0)
                {
                    maas=maas+(cocukSayisi*2500);
                    Console.WriteLine($"Sayın {ad} Alacağınız maaş: {maas}");
                }
                else if (cocukSayisi>3)
                {
                    maas=maas+(cocukSayisi*2000);
                    Console.WriteLine($"Sayın {ad} Alacağınız maaş: {maas}");
                }
            }
            else
            {
                maas=maas+5000;
                Console.WriteLine($"Sayın: {ad} Alacağınız maaş: {maas}");
            }

        }
    }
}
