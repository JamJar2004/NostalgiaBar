using System.Windows;

namespace NostalgiaBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Taskbar : Window
    {
        public Taskbar()
        {
            InitializeComponent();
        }

        private void Taskbar_Loaded(object sender, RoutedEventArgs e)
        {
            var screenWidth  = SystemParameters.PrimaryScreenWidth;
            var screenHeight = SystemParameters.PrimaryScreenHeight;

            Left  = 0;
            Top   = screenHeight - Height;

            Width = screenWidth;    
        }
    }
}