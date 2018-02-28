using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BusyIndicatorSample.Views
{
    public sealed partial class BacisPage : Page, INotifyPropertyChanged
    {
        public BacisPage()
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Delay(TimeSpan.FromSeconds(3));
            BusyIndicator.IsBusy = false;
            
            Root.Children.Remove(WebView);
            BusyIndicator.Content = WebView;
        }
    }
}
