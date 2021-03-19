using ECDVerifi.ViewModels;
using Xamarin.Forms;

namespace ECDVerifi.Views
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