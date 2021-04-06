using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinUtilsSample.Services;

namespace XamarinUtilsSample.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected INavigationService NavigationService { get; }
        protected IPageDialogService PageDialogService { get; }
        protected IDeviceOrientationService DeviceOrientation { get;  }

        protected BaseViewModel(IDeviceOrientationService orientationService, INavigationService navigationService, IPageDialogService pageDialogService)
        {
            NavigationService = navigationService;

            PageDialogService = pageDialogService;

            DeviceOrientation = orientationService;


        }


    }
}
