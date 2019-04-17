using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace iDiabTools.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;
        public DelegateCommand OnBtnScan_Clicked { get; set; }

        private string _btnScanText;
        public string btnScanText
        {
            get { return _btnScanText; }
            set { SetProperty(ref _btnScanText, value); }
        }
        private string _bleDevPickerText;
        public string bleDevPickerText
        {
            get { return _bleDevPickerText; }
            set { SetProperty(ref _bleDevPickerText, value); }
        }
        public MasterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            btnScanText = "SCAN";
            bleDevPickerText = "Please find devices - press SCAN button ...";
            OnBtnScan_Clicked = new DelegateCommand(btnScanCommand);
        }

        private void btnScanCommand()
        {
            btnScanText = "scanning...";

        }
    }
}
