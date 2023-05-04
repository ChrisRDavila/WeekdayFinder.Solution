using System;
using WeekdayFinder.Models;

namespace WeekdayFinder
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(@"
      .sSSSSs.    .sSSSSs.    .sSSS SSSSS      .sSSSSs.    .sSSSSs.         .sSSS       s.    .sSSSSs.    .sSSSSs.    .sSSS  SSSSS  
SSSSSSSSSs. SSSSSSSSSs. SSSSS SSSSS      SSSSSSSSSs. SSSSSSSSSs.      SSSSS       SSSs. SSSSSSSSSs. SSSSSSSSSs. SSSSS  SSSSS  
S SSS SSSSS S SSS SSSSS S SSS SSSSS      S SSS SSSSS S SSS SSSS'      S SSS       SSSSS S SSS SSSS' S SSS SSSS' S SSS SSSSS   
S  SS SSSSS S  SS SSSSS S  SS SSSSS      S  SS SSSSS S  SS            S  SS       SSSSS S  SS       S  SS       S  SS SSSSS   
S..SS SSSSS S..SSsSSSSS `..SSsSSSS'      S..SS SSSSS S..SSsss         S..SS       SSSSS S..SSsss    S..SSsss    S..SSsSSSSS   
S:::S SSSSS S:::S SSSSS    S:::S         S:::S SSSSS S:::SSSS         S:::S       SSSSS S:::SSSS    S:::SSSS    S:::S SSSSS   
S;;;S SSSSS S;;;S SSSSS    S;;;S         S;;;S SSSSS S;;;S            S;;;S   S   SSSSS S;;;S       S;;;S       S;;;S  SSSSS  
S%%%S SSSS' S%%%S SSSSS    S%%%S         S%%%S SSSSS S%%%S            S%%%S  SSS  SSSSS S%%%S SSSSS S%%%S SSSSS S%%%S  SSSSS  
SSSSSsS;:'  SSSSS SSSSS    SSSSS         SSSSSsSSSSS SSSSS            SSSSSsSS SSsSSSSS SSSSSsSS;:' SSSSSsSS;:' SSSSS   SSSSS 
                                                                                                                              
      ");
      Console.WriteLine("\nEnter any date on using the Gregorian Calander and see what day of the week it was/is/will be!!");
      Console.WriteLine("enter a four number integer for the year you would like");
      int yearInput = int.Parse(Console.ReadLine());
      Console.WriteLine("enter a two number integer for the month you would like \n ie 12 for December");
      int monthInput = int.Parse(Console.ReadLine());
      Console.WriteLine("enter a two number integer for the day you would like \n ie 01 for first");
      int dayInput = int.Parse(Console.ReadLine());
      FindDay inputDate = new FindDay();
      string outputDay = inputDate.GetDate(yearInput, monthInput, dayInput);
      Console.WriteLine($"The day of the week for your input date is {outputDay}");
    }
  }
}