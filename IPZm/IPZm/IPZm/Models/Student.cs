using System.Collections.Generic;

namespace IPZm.Models
{
    public class Student
    {
        public Student(string firstName)
        {
            FirstName = firstName;
        }
        
        public Student(
            string firstName, 
            string lastName, 
            string imageUrl, 
            string position, 
            string phoneNumber, 
            string telegramLogin,
            List<string> technologies,
            List<ExperienceItem> experienceItems = null)
        {
            FirstName = firstName;
            LastName = lastName;
            ImageUrl = imageUrl;
            Position = position;
            PhoneNumber = phoneNumber;
            TelegramLogin = telegramLogin;
            Technologies = technologies;
            ExperienceItems = experienceItems;
        }

        public string FullName => $"{FirstName} {LastName}";

        public string FirstName { get; }

        public string LastName { get; }
        
        public string ImageUrl { get; }
        
        public string Position { get; }
        
        public string PhoneNumber { get; }
        
        public string TelegramLogin { get; }
        
        public List<string> Technologies { get; }
        
        public List<ExperienceItem> ExperienceItems { get; }
    }
}