using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCompany.Prism.ViewModels
{
    public class AddNewTravelViewModel : ViewModelBase
    {
        public AddNewTravelViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Add New Travel";
        }
    }
}
