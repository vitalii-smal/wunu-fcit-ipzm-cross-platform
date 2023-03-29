using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using IPZm.Models;
using IPZm.Students.AndriiKovalets;
using IPZm.Students.Base;
using IPZm.Students.BorysHlynskyi;
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
        
        private readonly Dictionary<BaseStudentContentPage, Student> _studentsPageDictionary = new Dictionary<BaseStudentContentPage, Student>
        {
            { new VitaliiSmalView(), vitaliiSmal },
            { new BorysHlynskyiView(), new Student("Borys Hlynskyi") },
            { new AndriiKovaletsView(), new Student("Andrii Kovalets") },
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