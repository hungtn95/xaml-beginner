using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    using RestaurantManager.Models;
    public sealed partial class Order : Page
    {
        public Order()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataManager t = (DataManager)GridView1.DataContext;
            t.OrderItems.Clear();
        }

    }
}
