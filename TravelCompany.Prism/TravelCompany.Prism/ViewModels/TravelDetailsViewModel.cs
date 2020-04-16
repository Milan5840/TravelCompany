using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TravelCompany.Prism.ViewModels
{
    public class TravelDetailsViewModel : ViewModelBase
    {
        public TravelDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Travel Details";
        }
    }
}
