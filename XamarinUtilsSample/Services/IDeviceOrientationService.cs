﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace XamarinUtilsSample.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetDeviceOrientation();
    }
}
