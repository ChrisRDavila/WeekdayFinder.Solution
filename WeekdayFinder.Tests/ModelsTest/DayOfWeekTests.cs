using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System;
using System.Linq; 

namespace WeekdayFinder.Tests
  {
    [TestClass]

    public class FindDayTest
    {
      // [TestMethod]
      // public void DateConstructor_CreatesInstanceOfDate_Date()
      // {
      //   //Arrange
      //   FindDay instanceDate = new FindDay();
      //   string dateResults = instanceDate.GetDate(1984, 6, 2);
      //   Assert.AreEqual(typeof(dateResults), String);
      // }

      [TestMethod]

      public void DayOfWeek_UseInputToGetDay_FindDay()
      {
        //Arrange
        FindDay inputdate = new FindDay();
        inputdate.GetDate(1984, 6, 2);
        string dateInstance = "06/02/1984";
        //Act
        string result = inputdate.ToString();
        Console.WriteLine("line 3 " + dateInstance);
        Console.WriteLine("line 4 " + result);
        // Assert
        Assert.AreEqual(dateInstance, result);
      }



    }
  }

 

// int instanceDate =  DateOnly(testY, 6, 2);
//         int testY = 1984; 
//         //Act
//         int resultY = instanceDate.Year;
//         //Assert
//         AssemblyLoadEventArgs.AreEqual(testY, resultY);


  //constructor to grab input of date instance

  //method to put use date instance in dayTime() built in method method

  //method to recieve date value from instance ie 0 for sunday

  //method to convert date value to day string ie 0 = sunday and give back a day for the value


//   var theDate = DateOnly.ParseExact("21 Oct 2015", "dd MMM yyyy", CultureInfo.InvariantCulture);  // Custom format
// var theDate2 = DateOnly.Parse("October 21, 2015", CultureInfo.InvariantCulture);

// Console.WriteLine(theDate.ToString("m", CultureInfo.InvariantCulture));     // Month day pattern
// Console.WriteLine(theDate2.ToString("o", CultureInfo.InvariantCulture));    // ISO 8601 format
// Console.WriteLine(theDate2.ToLongDateString());

// /* This example produces the following output:
//  * 
//  * October 21
//  * 2015-10-21
//  * Wednesday, October 21, 2015
// */


// This example demonstrates the DateTime.DayOfWeek property


// class Sample
// {
//     public static void Main()
//     {

// // Create a DateTime for the first of May, 2003.
//     DateTime dt = new DateTime(2003, 5, 1);
 //  Console.WriteLine("Is Thursday the day of the week for {0:d}?: {1}",
//                        dt, dt.DayOfWeek == DayOfWeek.Thursday);
//   Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
//     }
// }

// This example produces the following results:

// Is Thursday the day of the week for 5/1/2003?: True
// The day of the week for 5/1/2003 is Thursday.


// public DayOfWeek DayOfWeek { get; }