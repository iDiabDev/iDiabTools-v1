using System;
using System.Diagnostics;
using System.Windows.Input;
using Prism;
using Prism.Commands;
using Prism.Common;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace iDiabTools.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;

        public DelegateCommand LearnMoreCommand { get; set; }
       
        public AboutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;         
            LearnMoreCommand = new DelegateCommand(OnLearnMoreCommand);
        }
        private void OnLearnMoreCommand()
        {
            Console.WriteLine("command clicked");
            Device.OpenUri(new Uri("https://idiab.dev"));
        }
        
        
    }
}
