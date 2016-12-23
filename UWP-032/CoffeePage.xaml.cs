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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_032
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private bool IsCoffeeSelecetd = false;
        private string[] SelectedItems = new string[3];

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void CoffeeMenuFlyoutItem_OnClick(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuFlyoutItem;
            if (item != null)
            {
                if (item.Text != "None")
                {
                    this.IsCoffeeSelecetd = true;
                    this.SelectedItems[0] = item.Text;
                }
                else
                {
                    this.IsCoffeeSelecetd = false;
                    this.SelectedItems = new string[3];
                    this.CoffeeResult.Text = string.Empty;
                }
            }

            this.SetRestultText();
        }

       

        private void SweetenerMenuFlyoutItem_OnClick(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuFlyoutItem;
            if (item != null)
            {
                if (item.Text != "None" && this.IsCoffeeSelecetd)
                {
                    this.SelectedItems[1] = item.Text;
                }
            }

            this.SetRestultText();
        }

        private void CreamMenuFlyoutItem_OnClick(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuFlyoutItem;

            if (item != null)
            {
                if (item.Text != "None" && this.IsCoffeeSelecetd)
                {
                    this.SelectedItems[2] = item.Text;
                }
            }

            this.SetRestultText();
        }

        private void SetRestultText()
        {
            if (this.IsCoffeeSelecetd)
            {
                this.CoffeeResult.Text = string.Join("+", this.SelectedItems.Where(t => !string.IsNullOrEmpty(t)));
            }
        }
    }
}
