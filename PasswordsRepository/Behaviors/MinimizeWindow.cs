using AccountStorage.Extensions;
using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace AccountStorage.Behaviors
{
    public class MinimizeWindow : Behavior<Button>
    {
        protected override void OnAttached() => AssociatedObject.Click += OnButtonClick;
        protected override void OnDetaching() => AssociatedObject.Click -= OnButtonClick;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Window window = AssociatedObject.FindVisualRoot() as Window;
            if (window is null) return;

            window.WindowState = WindowState.Minimized;
        }
    }
}
