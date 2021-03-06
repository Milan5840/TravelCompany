﻿using Prism.Commands;
using Prism.Navigation;
using TravelCompany.Common.Models;

namespace TravelCompany.Prism.ViewModels
{
    public class MenuItemViewModel : MenuList
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectMenuCommand;

        public MenuItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectMenuCommand => _selectMenuCommand ?? (_selectMenuCommand = new DelegateCommand(SelectMenuAsync));

        private async void SelectMenuAsync()
        {
            await _navigationService.NavigateAsync($"/TravelMasterDetailPage/NavigationPage/{PageName}");
        }


    }
}
