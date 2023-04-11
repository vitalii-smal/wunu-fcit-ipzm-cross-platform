using IPZm.Students.Base;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.AndriiKovalets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AndriiKovaletsView : BaseStudentContentPage
    {
        public AndriiKovaletsView()
        {
            InitializeComponent();
            BindingContext = new AndriiKovaletsViewModel();
        }
    }
}
