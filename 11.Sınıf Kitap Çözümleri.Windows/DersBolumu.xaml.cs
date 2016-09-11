using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace _11.Sınıf_Kitap_Çözümleri
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DersBolumu : Page
    {
        public static string DersAdı;
        public DersBolumu()
        {
            this.Loaded+=DersBolumu_Loaded;
            this.InitializeComponent();
        }
        async void DersBolumu_Loaded(object sender, RoutedEventArgs e)
        {
            txtDersAdı.Text = DersAdı;
            var _Folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            _Folder = await _Folder.GetFolderAsync("Assets");
            var _File = await _Folder.GetFileAsync(MainPage.Dersler);
            txtDersicerik.Text = await Windows.Storage.FileIO.ReadTextAsync(_File, Windows.Storage.Streams.UnicodeEncoding.Utf8);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
