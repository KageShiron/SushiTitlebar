using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SushiTitlebar
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer;
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer(DispatcherPriority.Normal);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(50);
            int i = 0;
            dispatcherTimer.Tick += (_, __) => this.Title = ((i++ % 10) == 0 ? "🍣" : " ") + this.Title;
            dispatcherTimer.Start();
        }
    }
}
