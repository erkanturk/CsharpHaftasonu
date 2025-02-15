namespace _02_If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (true)// yapılmaması gereken işlem
            //{
            //    Console.WriteLine("kullanma");
            //}

            string kullaniciAdi = "Erkan";
            string password = "1234a";

            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string kad = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string pass = Console.ReadLine();

            if ((kad==kullaniciAdi|| kad=="e" || kad=="erkan")&&password==pass)
            {
                Console.WriteLine("Sisteme giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı giriş işlemi");
                if (kad!="erkan"&&kad!=kullaniciAdi&&kad!="e")
                {
                   
                    if (pass!=password)
                    {
                        Console.WriteLine("Kullanıcı adı ve parola hatalı");
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adın hatalı");
                    }
                }
                else
                {
                    if (kad!="erkan"&&kad!=kullaniciAdi&&kad!="e")
                    {

                        if (pass!=password)
                        {
                            Console.WriteLine("Kullanıcı adı ve parola hatalı");
                        }
                        else
                        {
                            Console.WriteLine("Kullanıcı adın hatalı");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parola hatalı.");
                    }
                   
                }
            }

        }
    }
}
