using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUtilsSample.Services;

namespace XamarinUtilsSample.ViewModels
{
    public class DeviceOrientationViewModel : BaseViewModel
    {
        public string ButtonText { get; set; } = "Show device orientation";
        public ICommand DeviceOrientationCommand { get; set; }
        public string LabelText { get; set; }
        public string TitleText { get; set; } = "Device Orientation";
        public DeviceOrientationViewModel(IDeviceOrientationService orientationService, INavigationService navigationService, IPageDialogService pageDialogService) : base(orientationService, navigationService, pageDialogService)
        {
            LabelText = orientationService.GetDeviceOrientation().ToString();
            DeviceOrientationCommand = new Command(GetDeviceOrientation);
        }

        private void GetDeviceOrientation()
        {
            LabelText = DeviceOrientation.GetDeviceOrientation().ToString();
        }
    }
}
