using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TravelCompany.Prism.ViewModels
{
    public class TravelsPageViewModel : ViewModelBase
    {
        public TravelsPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Travels";
        }
    }
}
