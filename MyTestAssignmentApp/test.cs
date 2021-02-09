using System;
using System.Collections.Generic;

namespace MyTestAssignmentApp
{
    public class test
    {
        private string[] minutes;
        private string[] hours;
        private string[] weekdays;
        private string[] monthdays;
        private string[] months;
        public DateTime nextDate;
        private List<DateTime> date;
        private DateTime closestDate;
        private int weekday;
        private Boolean iss = false;
        private List<string[]> list = new List<string[]>();
        

        public DateTime mainFunc(string StartDate, string ConditionString)
        {
            nextDate = new DateTime();
            date = new List<DateTime>();

            DateTime currentDate = DateTime.Parse(StartDate);
            string[] a = ConditionString.Split(";");
            
            minutes = a[0].Split(",");
            hours = a[1].Split(",");
            weekdays = a[2].Split(",");
            monthdays = a[3].Split(",");
            months = a[4].Split(",");

            for (int year = 0; year < 100; year++)
            {
                foreach (var i in months)
                {
                    foreach (var j in monthdays)
                    {
                        foreach (var k in hours)
                        {
                            foreach (var x in minutes)
                            {
                                
                                foreach (var y in weekdays)
                                {
                                    try
                                    {
                                        nextDate = new DateTime(currentDate.Year + year, int.Parse(i), int.Parse(j),
                                            int.Parse(k),
                                            int.Parse(x), 0);
                                        iss = true;
                                    }
                                    catch
                                    {
                                        iss = false;
                                    }

                                    if (iss)
                                    {
                                        if ((int) nextDate.DayOfWeek == 0)
                                        {
                                            weekday = 1;
                                        }
                                        else
                                        {
                                            weekday = (int) nextDate.DayOfWeek + 1;
                                        }


                                        if (weekday == int.Parse(y))
                                        {
                                            date.Add(nextDate = new DateTime(currentDate.Year + year, int.Parse(i),
                                                int.Parse(j), int.Parse(k),
                                                int.Parse(x), 0));
                                        }
                                    }
                                }

                            }

                        }

                    }

                }
                
            }

            return searchClosestDate(currentDate, date);
        }

        public DateTime searchClosestDate(DateTime startDate, List <DateTime> _date)
        {
            foreach (var i in date)
            {
                if (i > startDate)
                {
                    closestDate = i;
                    break;
                }
            }
            return closestDate;
        }
    }
}