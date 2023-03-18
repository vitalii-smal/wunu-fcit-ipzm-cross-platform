using IPZm.Students.Base;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.BorysHlynskyi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorysHlynskyiView : BaseStudentContentPage
    {
        public BorysHlynskyiView()
        {
            InitializeComponent();
            BindingContext = new BorysHlynskyiViewModel();
        }
    }
}