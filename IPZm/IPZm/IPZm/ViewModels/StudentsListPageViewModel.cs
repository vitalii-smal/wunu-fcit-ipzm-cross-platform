using System.Collections.Generic;
using IPZm.Models;

namespace IPZm.ViewModels
{
    public class StudentsListPageViewModel
    {
        public StudentsListPageViewModel()
        {
            Students = StudentsManager.GetAll();
        }
        
        public List<Student> Students { get; private set; }
    }
}