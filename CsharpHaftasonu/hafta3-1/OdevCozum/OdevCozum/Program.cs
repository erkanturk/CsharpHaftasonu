namespace OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ödev çözüm
            // ödev
            // Kullanıcıdan 3 adet sayı alınız ve bu sayıları şekil A görüldüğü gibi büyükten küçüğe sıralı bir şekilde ekrana yazdırınız
            //Şekil a: 15 > 13>5 

            /* Ödev 2
          kullanıcıdan alınan cinsiyet bilgisine göre
       ==> ERKEK ise
          yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
          ==> KADIN ise
           yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
          ==> cinsiyet bilgisi switch-case ile sorgulanacak 
           */
            #endregion
            #region if Ödev Çözüm
            //Console.WriteLine("Birinci sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üçüncü sayı");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi>sayi2&& sayi>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı: "+sayi);
            //    if (sayi2>sayi3)
            //    {
            //        Console.WriteLine("Ortancı sayı: "+sayi2);
            //        Console.WriteLine("En küçük sayı: "+sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortancı  sayı: "+sayi3);
            //        Console.WriteLine("En küçük sayı: "+sayi2);

            //    }
            //}
            //else if (sayi2>sayi3&& sayi2>sayi)
            //{
            //    Console.WriteLine("En büyük Sayı: "+sayi2);
            //    if (sayi3>sayi2)
            //    {
            //        Console.WriteLine("Ortancı sayı: "+sayi3);
            //        Console.WriteLine("En küçük sayı: " + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("En küçük sayı: " + sayi3);
            //        Console.WriteLine("Ortancı sayı: "+sayi2);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("En büyük sayı: "+sayi3);
            //    if (sayi>sayi2)
            //    {
            //        Console.WriteLine("Ortancı sayı: "+sayi);
            //        Console.WriteLine("En küçük sayı: "+sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortancı sayı: "+sayi2);
            //        Console.WriteLine("En küçük sayı: "+sayi);
            //    }
            //}
            #endregion

            #region Switch Case Çözüm
            don:
            Console.WriteLine("Cinsiyet:");
            string cinsiyet = Console.ReadLine().ToLower();//Kullanıcının girdiği tüm değerleri Küçült ToLower 
            //ToUpper() -- kullanıcının girdiği tüm değerleri büyült.
            switch (cinsiyet)
            {
                case "erkek":
                    Console.WriteLine("Yaş:");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas>59)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Emekli ikramiyeniz"+(maas*10));
                    }
                    else
                    {

                        Console.WriteLine("Prim gün sayısı:");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim>=6000)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Emekli İkramiyeniz:"+ (maas*11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik hayal oldu çalışmaya devam");
                        }
                    }
                    break;
                case "kadın":
                    Console.WriteLine("Yaş:");
                    int kyas =Convert.ToInt32(Console.ReadLine());
                    if (kyas>57)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Emekli ikramiyeniz:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim:");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim>=5600)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Emekli ikramiyeniz"+ (maas*11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik yalan oldu");
                        }
                    }
                    break;
                default: Console.WriteLine("Hatalı cinsiyet işlemi"); goto don; 


            }
            #endregion
        }
    }
}
