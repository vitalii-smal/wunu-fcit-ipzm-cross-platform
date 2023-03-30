using IPZm.Models;

namespace IPZm.Students.Base
{
    public abstract class BaseStudentViewModel : BaseViewModel
    {
        private Student _student;

        public Student Student
        {
            get => _student;
            set => SetProperty(ref _student, value);
        }
    }
}