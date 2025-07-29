using System;

namespace Week5
{
     class ForLoop
     {               
          public void Loop()
          {
               string BeeBee = "B";
               for (int i = 4; i <= 8; i++)
               {
                         Console.WriteLine(BeeBee+i);
                         BeeBee += "B";
               }
          }
     }
}