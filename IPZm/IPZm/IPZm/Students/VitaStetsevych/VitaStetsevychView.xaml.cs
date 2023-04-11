using IPZm.Students.Base;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.VitaStetsevych
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VitaStetsevychView : BaseStudentContentPage
    {
        public VitaStetsevychView()
        {
            InitializeComponent();
            BindingContext = new VitaStetsevychViewModel();
        }
    }
}