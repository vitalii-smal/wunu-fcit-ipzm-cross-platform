using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using IPZm.Models;
using IPZm.Students.Base;
using IPZm.Students.VitaliiSmal;
using Xamarin.Forms;

namespace IPZm.ViewModels
{
    public class StudentsListPageViewModel
    {
        private readonly Dictionary<BaseStudentContentPage, Student> _studentsPageDictionary = new Dictionary<BaseStudentContentPage, Student>
        {
            { new VitaliiSmalView(), new Student("Vitalii Smal") },
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