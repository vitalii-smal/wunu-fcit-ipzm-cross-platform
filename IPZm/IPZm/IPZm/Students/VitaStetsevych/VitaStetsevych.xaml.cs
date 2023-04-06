using IPZm.Students.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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

        private void InitializeComponent() //maybe
        {
            throw new NotImplementedException();
        }
    }
}