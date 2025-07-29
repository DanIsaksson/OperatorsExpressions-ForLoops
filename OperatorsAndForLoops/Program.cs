using System;

namespace Week5
{
     class Program
     {               
          static void Main()
          {
               Console.WriteLine("No" + " " + "way"); // No way
               Console.WriteLine(4+6); // 10
               Console.WriteLine("3"+"9"); // 39
               Console.WriteLine(1123+"23"); // 112323
               Console.WriteLine("43"+2+5); // 4325
               Console.WriteLine(100 + " " + "+"); // 100 +
               Console.WriteLine(56+5*6); // 86
               Console.WriteLine("1" + 1*1); // 2
               Console.WriteLine(1+11+"1"+11/11); //1211
               Console.WriteLine("34"+(2-1)); // error, now fixed tho.
               Console.WriteLine(13/2); // 6
               Console.WriteLine(4*(5-3)); // 8
               Console.WriteLine(9+(2+"OH")); // 92OH
               Console.WriteLine(12+12/4); // 15
               Console.WriteLine(9 == 9 && 893 != 891+2); // false (misread the second condition first time tho)
               Console.WriteLine(8==4/2 || 4 != 4/2); // true
               Console.WriteLine(2 + 8 + "=" + 2 + 8); // 10=28
               Console.WriteLine(45 - 40 == 50 ? 3 + 6:6 +"3"); // 63 (misread condition firs ttime tho, guessed 9)


               ForLoop forLoop = new ForLoop();
               forLoop.Loop();
          }
     }
}

