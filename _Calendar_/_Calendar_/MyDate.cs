using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Calendar_
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;       

        public enum months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        
        public Dictionary<months, int> daysInMonth = new Dictionary<months, int>(12);

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public MyDate()
        {
            daysInMonth.Add(months.January, 31);
            daysInMonth.Add(months.February, 28);
            daysInMonth.Add(months.March, 31);
            daysInMonth.Add(months.April, 30);
            daysInMonth.Add(months.May, 31);
            daysInMonth.Add(months.June, 30);
            daysInMonth.Add(months.July, 31);
            daysInMonth.Add(months.August, 31);
            daysInMonth.Add(months.September, 30);
            daysInMonth.Add(months.October, 31);
            daysInMonth.Add(months.November, 30);
            daysInMonth.Add(months.December, 31);            
        }
      
        public void setDate(int Day, int Month, int Year)
        {
            day = Day;
            month = Month;
            year = Year;               
        }
        
        public bool isLeap (int year)      // true - високосный, false  - невисокосный
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        return true;

                     return false;
                }
               return true;
            }
            return false;
        }

        public int getCurrentDays(int monthNumber, int year)
        {
            months monthName = (months)monthNumber;
            int count = 0;
            bool flag = isLeap(year);
            if (monthNumber == 2 && flag)
                count = Convert.ToInt32(daysInMonth[monthName]) + 1;
            else count = Convert.ToInt32(daysInMonth[monthName]);
            return count;
        }

        public void previousData()
        {
            if (day != 1)
            {
                Day = day - 1;
                return;
            }
            
            if (day == 1 && month != 1)
            {
               Month = Month - 1;
               Day = getCurrentDays(Month, Year);
               return;
            }
               
            if (Day == 1 && month == 1)
            {
                Month = 12;  
                Year = year - 1;
                return;
            }              
            
        }

        public void nextData()
        {
            if (Day != getCurrentDays(Month, Year))
            {
                Day = day + 1;
                return;
            }
           
           if (Day == getCurrentDays(Month, Year) && Month != (int)months.December)
           {
               Day = 1;
               Month = Month + 1;
                return;
           }

            if (Day == getCurrentDays(Month, Year) && Month == 12)
            {
                Day = 1;
                Month = 1;
                Year = year + 1;
                return;
            }
        }
     }
}
