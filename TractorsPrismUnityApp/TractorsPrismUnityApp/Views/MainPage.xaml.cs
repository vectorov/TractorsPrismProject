using TractorsPrismUnityApp.Models;
using TractorsPrismUnityApp.ViewModels;
using Xamarin.Forms;

namespace TractorsPrismUnityApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs itemTappedEventArgs)
        {
            var viewModel = BindingContext as MainPageViewModel;
            viewModel?.NavigateToTractorDetailPageCommand?.Execute((Tractor) itemTappedEventArgs.Item);
            ((ListView) sender).SelectedItem = null;
        }
    }
}
