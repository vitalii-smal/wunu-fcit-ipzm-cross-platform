using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using IPZm.Models;
using IPZm.Students.AndriiStepaniuk;
using IPZm.Students.AndriiKovalets;
using IPZm.Students.Base;
using IPZm.Students.BorysHlynskyi;
using IPZm.Students.NinelPomazova;
using IPZm.Students.OleksandrKot;
using IPZm.Students.ValeriiKrutko;
using IPZm.Students.VitaliiSmal;
using IPZm.Students.VitaStetsevych;
using IPZm.Students.NazariiPiatnochka;
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

        private static Student vitaStetsevych = new Student(
           "Vita",
           "Stetsevych",
           "https://url1.io/s/4k5kz", 
           "Web developer",
           "+38 098 409 4059",
           "MegaMastermind", 
           new List<string>
           {
                "HTML/CSS", "JavaScript", "Git",
                "PHP", "Python", "MySQL",
                "C#",
           },
           new List<ExperienceItem>
           {
                new ExperienceItem(
                    "VitaSoftware",
                    new DateTime(2020,9, 1),
                    new DateTime(2021,1, 4),
                    "Remote"),
                new ExperienceItem(
                    "Codecool",
                    new DateTime(2021,12, 1),
                    new DateTime(2023,9, 1),
                    "Remote"),
           });


        private static Student borysHlynskyi = new Student(
            "Borys",
            "Hlynskyi",
            "https://bit.ly/3Zv8ykb",
            "Web developer (Frontend)",
            "+38 068 14 85 935",
            "@Quixoticelixerr",
            new List<string>
            {
                "Git","JS","TS","CSS","HTML","React","Vue","Next.js","11ty","Astro",
            },
            new List<ExperienceItem>
            {
                new ExperienceItem(
                    "Exadel",
                    new DateTime(2021,9, 1),
                    new DateTime(2023,3, 1),
                    "Remote"),
            });


        private static Student nazariiPiatnochka = new Student(
            "Nazarii",
            "Piatnochka",
            "https://krasivosti.pro/uploads/posts/2022-01/1641448571_13-krasivosti-pro-p-selfi-kotov-krasivo-foto-15.jpg",
            "Frontend trainee developer",
            "+38 097 138 60 10",
            "gignaks",
            new List<string>
            {
                "HTML", "CSS", "JavaScript"
            },
            new List<ExperienceItem>
            {
                new ExperienceItem(
                    "NAU",
                    new DateTime(2018,9, 1),
                    new DateTime(2022,6, 30),
                    "Kyiv"),
                new ExperienceItem(
                    "WUNU",
                    new DateTime(2022,10, 1),
                    new DateTime(2023,12, 31),
                    "Ternopil"),
            });

        private readonly Dictionary<BaseStudentContentPage, Student> _studentsPageDictionary = new Dictionary<BaseStudentContentPage, Student>
        {
            { new VitaliiSmalView(), vitaliiSmal },
            { new AndriiKovaletsView(), AndriiKovaletsViewModel.andriiKovaletsData },
            { new ValeriiKrutkoView(), valeriiKrutko },
            { new NinelPomazovaView(), ninelPomazova },
            { new OleksandrKotView(), OleksandrKotViewModel.studentData },
            { new AndriiStepaniukView(), AndriiStepaniukViewModel.studentData },
            { new BorysHlynskyiView(), borysHlynskyi },
            { new NazariiPiatnochkaView(), nazariiPiatnochka },
            { new VitaStetsevychView(), vitaStetsevych }
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