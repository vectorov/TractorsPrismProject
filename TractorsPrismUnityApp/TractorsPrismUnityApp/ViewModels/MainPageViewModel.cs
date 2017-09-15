using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using TractorsPrismUnityApp.Models;
using TractorsPrismUnityApp.Services;

namespace TractorsPrismUnityApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand<Tractor> NavigateToTractorDetailPageCommand { get; private set; }

        private List<Tractor> _tractorsList;
        public List<Tractor> TractorsList
        {
            get => _tractorsList; 
            set => SetProperty(ref _tractorsList, value);
        }

        private string _titlePage;
        public string TitlePage
        {
            get => _titlePage;
            set => SetProperty(ref _titlePage, value);
        }

        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService, ITractorsRepository tractorsRepository)
        {
            TitlePage = "Tractors";
            TractorsList = tractorsRepository.GetTractorsList();

            _navigationService = navigationService;
            NavigateToTractorDetailPageCommand = new DelegateCommand<Tractor>(NavigateToTractorDetailPage);
    }

        private async void NavigateToTractorDetailPage(Tractor tractor)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("model", tractor);
            await _navigationService.NavigateAsync("TractorDetailPage", navigationParams);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //if (parameters.ContainsKey("title"))
            //    Title = (string)parameters["title"] + " and Prism";
        }
    }
}
