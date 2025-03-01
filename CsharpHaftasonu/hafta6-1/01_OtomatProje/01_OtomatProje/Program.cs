namespace _01_OtomatProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region soru
            /* 

            Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
           Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

            // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
              Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
             */
            #endregion
            #region çözüm
            bool admin = false;// Admin mi ?
            string pass = "123";
            string inputPassword;//Girilen şifre
            int wrongAttempts = 0;//Yanlış giriş kontrol
            bool locked = false;//Hesap kitli mi ?

            string[] products = { "kola", "fanta", "bisküvi", "çikolata", "su" };
            double[] prices = { 50, 50, 40, 25, 15 };
            double balance = 0;//Kullanıcı bakiyesi
            while (true)
            {
                try
                {
                    for (int i = 0; i<products.Length; i++)
                    {
                        Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                    }
                    Console.WriteLine("Ürün numarasını Seçiniz (Admin Girişi için -1 e basınız)");
                    int productNo = Convert.ToInt32(Console.ReadLine());
                    if (productNo==-1)
                    {
                        if (!locked)
                        {
                            while (wrongAttempts<3)
                            {
                                Console.WriteLine("Admin şifresini giriniz");
                                inputPassword = Console.ReadLine();
                                if (inputPassword==pass)
                                {
                                    admin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    wrongAttempts++;
                                    Console.WriteLine("Yanlış şifre! kalan hakkınız:"+(3-wrongAttempts));
                                }
                                if (wrongAttempts==3)
                                {
                                    Console.WriteLine("Çok sayıda yanlış giriş yapıldı Hesap 10 saniye Kitlendi!!!!!");
                                    locked = true;
                                    Thread.Sleep(10000);
                                    locked = false;

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hesap Kitli Lütfen bekleyin");
                            Thread.Sleep(10000);
                            locked= false;
                        }
                        continue;
                    }
                    Console.WriteLine("Para girişi yapınız:");
                    balance=Convert.ToDouble(Console.ReadLine());
                    if (balance>=prices[productNo])
                    {
                        Console.WriteLine("Ürünü Bölmeden alabilirsiniz.\nAfiyet olsun.\nPara üstü:"+(balance-prices[productNo]));
                        Thread.Sleep(2000);
                        balance=0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye!");
                            Console.WriteLine("Para Ekle-1\n2-Para iade");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim==1)
                            {
                                Console.WriteLine("Para Ekle:");
                                balance+=Convert.ToDouble(Console.ReadLine());
                                if (balance>=prices[productNo])
                                {
                                    Console.WriteLine("Ürünü Bölmeden alabilirsiniz.\nAfiyet olsun.\nPara üstü:"+(balance-prices[productNo]));
                                    Thread.Sleep(2000);
                                    balance=0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim==2)
                            {
                                Console.WriteLine("PAra İade edildi");
                                balance=0;
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hatalı işlem"+ex.Message);
                    Thread.Sleep(2000);
                }
                if (admin)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("******************** Admin Paneli *************************");
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Çıkış");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim==1)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAdi = Console.ReadLine().ToLower();
                            bool kontrol = false;
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (products[i].ToLower()==urunAdi)
                                {
                                    kontrol = true;
                                    break;
                                }
                            }
                            if (kontrol)
                            {
                                Console.WriteLine("Ürün Zaten mevcut.");
                                Thread.Sleep(3000);
                                continue;
                            }
                            Console.WriteLine("Ürün Fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());
                            Array.Resize(ref products, products.Length+1);
                            Array.Resize(ref prices, prices.Length +1);
                            products[products.Length-1]=urunAdi;
                            prices[prices.Length-1]=fiyat;
                            Console.WriteLine("Ürün Eklendi:");
                            Thread.Sleep(2000);

                        }
                        else if (secim==2)
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}: {prices[i]}");
                            }
                            Console.WriteLine("Güncellenecek ürün numarası:");
                            int guncellenecekNo = Convert.ToInt32(Console.ReadLine());
                            if (guncellenecekNo>=0&&guncellenecekNo<products.Length)
                            {
                                Console.WriteLine("Yeni Ürün Adı:");
                                string yeniUrunAdi = Console.ReadLine();
                                Console.WriteLine("Yeni Ürün Fiyatı:");
                                double yeniUrunFiyati = Convert.ToDouble(Console.ReadLine());

                                products[guncellenecekNo]=yeniUrunAdi;
                                prices[guncellenecekNo]=yeniUrunFiyati;
                                Console.WriteLine("Ürün Güncellendi:");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                            }
                        }
                        else if (secim==3)
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}: {prices[i]}");
                            }
                            Console.WriteLine("Silinecek Ürün Numarası:");
                            int silinecekNo = Convert.ToInt32(Console.ReadLine());
                            if (silinecekNo>=0&&silinecekNo<products.Length)
                            {
                                for (int i = silinecekNo; i < products.Length-1; i++)
                                {
                                    products[i]=products[i+1];
                                    prices[i]=prices[i+1];
                                }
                                Array.Resize(ref products, products.Length-1);
                                Array.Resize(ref prices, prices.Length-1);
                                Console.WriteLine("ÜrünSilindi");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim.");
                            }
                        }
                        else if (secim==4)
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}: {prices[i]}");
                            }
                            Thread.Sleep(2000);
                        }
                        else if (secim==5)
                        {
                            admin=false;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim");
                        }
                    }
                    admin = false;
                }
            }

            #endregion
        }
    }
}
