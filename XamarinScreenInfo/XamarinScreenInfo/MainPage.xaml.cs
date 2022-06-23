using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinScreenInfo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        // Device Model (SMG-950U, iPhone10,6)
        public string Model { get; set; }

        // Manufacturer (Samsung)
        public string Manufacturer { get; set; }
        // Device Name(Motz's iPhone)

        public string DeviceInfoName { get; set; }
        // Operating System Version Number(7.0)
        public string DeviceInfoVersionString { get; set; }
        //  Platform(Android)
        public string DevicePlatform { get; set; } 
        //   Idiom(Phone)
        public string DeviceIdiom { get; set; }
        //  Device Type(Physical)
        public string DeviceType { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Model = DeviceInfo.Model;
            Manufacturer = DeviceInfo.Manufacturer;
            DeviceInfoName = DeviceInfo.Name;
            DeviceInfoVersionString = DeviceInfo.VersionString;
            DevicePlatform = DeviceInfo.Platform.ToString();
            DeviceIdiom = DeviceInfo.Idiom.ToString();
            DeviceType = DeviceInfo.DeviceType.ToString();
            BindingContext = this;

            
        }
    }
}
