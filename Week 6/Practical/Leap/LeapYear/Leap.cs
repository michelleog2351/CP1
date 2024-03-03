/* 
 * Filename: Leap.cs
 * Description: A skeleton class for a C# practical exercise covering selection statements in C#
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/practice/leap
 */

/*
* Instructions:
* Implement the method below that checks if a date is a leap year. 
* A leap year (in the Gregorian calendar) occurs:
* In every year that is evenly divisible by 4.
* Unless the year is evenly divisible by 100, in which case it's only a leap year if the year 
* is also evenly divisible by 400.
* 
* Some examples:
*
*   1997 was not a leap year as it's not divisible by 4.
*   1900 was not a leap year as it's not divisible by 400.
*   2000 was a leap year!
* 
*/

using System;
using System.IO;

namespace LeapYear
{
    public static class Leap
    {
        /// <summary>
        /// The <c>IsLeapYear</c> method takes an int year and returns true if it is a leap year,
        /// otherwise false.
        /// </summary>
        /// <param name="year"></param> represents the <c>int</c>"/> year to check.
        /// <returns><c>bool</c></returns> true if the year is a leap year otherwise false.
        /// <exception cref="NotImplementedException"></exception>
        public static bool IsLeapYear(int year)
        {
            //TODO Implement the IsLeapYear method
            //throw new NotImplementedException("You need to implement this function.");


            // Method 1:
            // if statement checks whether the year is divisible by 4 AND the year is NOT divisible by 100,
            // OR if the year is divisible by 400.

            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //    return true; // If these conditions are met, it is a leap year
            //return false; // Otherwise it is not a leap year

            // Method 2:
            // In C#, the result of the expression inside return statement is automatically treated as a boolean,
            // therefore we don't need to explicit true or false return statements
            return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));

            // Method 3: 
            // Same result produced as previous methods however may come across as less readable
            // because of use of the ternary operator
            // return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? true : false;

            // Method 4:
            // return (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);

            // Method 5:
            // return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));

            // Built-in C# method
            // return DateTime.IsLeapYear(year);




        }
    }
}
