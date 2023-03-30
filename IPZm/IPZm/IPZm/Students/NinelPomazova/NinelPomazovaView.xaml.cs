using IPZm.Students.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPZm.Students.NinelPomazova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NinelPomazovaView : BaseStudentContentPage
    {
        public NinelPomazovaView()
        {
            InitializeComponent();
            BindingContext = new NinelPomazovaViewModel();
        }
    }
}