﻿using Microsoft.Practices.Unity;
using Prism.Unity;
using TractorsPrismUnityApp.Services;
using TractorsPrismUnityApp.Views;
using Xamarin.Forms;

namespace TractorsPrismUnityApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            //Container.RegisterType
            Container.RegisterTypeForNavigation<TractorDetailPage>();
        }
    }
}
