namespace _06_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya Haftanın kaçıncı günü olarak soru soralım kullanıcıdan aldığımız cevaba göre 
            // örneğin '1' değeri girdi bize Pazartesi olarak cevap dönsün eğer kullanıcı 1ila 7 arasında bir değer girmez ise lütfen 1-7 arasında bir değer girin desin.
            Console.WriteLine("Haftanın Kaçıncı Günü ?");
            int cevap = Convert.ToInt32(Console.ReadLine());
            if (cevap<1 || cevap>=8)//shift + enter {} açmanıza yardımcı olur
            {
                Console.WriteLine("1-ila 7 arasında bir değer giriniz");
                
            }
            else
            {
                if (cevap == 1)
                {
                    Console.WriteLine("Pazartesi");
                }
                else if (cevap == 2)
                {
                    Console.WriteLine("Salı");
                }
                else if (cevap == 3)
                {
                    Console.WriteLine("Çarşamba");
                }
                else if (cevap == 4)
                {
                    Console.WriteLine("Perşembe");
                }
                else if (cevap==5)
                {
                    Console.WriteLine("Cuma mubarek gün camiye git");
                }
                else if (cevap ==6)
                {
                    Console.WriteLine("Cumartesi");
                }
                else
                {
                    Console.WriteLine("Pazar");
                }
            }
        }
    }
}
