using AccountStorage.Extensions;
using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace AccountStorage.Behaviors
{
    public class ChangeWindowState : Behavior<Button>
    {
        protected override void OnAttached() => AssociatedObject.Click += OnButtonClick;
        protected override void OnDetaching() => AssociatedObject.Click -= OnButtonClick;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Window window = AssociatedObject.FindVisualRoot() as Window;
            if (window is null) return;

            switch (window.WindowState)
            {
                case WindowState.Normal:
                    window.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Maximized:
                    window.WindowState = WindowState.Normal;
                    break;
            }
        }
    }
}
