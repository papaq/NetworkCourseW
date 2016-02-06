using System.Windows;
using System.Windows.Controls;

namespace NetworksCeW
{
    internal static class ContextMenuOpts
    {

        // B I N D I N G S   C O N T E X T  I T E M S

        public static MenuItem AddNewItem(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "New unit",
                IsEnabled = enabled,
                Style = style //(Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // AddUnit_Click;
            return item;
        }

        public static MenuItem SetEditItem(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Edit unit",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // EditUnit_Click;
            return item;
        }

        public static MenuItem SetDisabledItem(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Disable unit",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // DisableUnit_Click;
            return item;
        }

        public static MenuItem SetEnabledItem(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Enable unit",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // EnableUnit_Click;
            return item;
        }

        public static MenuItem DeleteItem(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Delete unit",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // DeleteUnit_Click;
            return item;
        }

        public static MenuItem ConnectItem(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Connect",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // ConnectUnit_Click;
            return item;
        }


        // B I N D I N G S   C O N T E X T  I T E M S

        public static MenuItem EditBinding(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Edit",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // EditBinding_Click;
            return item;
        }

        public static MenuItem SetDisabledBinding(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Disable binding",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // DisableBinding_Click;
            return item;
        }

        public static MenuItem SetEnabledBinding(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Enable binding",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // EnableBinding_Click;
            return item;
        }

        public static MenuItem DeleteBinding(bool enabled, Style style, RoutedEventHandler reHandler)
        {
            var item = new MenuItem
            {
                Header = "Delete",
                IsEnabled = enabled,
                Style = style // (Style)FindResource("ContextMenuItem")
            };
            item.Click += reHandler; // DeleteBinding_Click;
            return item;
        }

    }
}
