using IPZm.Students.Base;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.AndriiStepaniuk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AndriiStepaniukView : BaseStudentContentPage
    {
        public AndriiStepaniukView()
        {
            InitializeComponent();
            BindingContext = new AndriiStepaniukViewModel();
        }
    }
}