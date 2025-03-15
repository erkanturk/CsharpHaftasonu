using System.Collections;

namespace ManavOtomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MANAV OTOMASYONU
            /*
            HAL - Toptancı
           * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
           * 5 adet meyve listelenecek
           * Meyve seçildikten sonra "Kaç Kilo?"
           * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
           * 
           * 
            MANAV
           * "Meyve mi Sebze mi?" diye müşteriye soracağız.
           * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
           * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
           * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
           * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
           * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

           MÜŞTERİ
           * Alınan ürünleri ekrana yazdırınız.
            */
            #endregion
            ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "KARPUZ", "PORTAKAL", "MANGO" };
            ArrayList halSebzeler = new ArrayList() { "DOMATES", "BİBER", "PATLICAN", "PATATES", "SOĞAN" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();
            Console.WriteLine("*****Uby Hale Hoşgeldiniz*****");
            while (true)
            {
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S) Çıkış için Q ya basınız.");
                string halSecim = Console.ReadLine().ToUpper();
                if (halSecim=="M")
                {
                    try
                    {
                        Console.WriteLine("1-Elma\n2-Armut\n3-Karpuz\n4-Portakal\n5-Mango");
                        int meyve = int.Parse(Console.ReadLine());
                        if (meyve==1)
                        {
                            UrunAl(manavMeyveler, "ELMA", manavMeyveKilo);
                        }
                        else if (meyve==2)
                        {
                            UrunAl(manavMeyveler, "ARMUT", manavMeyveKilo);
                        }
                        else if (meyve==3)
                        {
                            UrunAl(manavMeyveler, "KARPUZ", manavMeyveKilo);
                        }
                        else if (meyve==4)
                        {
                            UrunAl(manavMeyveler, "PORTAKAL", manavMeyveKilo);
                        }
                        else if (meyve==5)
                        {
                            UrunAl(manavMeyveler, "MANGO", manavMeyveKilo);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı ?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();

                        if (cevap=="E")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("İyi günler.");
                            break;
                        }

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata"+ex.Message);
                    }
                }
                else if (halSecim=="S")
                {
                    Console.WriteLine("1-Domates\n2-Biber\n3-Patlıcan\n4-Patates\n05-Soğan");
                    try
                    {
                        int sebze = Convert.ToInt32(Console.ReadLine());
                        if (sebze==1)
                        {
                            UrunAl(manavSebzeler, "DOMATES", manavSebzeKilo);
                        }
                        else if (sebze==2)
                        {
                            UrunAl(manavSebzeler, "BİBER", manavSebzeKilo);
                        }
                        else if (sebze==3)
                        {
                            UrunAl(manavSebzeler, "PATLICAN", manavSebzeKilo);
                        }
                        else if (sebze==4)
                        {
                            UrunAl(manavSebzeler, "PATATES", manavSebzeKilo);
                        }
                        else if (sebze==5)
                        {
                            UrunAl(manavSebzeler, "SOĞAN", manavSebzeKilo);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı işlem");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı ?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap=="E")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("İyi günler.");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata "+ex.Message);
                    }
                }
                else if (halSecim=="Q")
                {
                    Console.WriteLine("Yine bekleriz");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim");
                }
            }
            while (true)
            {
                Console.WriteLine("*****Uby Manava Hoşgeldiniz*****");
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S) Çıkış İçin Q Ya basınız");
                string manavSecim = Console.ReadLine().ToUpper();
                if (manavSecim=="M")
                {
                    if (manavMeyveler.Count==0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir...");
                        continue;
                    }
                    for (int i = 0; i< manavMeyveler.Count; i++)
                    {
                        Console.WriteLine($"{i+1}-{manavMeyveler[i]}-{manavMeyveKilo[i]} kilo mevcut");
                    }
                    try
                    {
                        Console.WriteLine("Ürün seçiniz(İsim Veya Numara)");
                        string input = Console.ReadLine().ToUpper();
                        string meyve = "";
                        if (int.TryParse(input, out int meyveNo))
                        {
                            if (meyveNo>=1&& meyveNo<=manavMeyveler.Count)
                            {
                                meyve=manavMeyveler[meyveNo-1].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                continue;
                            }
                        }
                        else
                        {
                            meyve=input;
                            if (!manavMeyveler.Contains(meyve))
                            {
                                Console.WriteLine("Olmayan Ürün Seçildi.");
                                continue;
                            }
                        }
                        if (manavMeyveler.Contains(meyve))
                        {
                            Console.WriteLine("Kaç kilo ?");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavMeyveler.IndexOf(meyve);
                            int meyveKilo = (int)manavMeyveKilo[index];
                            if (meyveKilo>=kilo)
                            {
                                meyveKilo-=kilo;
                                musteri.Add($"{meyve}-{kilo} kilo");
                                manavMeyveKilo[index]=meyveKilo;
                                if (meyveKilo==0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış Başarılı.{meyve} için kalan stok:{meyveKilo} kilo");
                            }
                            else
                            {
                                Console.WriteLine($"istenilen kilo mevcut değildir. {meyve} - {meyveKilo} kilo mevcut.");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan Ürün seçimi");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Hatalı işlem");
                    }
                    Console.WriteLine("Başka bir arzunuz var mı ?");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap=="E")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Yine bekleriz...");
                        break;
                    }
                }
                else if (manavSecim=="S")
                {
                    if (manavSebzeler.Count==0)
                    {
                        Console.WriteLine("Elimizde Sebze yok....");
                        continue;
                    }
                    for (int i = 0; i < manavSebzeler.Count; i++)
                    {
                        Console.WriteLine($"{i+1} - {manavSebzeler[i]} - {manavSebzeKilo[i]} kilo mevcut");
                    }
                    try
                    {
                        Console.WriteLine("Ürün seçiniz (isim veya numara)");
                        string input = Console.ReadLine().ToUpper();
                        string sebze = "";
                        if (int.TryParse(input, out int sebzeNo))
                        {
                            if (sebzeNo>=1&&sebzeNo<=manavSebzeler.Count)
                            {
                                sebze=manavSebzeler[sebzeNo-1].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                continue;
                            }
                        }
                        else
                        {
                            sebze=input;
                            if (!manavSebzeler.Contains(sebze))
                            {
                                Console.WriteLine("Olmayan ürün");
                                continue;
                            }

                        }
                        if (manavSebzeler.Contains(sebze))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavSebzeler.IndexOf(sebze);
                            int sebzeKilo = (int)manavSebzeKilo[index];
                            if (sebzeKilo>=kilo)
                            {
                                sebzeKilo-=kilo;
                                musteri.Add($"{sebze} - {kilo} kilo");
                                manavSebzeKilo[index]=sebzeKilo;
                                if (sebzeKilo==0)
                                {
                                    manavSebzeler.RemoveAt(index);
                                    manavSebzeKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı. {sebze} için kalan stok {sebzeKilo} kilo");
                            }
                            else
                            {
                                Console.WriteLine($"istenilen kilo mevcut delil {sebze} - {sebzeKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün seçimi");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Hata");
                    }
                    Console.WriteLine("Başka bir arzunuz var mı ?");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap=="E")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (manavSecim=="Q")
                {
                    Console.WriteLine("Yine bekleriz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama");
                }

            }
            Console.WriteLine("Aldığınız ürünler");
            foreach (var item in musteri)
            {
                Console.WriteLine(item);
            }

        }
        static void UrunAl(ArrayList list, string urun, ArrayList kiloList)
        {
            if (list.Contains(urun)==false)
            {
                list.Add(urun);
                Console.WriteLine("Kaç Kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);
            }
            else
            {
                Console.WriteLine("Kaç kilo ?");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = list.IndexOf(urun);
                int meyveKilo = (int)kiloList[index];
               
                 meyveKilo+=kilo;

                kiloList[index]=meyveKilo;
                
            }
        }

    }
}
