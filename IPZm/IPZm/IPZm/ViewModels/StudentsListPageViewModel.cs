using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using IPZm.Models;
using IPZm.Students.Base;
using IPZm.Students.BorysHlynskyi;
using IPZm.Students.NinelPomazova;
using IPZm.Students.OleksandrKot;
using IPZm.Students.ValeriiKrutko;
using IPZm.Students.VitaliiSmal;
using Xamarin.Forms;

namespace IPZm.ViewModels
{
    public class StudentsListPageViewModel
    {
        private static Student vitaliiSmal = new Student(
            "Vitalii",
            "Smal",
            "https://bit.ly/40dpdda", 
            "Xamarin developer",
            "+38 099 689 18 13",
            "VITALIISMAL",
            new List<string>
            {
                "C#", ".NET", "Xamarin", 
                "Android", "iOS", "ASP.NET", 
                "Kotlin", "Swift", "Git", "Bash", "PowerShell"
            },
            new List<ExperienceItem>
            {
                new ExperienceItem(
                    "ELEKS",
                    new DateTime(2016,7, 1),
                    new DateTime(2021,1, 1),
                    "Ternopil"),
                new ExperienceItem(
                    "Vector Software",
                    new DateTime(2021,1, 1),
                    new DateTime(2022,9, 1),
                    "Remote"),
            });
        
        private static Student valeriiKrutko = new Student(
            "Valerii",
            "Krutko",
            "https://aspect-translations.com/wp-content/uploads/2022/02/Valeriy-Krutko.png", 
            "Java developer",
            "+38 955566110",
            "javeteam",
            new List<string>
            {
                "Java", "Spring", "CSS/HTML",
                "JS/JQuery", "Linux", "Bash",
                "MySQL", "PostgreSQL"
            },
            new List<ExperienceItem>
            {
                new ExperienceItem(
                    "Khartep",
                    new DateTime(2011,11, 11),
                    new DateTime(2014,5, 31),
                    "Kharkiv"),
                new ExperienceItem(
                    "Aspect Translations",
                    new DateTime(2014,6, 1),
                    new DateTime(2023,12, 31),
                    "Remote"),
            });
        
        private static Student ninelPomazova = new Student(
           "Ninel",
           "Pomazova",
           "https://url1.io/s/VJg6b",
           ".NET developer",
           "+38 098 765 4321",
           "Nineliana",
           new List<string>
           {
                "C#", ".NET", "Azure functions",
                "ASP.NET", "Docker", "ASP.NET",
                "CI/CD", 
           },
           new List<ExperienceItem>
           {
                new ExperienceItem(
                    "REMT",
                    new DateTime(2021,7, 1),
                    new DateTime(2022,1, 1),
                    "Remote"),
                new ExperienceItem(
                    "Humanitarian",
                    new DateTime(2022,1, 1),
                    new DateTime(2022,9, 1),
                    "Remote"),
           });

        private readonly Dictionary<BaseStudentContentPage, Student> _studentsPageDictionary = new Dictionary<BaseStudentContentPage, Student>
        {
            { new VitaliiSmalView(), vitaliiSmal },
            { new BorysHlynskyiView(), new Student("Borys Hlynskyi") },
            { new ValeriiKrutkoView(), valeriiKrutko },
            { new NinelPomazovaView(), ninelPomazova },
            { new OleksandrKotView(), OleksandrKotViewModel.studentData }
        };

        public StudentsListPageViewModel()
        {
            InitStudents();
            
            Students = _studentsPageDictionary.Values.ToList();
            
            StudentSelectedCommand = new Command<Student>(StudentSelected);
        }

        private void InitStudents()
        {
            foreach (var studentPage in _studentsPageDictionary.Keys)
            {
                studentPage.SetStudent(_studentsPageDictionary[studentPage]);
            }
        }
        
        private void StudentSelected(Student student)
        {
            var page = _studentsPageDictionary.FirstOrDefault(kv => kv.Value == student).Key;
            App.Current.MainPage.Navigation.PushAsync(page);
        }

        public ICommand StudentSelectedCommand { get; }

        public IList<Student> Students { get; }
    }
}