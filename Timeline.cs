using System;
namespace CourseAssignment
{
	public class Timeline
	{
        public string month;
        public string year;

        public Timeline(string mon, string yr)
        {
            month = mon;
            year = yr;
        }

        public string getMonth()
        {
            return month;
        }

        public void setMonth(string mn)
        {
            month = mn;
        }

        public string getYear()
        {
            return year;
        }

        public void setYear(string yr)
        {
            year = yr;
        }
    }
}





