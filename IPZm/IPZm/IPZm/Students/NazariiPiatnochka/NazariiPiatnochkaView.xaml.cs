using IPZm.Students.Base;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.NazariiPiatnochka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NazariiPiatnochkaView : BaseStudentContentPage
    {
        public NazariiPiatnochkaView()
        {
            InitializeComponent();
            BindingContext = new NazariiPiatnochkaViewModel();
        }
    }
}