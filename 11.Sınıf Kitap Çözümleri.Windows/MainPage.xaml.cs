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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            BtnGit.Visibility = Visibility.Collapsed;
        }


        public static string Dersler;
        string[] Edebiyat = { "11-18", "22-27", "28-39", "40-50", "59-64", "81-99", "106-109", "110-121", "122-135", "139-144", "145-158", "159-163", "169-172", "175-184", "187-198", "201-223" };
        string[] DilAnlatim = { "11-23", "27-41", "42-51", "53-65", "66-80", "81-92", "96-107", "108-121", "123-132", "134-146", "147-161", "162-174", "175-177", "178-192", "193-208", "209-221" };
        public static string ders;



        private void BtnDil_Click(object sender, RoutedEventArgs e)
        {
            DersBolumu.DersAdı = "Dil Ve Anlatım";
            ders = "dil ";
            Combobox.Items.Clear();

            for (int i = 0; i < 16; i++)
            {
                Combobox.Items.Add(DilAnlatim[i]);
            }

            Combobox.IsEnabled = true;

            this.BtnDil.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            this.BtnDil.Background.Opacity = 0.2;
            this.BtnEdb.Background.Opacity = 0;
        }

        private void BtnEdb_Click(object sender, RoutedEventArgs e)
        {
            DersBolumu.DersAdı = "Edebiyat";
            ders = "edb ";
            Combobox.Items.Clear();

            for (int i = 0; i < 16; i++)
            {
                Combobox.Items.Add(Edebiyat[i]);
            }

            Combobox.IsEnabled = true;

            this.BtnEdb.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            this.BtnEdb.Background.Opacity = 0.2;
            this.BtnDil.Background.Opacity = 0;
        }


        private void BtnGit_Click(object sender, RoutedEventArgs e)
        {

            Dersler = ders + Combobox.SelectedItem.ToString() + ".txt";
            //BtnEdb.Content = Dersler;
            Frame.Navigate(typeof(DersBolumu));
            BtnGit.IsEnabled = false;
            Combobox.IsEnabled = false;
            BtnGit.Visibility = Visibility.Collapsed;
            this.BtnDil.Background.Opacity = 0;
            this.BtnEdb.Background.Opacity = 0;
            
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combobox.SelectedIndex >= 0)
            {
                BtnGit.Visibility = Visibility.Visible;
                BtnGit.IsEnabled = true;
            }
            else
            {
                BtnGit.Visibility = Visibility.Collapsed;
                BtnGit.IsEnabled = false;
            }
        }



        public Brush Brushes { get; set; }
    }
}
