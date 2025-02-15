namespace _01_ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            int yas;
            while (true)//while true bu döngü belli bir koşulda çıkılabileceğini eğer break ifadesi yok ise sonsuz bir döngü olacağını belirtir while yapısı true olduğu sürece sadece break ile çıkılır.
            {
                Console.WriteLine("Tekli form için 1 e çoklu form için 2 ye basınız Çıkış için 0 a basın");
                int cevap = Convert.ToInt32(Console.ReadLine());
                //kullanıcıdan alınan cevaba göre burada if yapısında uygun form yapısına yönlendirilecek 
                //eğer kullanıcı 0 1 2 dışında bir değer girer ise dışarıdaki while döngüsü tekrar kullanıcıdan değer alınması için tetiklenecek ve soru tekrar tekrar sorulacak.
                if (cevap == 1)
                {// kullanıcı 1 cevabını verir ise bu yapı true dönecek ve bu alanda ki döngü çalışacak
                    //do while yapısı while kısmı false olduğu için bu alandaki bilgiler 1 defa istenecek ve tekli form u karşılamış olacak
                    do
                    {
                        Console.WriteLine("Adınız:");
                        ad = Console.ReadLine();
                        Console.WriteLine("Soyadınız:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("Yaşınız:");
                        yas = Convert.ToInt32(Console.ReadLine());

                    } while (false);
                    Console.WriteLine($"Adınız: {ad} \nSoyad: {soyad} \nYaş: {yas}");
                    break;//bu dıştaki while döngüsünden çıkmak için kullandığımız break
                }
                else if (cevap == 2)
                {
                    while (true)// bu alanda kullanıcı 0 adet bilgisi girer ise tekrar kullanıcıya adet bilgisi soracak
                    {
                        Console.WriteLine("Kaç adet form olsun");
                        int adet = Convert.ToInt32(Console.ReadLine());

                        if (adet >0)
                        {
                            for (int i = 0; i < adet; i++)
                            {
                                Console.WriteLine("Adınız:");
                                ad = Console.ReadLine();
                                Console.WriteLine("Soyadınız:");
                                soyad = Console.ReadLine();
                                Console.WriteLine("Yaşınız:");
                                yas = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();
                                Console.WriteLine($"Adınız: {ad} \nSoyad: {soyad} \nYaş: {yas}");



                            }
                            break;//bu alan adet bilgisi soran while tarafından çıkmamızı sağlayacak


                        }
                        else if (adet==0)
                        {
                            Console.WriteLine("Lütfen 0 dan yüksek bir değer giriniz");
                            continue;//adet bilgisi soran while yapısına gitmemizi sağlayan keyword

                        }
                        else
                        {
                            break;//hatalı değerde bizi adet bilgisi döngüsünden çıkaracak break yapısı
                        }
                    }


                }
                else if (cevap==0)
                {
                    Console.WriteLine("Döngü bitti");
                    break;//0 a basılınca ana while döngüsünden çıkaracak yapı

                }
                else
                    {
                        Console.WriteLine("Hatalı işlem");
                        continue;//hatalı işlemde tekrar ana while yapısına dönmemizi sağlayan keyword
                    
                }
               break ;// ana while yapısından çıkmak için kullandığımız keyword
            }
            Console.WriteLine("İşlem tamamlandı");

        }
    }
}
