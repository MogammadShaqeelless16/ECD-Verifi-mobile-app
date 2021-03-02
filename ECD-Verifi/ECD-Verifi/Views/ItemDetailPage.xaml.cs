using ECD_Verifi.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ECD_Verifi.Views
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