using ECDVerifi.ViewModels;
using Xamarin.Forms;

namespace ECDVerifi.Views
{
    public partial class NewItemPage : ContentPage
    {
        public int Item { get; set; }
        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}