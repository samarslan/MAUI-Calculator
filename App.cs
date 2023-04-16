using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Calculator
{
    public partial class App : Application
    {

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 480;
            const int newHeight = 720;

            //int newWidth = (int)Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Width / 4;
            //int newHeight = ((int)Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Height / 3)*2;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}
