using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FakeTravel.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Locate : Page
    {
        public Locate()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainContent));
        }

        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrderPage));
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            var locator = new Geolocator();
            locator.DesiredAccuracyInMeters = 50;
            var position = await locator.GetGeopositionAsync();
            await MyMap.TrySetViewAsync(position.Coordinate.Point, 18D);
            mySlider.Value = MyMap.ZoomLevel;
        }

        private  async void setPositionButton_Click(object sender, RoutedEventArgs e)
        {
            var myPosition = new Windows.Devices.Geolocation.BasicGeoposition();
            myPosition.Latitude = 43.6425657;
            myPosition.Longitude = -79.3892444;
            
            var myPoint = new Windows.Devices.Geolocation.Geopoint(myPosition);
            if(await MyMap.TrySetViewAsync(myPoint, 18D))
            {
                instructBox.Text = "Our location is Toronto, near CN Tower";
            }
        }

        private void mySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (MyMap != null)
            {
                MyMap.ZoomLevel = e.NewValue;
            }
        }
    }
}
