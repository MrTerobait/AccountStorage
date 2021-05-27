using System.Windows.Media;

namespace System.Windows
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

        public static DependencyObject FindLogicalRoot(this DependencyObject obj)
        {
            var parent = LogicalTreeHelper.GetParent(obj);
            while (parent != null)
            {
                obj = parent;
                parent = LogicalTreeHelper.GetParent(obj);
            }
            return obj;
        }

        public static T FindVisualParent<T>(this DependencyObject obj)
           where T : DependencyObject
        {
            if (obj is null) return null;
            var target = obj;
            do
            {
                target = VisualTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));

            return target as T;
        }

        public static T FindLogicalParent<T>(this DependencyObject obj)
            where T : DependencyObject
        {
            if (obj is null) return null;
            var target = obj;
            do
            {
                target = LogicalTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));

            return target as T;
        }
    }
}
