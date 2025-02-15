namespace _01_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hata yakalama türleri
            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("ikinci sayı");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi/sayi2);

            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Hata"+ex.Message);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine("hata"+e);
            //}
            //catch (DivideByZeroException ek)
            //{
            //    Console.WriteLine("hata"+ek.Message);
            //}
            // catch (Exception eks)
            //{
            //    Console.WriteLine(eks.Message);
            //}

            //Console.WriteLine("Program çalışmaya devam eder");
            #endregion

            #region try catch ve finally
            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("ikinci sayı");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi/sayi2);

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{
            //    Console.WriteLine("Merhaba");
            //}
            #endregion
            try
            {
                int tekToplam = 0;
                int ciftToplam = 0;
                Console.WriteLine("Lütfen 200 den büyük bir değer giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                while (sayi>0)
                {
                    if (sayi%2==0)
                    {
                        ciftToplam+=sayi;
                    }
                    else
                    {
                        tekToplam+=sayi;
                    }
                    sayi--;
                }
                Console.WriteLine("Tek Toplam: {0}", tekToplam);
                Console.WriteLine("Çift Toplam: {0}", ciftToplam);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
