using IPZm.Students.Base;
using IPZm.Students.OleksandrKot;

using Xamarin.Forms.Xaml;

namespace IPZm.Students.AndriiStepaniuk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AndriiStepaniukView : BaseStudentContentPage
    {
        private AndriiStepaniukViewModel _viewModel;
        public AndriiStepaniukView()
        {
            _viewModel = new AndriiStepaniukViewModel();
            BindingContext = _viewModel;
            InitializeComponent();
        }
    }
}