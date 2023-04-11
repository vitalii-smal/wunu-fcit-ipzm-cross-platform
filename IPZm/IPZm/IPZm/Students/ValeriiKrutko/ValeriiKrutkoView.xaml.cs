using System;
using IPZm.Students.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace IPZm.Students.ValeriiKrutko {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValeriiKrutkoView : BaseStudentContentPage {
        public ValeriiKrutkoView() {
            InitializeComponent();
            BindingContext = new ValeriiKrutkoViewModel();
        }

        private void OnPhoneTap(object sender, EventArgs e) {
            var label = (Label) sender;
            Launcher.OpenAsync("tel:" + label.Text);
        }
    }
}