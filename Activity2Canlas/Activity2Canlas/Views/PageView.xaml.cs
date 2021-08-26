using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity2Canlas.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Activity2Canlas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView : ContentPage
    {
        public PageView()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}