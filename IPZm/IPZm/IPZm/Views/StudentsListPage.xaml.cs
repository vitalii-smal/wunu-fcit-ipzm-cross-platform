using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPZm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPZm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentsListPage : ContentPage
    {
        public StudentsListPage()
        {
            InitializeComponent();
            BindingContext = new StudentsListPageViewModel();
        }
    }
}