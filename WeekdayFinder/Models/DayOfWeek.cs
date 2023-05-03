using System;
using System.Linq;
using System.Collections.Generic;

namespace WeekdayFinder.Models
{

  public class FindDay
  {  
    public static string InputDate { get ; set; }
    public string GetDate(int year, int month, int day)
    {
      DateOnly inputDate = new DateOnly(year, month, day);
      string outputString = inputDate.ToString("dddd");
      return outputString;
      Console.WriteLine(outputString);
    }
  }
}  

// using System;

//get set any value going to show

// public class Example
// {
//    public static void Main()
//    {
//       DateTime dateValue = new DateTime(2008, 6, 11);
//       Console.WriteLine(dateValue.ToString("dddd"));
//    }
// }
// The example displays the following output:
//       Wednesday

// public DayOfWeek DayOk { get; }