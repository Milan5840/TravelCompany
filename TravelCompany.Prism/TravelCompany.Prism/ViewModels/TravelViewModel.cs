using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TravelCompany.Common.Models;

namespace TravelCompany.Prism.ViewModels
{
    public class TravelViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public TravelViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenu();
        }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        private void LoadMenu()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "descarga",
                    PageName = "AddNewTravel",
                    Title  = "Add New Travel"

                },

                new Menu
                {
                 Icon = "BLOG_controle-de-gastos-670x419",
                 PageName = "Expense",
                 Title = "Travel Expenses"
                },

                new Menu
                {
                Icon = "Consejos-para-que-ahorres-al-viajar",
                PageName = "TravelDetails",
                Title = "Travel Details"
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
