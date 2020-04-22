using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCompany.Prism.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Travel Company";
        }
    }
}
