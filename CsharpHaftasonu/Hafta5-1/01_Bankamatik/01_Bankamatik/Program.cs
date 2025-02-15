namespace _01_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 25000;
            string sifre = "1";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Kartlı İşlem\n2-Kartsız İşlem\nQ-Çıkış\nSeçiminiz");
                string kartli = Console.ReadLine();
                if (kartli=="1")
                {
                    int hak = 3;
                    bool giris = false;
                    while (hak>0)
                    {
                        Console.WriteLine("Şifreniz:");
                        string sfr = Console.ReadLine();
                        hak--;
                        if (sfr==sifre)
                        {
                            giris = true;
                            break;
                        }
                        else if (hak==0)
                        {
                            Console.WriteLine("5 Defa yanlış giriş yapıldı sistem 5 saniye kitlendi");
                            Thread.Sleep(5000);//5 saniyelik bekletme işlemi yapacak
                            hak =3;
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Şifreniz Hatalı. Tekrar Deneyiniz");
                        }

                    }
                    if (giris)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("*****Ana Menü*****");
                            Console.WriteLine("1-Para Çekme\n2-Para yatırma\n3-Transfer\n4-Ödemeler\n5-Eğitim Ödemeleri\n6-Bilgi Güncelleme\n0-Çıkış\nSeçiminiz:");
                            string anaMenü = Console.ReadLine();
                            if (anaMenü=="1")
                            {
                                Console.WriteLine("Çekmek istediğiniz tutar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());
                                if (bakiye>=miktar)
                                {
                                    bakiye-=miktar;
                                    Console.WriteLine($"{miktar} Lira çekildi. Yeni bakiyeniz: {bakiye}");
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye");
                                }
                            }
                            else if (anaMenü=="2")
                            {
                                Console.WriteLine("1-Kredi Kartı\n2-Hesaba\nSeçiminiz:");
                                string secim = Console.ReadLine();
                                if (secim=="1")
                                {
                                    Console.WriteLine("Kredi Kartı numarası:");
                                    string kartNo = Console.ReadLine();
                                    long kartNo2;
                                    if (kartNo.Length==12 && long.TryParse(kartNo, out kartNo2))
                                    {
                                        Console.WriteLine("Yatırılacak Miktar Girişi:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());
                                        if (bakiye>=miktar)
                                        {
                                            bakiye -=miktar;
                                            Console.WriteLine($"{miktar} lira yatırıldı yeni Bakiyeniz {bakiye}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz kart Numarası");
                                    }
                                }
                                else if (secim=="2")
                                {
                                    Console.WriteLine("Yatırılacak Miktar Girişi:");
                                    bakiye+=Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Yeni Bakiyeniz: "+bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı İşlem");
                                }

                            }
                            else if (anaMenü=="3")
                            {
                                Console.WriteLine("1-Eft\n2-Havale\nSeçiminiz:");
                                string secim = Console.ReadLine();
                                if (secim=="1")
                                {
                                    Console.WriteLine("Iban Bilgisini Başında TR olacak Şekilde Giriniz:");
                                    string Iban = Console.ReadLine().ToUpper();
                                    long iban;
                                    if (Iban.StartsWith("TR")&& Iban.Length==14 && long.TryParse(Iban.Substring(2), out iban))
                                    {
                                        Console.WriteLine("Eft Miktar Giriş:");
                                        int miktar = int.Parse(Console.ReadLine());
                                        if (bakiye>=miktar)
                                        {
                                            bakiye-=miktar;
                                            Console.WriteLine($"{miktar} lira eft edildi yeni bakiyeniz {bakiye}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersin Iban bilgisi");
                                    }
                                }
                                else if (secim=="2")
                                {
                                    Console.WriteLine("Hesap Numarası:");
                                    string havale = Console.ReadLine();
                                    long havale2;
                                    if (havale.Length==12&& long.TryParse(havale, out havale2))
                                    {
                                        Console.WriteLine("Havale miktarı girişi:");
                                        int miktar = int.Parse(Console.ReadLine());
                                        if (bakiye>=miktar)
                                        {
                                            bakiye -= miktar;
                                            Console.WriteLine($"{miktar} lira Havale edildi.Yeni bakiyeniz {bakiye}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz Hesap no");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı seçim");
                                }
                            }
                            else if (anaMenü=="4")
                            {
                                Console.WriteLine("Eğitim ödemeleri Arızalı.");
                            }
                            else if (anaMenü=="5")
                            {
                                Console.WriteLine("1-Elektrik\n2-Su\n3-Doğalgaz\nSeçiminiz:");
                                string fatura = Console.ReadLine();
                                if (fatura=="1")
                                {
                                    Console.WriteLine("Fatura Bedeli:");
                                    double miktar = Convert.ToDouble(Console.ReadLine());
                                    if (bakiye>=miktar)
                                    {
                                        bakiye-=miktar;
                                        Console.WriteLine($"{miktar} lira fatura ödendi. Yeni bakiyeniz {bakiye}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye");
                                    }

                                }
                                else if (fatura=="2")
                                {
                                    Console.WriteLine("Fatura Bedeli:");
                                    double miktar = Convert.ToDouble(Console.ReadLine());
                                    if (bakiye>=miktar)
                                    {
                                        bakiye-=miktar;
                                        Console.WriteLine($"{miktar} lira fatura ödendi. Yeni bakiyeniz {bakiye}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye");
                                    }
                                }
                                else if (fatura=="3")
                                {
                                    Console.WriteLine("Fatura Bedeli:");
                                    double miktar = Convert.ToDouble(Console.ReadLine());
                                    if (bakiye>=miktar)
                                    {
                                        bakiye-=miktar;
                                        Console.WriteLine($"{miktar} lira fatura ödendi. Yeni bakiyeniz {bakiye}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz işlem");
                                }
                            }
                            else if (anaMenü=="6")
                            {
                                Console.WriteLine("Eski şifrenizi giriniz:");
                                string eskiSifre = Console.ReadLine();
                                if (eskiSifre==sifre)
                                {
                                    Console.WriteLine("Yeni şifre:");
                                    string yeniSifre = Console.ReadLine();
                                    Console.WriteLine("Yeni Şifre Tekrarı:");
                                    string yeniSifre2 = Console.ReadLine();
                                    if (yeniSifre==yeniSifre2)
                                    {
                                        if (sifre!=yeniSifre)
                                        {
                                            sifre=yeniSifre;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Eski şifreniz ile aynı şifreyi giremezsiniz");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Girilen şifreler birbiri ile uyuşmuyor");
                                        //return; alt kodları okumasını engeller.
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Varolan şifre hatalı girildi");
                                }
                            }
                            else if (anaMenü=="0")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ana menü işlemi");
                                Thread.Sleep(2000);
                            }
                            Console.WriteLine("Ana menü-9\nÇıkış-0\nSeçiminiz:");
                            string exit = Console.ReadLine();
                            if (exit=="0")
                            {
                                break;
                            }
                            else if (exit=="9")
                            {
                                continue;
                            }
                        }
                    }

                }
                else if (kartli=="2")
                {
                    Console.WriteLine("sistem kapanıyor");
                    Thread.Sleep(2000);

                }
                else if (kartli=="Q")
                {
                    Console.WriteLine("sistem kapanıyor");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim");
                }


            }
        }
    }
}
