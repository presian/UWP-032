﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_032
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Pages.Navigate(typeof(DonutPage));
        }

        private void DonutsNavigationButton_OnClick(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(typeof(DonutPage));
        }

        private void CoffeeButton_OnClick(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(typeof(CoffeePage));
        }

        private void ScheduleButton_OnClick(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(typeof(SchedulePage));
        }

        private void CompleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(typeof(CompletePage));
        }
    }
}
