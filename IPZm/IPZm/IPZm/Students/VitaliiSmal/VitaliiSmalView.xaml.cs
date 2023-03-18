using IPZm.Students.Base;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.VitaliiSmal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VitaliiSmalView : BaseStudentContentPage
    {
        public VitaliiSmalView()
        {
            InitializeComponent();
            BindingContext = new VitaliiSmalViewModel();
        }
    }
}