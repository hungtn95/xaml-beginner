using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    using RestaurantManager.Models;
    public sealed partial class ExpeditePage : Page
    {
        public ExpeditePage()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            DataManager t = (DataManager)ListViewMenu.DataContext;
            if (ListViewMenu.SelectedIndex != -1) 
                t.CurrentlySelectedMenuItems.Add((String)ListViewMenu.SelectedValue);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            DataManager t = (DataManager)ListViewSelected.DataContext;
            if (t.CurrentlySelectedMenuItems.Count != 0)
            {
                t.OrderItems.Add(String.Join(", ", t.CurrentlySelectedMenuItems));
                t.CurrentlySelectedMenuItems.Clear();
            }
        }
    }
}
