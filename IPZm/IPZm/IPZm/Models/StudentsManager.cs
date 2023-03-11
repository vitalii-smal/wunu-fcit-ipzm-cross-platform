using System.Collections.Generic;

namespace IPZm.Models
{
    public static class StudentsManager
    {
        public static List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("Нінель Помазова"),
                new Student("Валерій Крутько"),
                new Student("Роман Типило"),
                new Student("Віта Стецевич"),
                new Student("Ковалець Андрій"),
                new Student("П’ятночка Назарій"),
                new Student("Юра Ференц"),
                new Student("Олег Возьний"),
                new Student("Віталій Смаль")
            };
        }
    }
}