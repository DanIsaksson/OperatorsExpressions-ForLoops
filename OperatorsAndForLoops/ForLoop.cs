using System;

namespace Week5
{
     class ForLoop
     {               
          public void Loop()
          {
               int Adder = 1;
               int Seven = 7;
               for (int i = 0; i <= 36; i++)
               {
                    if(i==(Seven*Adder))
                    {
                         Adder += 1;
                         Console.WriteLine(i);
                    }
               }
          }
     }
}