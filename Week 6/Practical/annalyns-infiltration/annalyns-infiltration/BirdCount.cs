﻿/* 
 * Filename: BirdCount.cs
 * Description: A skeleton class for a C# practical exercise covering basic programming tasks
 * such as declaring variables, methods, returning data from methods. 
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/concept/bird-watcher
 */

/*
* Instructions:
* You're an avid bird watcher that keeps track of how many birds have visited your garden 
* in the last seven days. You have six tasks, all dealing with the numbers of birds that 
* visited your garden. 
*/


using System.Runtime.CompilerServices;

namespace annalyns_infiltration;
public class BirdCount
{
    private readonly int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
    }

    /// <summary>
    /// The <c>LastWeek</c> method returns an array containing last weeks count which was 
    /// [0, 2, 5, 3, 7, 8, 4].
    /// </summary>
    /// <returns>An array of seven integers.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int[] LastWeek()
    {
        // TODO: Implement the 'LastWeek()' method
        //throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");

        int[] birdsArray = { 0, 2, 5, 3, 7, 8, 4 };
        return birdsArray;

        // Shanes solution
        // return new int[] birdsArray = { 0, 2, 5, 3, 7, 8, 4 };
    }

    /// <summary>
    /// The <c>Today</c> method returns the number of birds that visited today. The counts are 
    /// ordered by day, with the first element being the count of the oldest day, and the 
    /// last element being today's count.
    /// </summary>
    /// <returns>An integer representing the number of birds that visisted today.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public int Today()
    {
        //    // TODO: Implement the 'Today()' method
        //    //throw new NotImplementedException("Please implement the BirdCount.Today() method");

        //int birdCount = 0;

        // for (int i = 0; i < _birdsPerDay.Length; i++)
        //     birdCount++;
        // return birdCount;

        // Shanes solution
        return _birdsPerDay[_birdsPerDay.Length - 1];


    }

    /// <summary>
    /// The <c>IncrementTodaysCount</c> method increments the current count for the number of 
    /// birds that visited today by 1.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void IncrementTodaysCount()
    {
        // TODO: Implement the 'IncrementTodaysCount()' method
        // throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
        //int todaysNum = [];

        _birdsPerDay[6]++;
        
    }

    /// <summary>
    /// The <c>HasDayWithoutBirds</c> method returns <c>true</c> if there was one or more days this week where
    /// no birds visited the garden otherwise <c>false</c>false.
    /// </summary>
    /// <returns>Returns <c>true</c> if there was a day where no birds visited; otherwise <c>false</c>.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool HasDayWithoutBirds()
    {
    //TODO: Implement the 'HasDayWithoutBirds()' method
        //throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");

        //int birdCount =0;

        //if (birdCount == 0)
        //{
        //    //Console.WriteLine("No birds visited today");
        //    return true;
        //}
        //return false;


        foreach(int dayCount in _birdsPerDay)

        if(_birdsPerDay.Contains(0))
            
                return true;
        return false;
            
    }

    /// <summary>
    /// The <c>CountForFirstDays</c> method returns the number of birds that have visited your 
    /// garden from the start of the week, but limit the count to the specified number of days
    /// from the start of the week.
    /// </summary>
    /// <param name="numberOfDays"></param> An integer representing the number of days from the
    /// start of the week to count from.
    /// <returns>An <c>int</c> representing the number of birds that visited during the days.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public int CountForFirstDays(int numberOfDays)
    {
        // TODO: Implement the 'CountForFirstDays()' method
        // throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");

        int numBirdsVisited = 0;

        for(int i =0; i < numberOfDays; i++)
        {
            numBirdsVisited += _birdsPerDay[i];
        }
        //return 5;
        return numBirdsVisited;




    }
    /// <summary>
    /// The <c>BusyDays</c> method counts the number of days over the last week where more
    /// than five birds visited the garden.
    /// </summary>
    /// <returns>an <c>int</c> representing the number of days over the last week where
    /// 5 or more birds visited the garden.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public int BusyDays()
    {
        // TODO: Implement the 'BusyDays()' method
        //throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");

        //int birdCount = 5;
        //for (int i=0; i < _birdsPerDay.Length; i++)
        //{

        //}
        //return birdCount;

        int busyDays = 0;

        foreach(int dayCount in _birdsPerDay)
        {
            if(dayCount >= 5)
                busyDays++;
        }
        return busyDays;
    }

}


