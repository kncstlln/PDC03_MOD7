using PDC03_MODULE07.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PDC03_MODULE07.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}