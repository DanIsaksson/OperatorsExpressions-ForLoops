using System;

namespace Week5
{
     class Program
     {               
          static void Main()
          {
               Console.WriteLine("Hello" + " " + "World!");
               Console.WriteLine(2+4);
               Console.WriteLine("2"+"4");
               Console.WriteLine("2"+4+7);
               Console.WriteLine((3+5)+"="+(3+5));
               Console.WriteLine((6+2)+"3");
               Console.WriteLine("Two"+"Three");
               Console.WriteLine((1+2)+"Three");
               Console.WriteLine(4 > 2);
               Console.WriteLine(34 < 32 + 4);
               Console.WriteLine(33 != 33);
               Console.WriteLine(34 - 2 == 36);
               Console.WriteLine(34 + 2 != 36);
               Console.WriteLine(34 + 2 >= 36);
               Console.WriteLine(34 - 2 > 36);
               Console.WriteLine(4 == 4 ? "One": "Two\n\n");

               ForLoop forLoop = new ForLoop();
               forLoop.Loop();
          }
     }
}

