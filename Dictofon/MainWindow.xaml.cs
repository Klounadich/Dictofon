using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dictofon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public void WindowMove (object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        public void Close(object sender, MouseButtonEventArgs click)
        {
            Close();
        }
        public void Minimazed(object sender, MouseButtonEventArgs click)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
    
    }