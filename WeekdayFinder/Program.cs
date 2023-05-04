using System;
using WeekdayFinder.Models;

namespace WeekdayFinder
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(@"
    ;                                                         ,                                                            
  ED.                                             :         Et                                                           
  E#Wi                                           t#,        E#t                                      ,;        ,;G:      
  E###G.                                        ;##W.       E##t                                   f#i       f#i E#,    :
  E#fD#W;               .. f.     ;WE.         :#L:WE       E#W#t                    ;           .E#t      .E#t  E#t  .GE
  E#t t##L             ;W, E#,   i#G          .KG  ,#D      E#tfL.                 .DL          i#W,      i#W,   E#t j#K;
  E#t  .E#K,          j##, E#t  f#f           EE    ;#f     E#t            f.     :K#L     LWL L#D.      L#D.    E#GK#f  
  E#t    j##f        G###, E#t G#i           f#.     t#i ,ffW#Dffj.        EW:   ;W##L   .E#f:K#Wfff;  :K#Wfff;  E##D.   
  E#t    :E#K:     :E####, E#jEW,            :#G     GK   ;LW#ELLLf.       E#t  t#KE#L  ,W#; i##WLLLLt i##WLLLLt E##Wi   
  E#t   t##L      ;W#DG##, E##E.              ;#L   LW.     E#t            E#t f#D.L#L t#K:   .E#L      .E#L     E#jL#D: 
  E#t .D#W;      j###DW##, E#G                 t#f f#:      E#t            E#jG#f  L#LL#G       f#E:      f#E:   E#t ,K#j
  E#tiW#G.      G##i,,G##, E#t                  f#D#;       E#t            E###;   L###j         ,WW;      ,WW;  E#t   jD
  E#K##i      :K#K:   L##, E#t                   G#t        E#t            E#K:    L#W;           .D#;      .D#; j#t     
  E##D.      ;##D.    L##, EE.                    t         E#t            EG      LE.              tt        tt  ,;     
  E#t        ,,,      .,,  t                                ;#t            ;       ;@                                    
  L:                                                         :;                                                                                                                                                           
      ");
      Console.WriteLine("\nEnter any date  using the Gregorian Calander (EN/US) and see what day of the week it was/is/or will be!!!");
      Console.WriteLine("\nenter four numbers for the year you would like to use:\n ie this year is 2023.");
      int yearInput = int.Parse(Console.ReadLine());
      Console.WriteLine("\nenter two numbers for the month you would like: \n ie 12 for December.");
      int monthInput = int.Parse(Console.ReadLine());
      Console.WriteLine("enter two numbers for the day you would like: \n ie 01 for first.");
      int dayInput = int.Parse(Console.ReadLine());
      FindDay inputDate = new FindDay();
      string outputDay = inputDate.GetDate(yearInput, monthInput, dayInput);
      Console.WriteLine($" \nThe day of the week for: \nday {dayInput} of month {monthInput} for the year {yearInput} is: \n{outputDay}");
      Console.WriteLine("\nWould you like to check another date?");
      Console.WriteLine("\nplease enter 'y' for yes or 'n' for no");
      string answer = (Console.ReadLine());
      if (answer == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("\nThanks for trying our app, have a great day");
      }
    }
  }
}