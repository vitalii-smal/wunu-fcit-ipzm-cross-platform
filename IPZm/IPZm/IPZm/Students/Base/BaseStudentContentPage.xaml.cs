using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPZm.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseStudentContentPage : ContentPage
    {
        public BaseStudentContentPage()
        {
            InitializeComponent();
        }

        public void SetStudent(Student student)
        {
            ((BaseStudentViewModel)BindingContext).Student = student;
        }
    }
}