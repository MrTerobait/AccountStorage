using System.Windows;
using System.Windows.Media;

namespace AccountStorage.Extensions
{
    public static class DependencyObjectExtensions
    {
        public static DependencyObject FindVisualRoot(this DependencyObject obj) 
        {
            var parent = VisualTreeHelper.GetParent(obj);
            while (parent != null)
            {
                obj = parent;
                parent = VisualTreeHelper.GetParent(obj);
            }
            return obj;
        }
    }
}
