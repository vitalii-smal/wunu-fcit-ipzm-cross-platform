namespace IPZm.Models
{
    public class Student
    {
        public Student(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; }
    }
}