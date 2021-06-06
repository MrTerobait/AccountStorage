using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace AccountStorage.Behaviors
{
    public class SetDataContextAsSelectedItemBehavior : Behavior<Button>
    {
        private Selector selector;
        protected override void OnAttached()
        {
            var child = AssociatedObject as DependencyObject;
            var parent = LogicalTreeHelper.GetParent(AssociatedObject);
            while (!(parent is Selector))
            {
                child = parent;
                parent = VisualTreeHelper.GetParent(child);
            }
            selector = parent as Selector;
            AssociatedObject.Click += ButtonClick;
        }
        protected override void OnDetaching()
        {
            AssociatedObject.Click -= ButtonClick;
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            selector.SelectedItem = AssociatedObject.DataContext;
        }
    }
}
