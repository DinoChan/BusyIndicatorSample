using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace BusyIndicatorSample.Views
{
    public sealed partial class Sample1Page : Page, INotifyPropertyChanged
    {
        public Sample1Page()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private async void AppBarButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            BusyIndicator.IsBusy = true;

            await Task.Delay(3000);

            BusyIndicator.IsBusy = false;

            Image image = new Image();
            image.Source =new BitmapImage(new Uri("ms-appx:///Views/02.jpg"));
            ContentControl.Content = image;
        }
    }
}
