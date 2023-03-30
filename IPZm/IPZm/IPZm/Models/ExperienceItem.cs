using System;

namespace IPZm.Models
{
    public class ExperienceItem
    {
        public ExperienceItem(string companyName, DateTime startDate, DateTime endDate, string location)
        {
            CompanyName = companyName;
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
        }

        public string CompanyName { get; }
        
        public DateTime StartDate { get; }
        
        public DateTime EndDate { get; }

        public TimeSpan Duration => EndDate - StartDate;
        
        public string Location { get; }
    }
}