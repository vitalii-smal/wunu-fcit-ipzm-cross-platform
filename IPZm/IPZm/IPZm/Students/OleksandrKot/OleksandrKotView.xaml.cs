using IPZm.Students.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.OleksandrKot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OleksandrKotView : BaseStudentContentPage
    {
        private OleksandrKotViewModel _viewModel;
        public OleksandrKotView()
        {
            _viewModel = new OleksandrKotViewModel();
            BindingContext = _viewModel;
            InitializeComponent();
        }
    }
}