using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Get today's date
        DateTime today = DateTime.Today;

        // Display month by date
        Console.WriteLine("Month: " + today.ToString("MMMM"));

        // Display yesterday's date and day
        DateTime yesterday = today.AddDays(-1);
        Console.WriteLine("Yesterday: " + yesterday.ToString("dd/MM/yyyy") + " (" + yesterday.ToString("dddd") + ")");

        // Display end of the month date and day
        DateTime endOfMonth = today.AddMonths(1).AddDays(-today.Day);
        Console.WriteLine("End of the month: " + endOfMonth.ToString("dd/MM/yyyy") + " (" + endOfMonth.ToString("dddd") + ")");

        // Display number of days in current month
        int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
        Console.WriteLine("Number of days in current month: " + daysInMonth);

        // Display today's date in format dd/MM/yyyy
        Console.WriteLine("Today's date: " + today.ToString("dd/MM/yyyy"));
    }
}
