using System.Collections;

namespace _01_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack(Yığın) => dinamik data tipi alır stack Lifo (Last in First out) Son giren ilk çıkar. çalışma prensibini destekler. Son eklenen her zaman en üstte olur ve ilk çıkar.

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Test");
            stack.Push(true);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Count);
            object sil = stack.Pop();//ilk elemanı siler.
            Console.WriteLine("Son eleman "+sil);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Contains(10));

            stack.Clear();
        }
    }
}
