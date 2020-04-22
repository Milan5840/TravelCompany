using Prism;
using Prism.Ioc;
using TravelCompany.Prism.ViewModels;
using TravelCompany.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TravelCompany.Prism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/TravelMasterDetailPage/NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            //containerRegistry.RegisterForNavigation<Menu, MenuItemViewModel>();
            containerRegistry.RegisterForNavigation<TravelsPage, TravelsPageViewModel>();
            containerRegistry.RegisterForNavigation<ExpensePage, ExpensePageViewModel>();
            containerRegistry.RegisterForNavigation<TravelMasterDetailPage, TravelMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<TravelsPage, TravelsPageViewModel>();
        }
    }
}
