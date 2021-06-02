using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace AccountStorage.Behaviors
{
    public class ChooseButtonBehavior : Behavior<Panel>
    {
        private Button chosenButton;
        protected override void OnAttached()
        {
            foreach (Button child in AssociatedObject.Children)
            {
                child.Click += ButtonClick;
                if (!child.IsEnabled) chosenButton = child;               
            }
        }
        protected override void OnDetaching()
        {
            foreach (Button child in AssociatedObject.Children)
            {
                child.Click -= ButtonClick;
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (chosenButton != null)
            {
                chosenButton.IsEnabled = true;
            }
            chosenButton = sender as Button;
            chosenButton.IsEnabled = false;
        }
    }
}
