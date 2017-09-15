using Prism.Mvvm;
using Prism.Navigation;
using TractorsPrismUnityApp.Models;

namespace TractorsPrismUnityApp.ViewModels
{
    public class TractorDetailPageViewModel : BindableBase, INavigationAware
    {
        private Tractor _tractorItem;
        public Tractor TractorItem
        {
            get { return _tractorItem; }
            set { SetProperty(ref _tractorItem, value); }
        }
        public TractorDetailPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("model"))
            {
                TractorItem = parameters["model"] as Tractor;
            }
        }
    }
}
