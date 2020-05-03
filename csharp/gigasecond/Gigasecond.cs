using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        // Use a TimeSpan to Add() a duration to a datetime
        // If given in seconds use FromSeconds()

        var interval = TimeSpan.FromSeconds(1000000000);
        return moment.Add(interval);
    }
}