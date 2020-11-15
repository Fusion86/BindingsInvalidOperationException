using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BindingsInvalidOperationException.Views
{
    public class TabPageView : UserControl
    {
        public TabPageView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
