using DataBinding.Model;
using DataBinding.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            vm = new MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();

        }

        public void OnItemTapped(object o, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("You selected", string.Format("You selected {0} {1}", contact.FirstName, contact.LastName), "Ok!");
        }
    }
}
