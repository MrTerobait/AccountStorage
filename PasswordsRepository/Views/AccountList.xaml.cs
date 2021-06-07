using AccountStorage.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace AccountStorage.View
{
    /// <summary>
    /// Interaction logic for AccountList.xaml
    /// </summary>
    public partial class AccountList : UserControl
    {
        public AccountList()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox.SelectedItem == null)
            {
                SelectedAccountView.Visibility = Visibility.Collapsed;
                AccountListView.Visibility = Visibility.Visible;
            }
            else
            {
                AccountListView.Visibility = Visibility.Collapsed;
                SelectedAccountView.Visibility = Visibility.Visible;
            }
        }

        private void CloseSelectedAccountViewButton_Click(object sender, RoutedEventArgs e)
        {
            AccountListBox.SelectedItem = null;
        }
    }
}
