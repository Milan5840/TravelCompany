using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using TravelCompany.Common.Models;

namespace TravelCompany.Prism.ViewModels
{


    public class TravelMasterDetailPageViewModel : ViewModelBase
    {

        private readonly INavigationService _navigationService;
        public TravelMasterDetailPageViewModel(INavigationService navigationService) : 
            base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        private void LoadMenus()
        {
            List<MenuList> menus = new List<MenuList>
            {
                new MenuList
                {
                    Icon = "ic_local_airport",
                    PageName = "AddNewTravel",
                    Title  = "Add New Travel"
                },

                new MenuList
                {
                 Icon = "ic_feedback",
                 PageName = "ExpensePage",
                 Title = "Travel Expenses"
                },

                new MenuList
                {
                Icon = "ic_details",
                PageName = "TravelDetails",
                Title = "Travel Details"
                },

                new MenuList
                {
                Icon = "ic_verified_user",
                PageName = "Login",
                Title = "Log IN"
                }

            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title
                }).ToList());
        }
    }
}

   
