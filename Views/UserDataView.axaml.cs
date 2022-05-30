using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ManageX.Views
{
    public partial class UserDataView : UserControl
    {
        public UserDataView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}