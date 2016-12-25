using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            var currentItmeIndex = 1;

            SetCurrentSelectedItem(sender, currentItmeIndex);

            this.SetRestultText();
        }

        private void CreamMenuFlyoutItem_OnClick(object sender, RoutedEventArgs e)
        {
            var currentItmeIndex = 2;

            this.SetCurrentSelectedItem(sender, currentItmeIndex);

            this.SetRestultText();
        }

        private void SetCurrentSelectedItem(object sender, int currentItmeIndex)
        {
            var item = sender as MenuFlyoutItem;

            if (item != null)
            {
                if (item.Text != "None" && this.IsCoffeeSelecetd)
                {
                    this.SelectedItems[currentItmeIndex] = item.Text;
                }
                else
                {
                    this.SelectedItems[currentItmeIndex] = string.Empty;
                }
            }
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
