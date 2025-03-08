using System.Collections;

namespace _01_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue=> Kuyruk Çalışma prensibi FiFo (Firt in First out) ilk giren ilk çıkar Dinamik data tipidir.

            Queue kuyruk = new Queue();
            kuyruk.Enqueue("Hikmet");
            kuyruk.Enqueue("Melek");
            kuyruk.Enqueue("Yavuz");
            kuyruk.Enqueue("Ömer");
            kuyruk.Enqueue("Deniz");
            kuyruk.Enqueue("Tuğberk");

            object ilkeleman = kuyruk.Peek();

            Console.WriteLine(ilkeleman);
            Console.WriteLine("*******");
            kuyruk.Dequeue();//ilk elemanı siler.
          
           foreach (object item in kuyruk)
            {
               
                    Thread.Sleep(3000);
                    kuyruk.Peek();//ilk çıkarılan elemanı yazdırır.
                    Console.WriteLine(item);
               
            }


        }
    }
}
