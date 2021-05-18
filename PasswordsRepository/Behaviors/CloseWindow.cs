using AccountStorage.Extensions;
using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace AccountStorage.Behaviors
{
    public class CloseWindow : Behavior<Button>
    {
        protected override void OnAttached() => AssociatedObject.Click += OnButtonClick;
        protected override void OnDetaching() => AssociatedObject.Click -= OnButtonClick;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            var button = AssociatedObject as DependencyObject;
            Window window = button.FindVisualRoot() as Window;
            window?.Close();
        }    
    }
}
