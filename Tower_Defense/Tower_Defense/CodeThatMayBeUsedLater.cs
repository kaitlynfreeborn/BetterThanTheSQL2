using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defense
{
    class CodeThatMayBeUsedLater
    {

        using System.Windows.Threading;
using System.Windows.Threading.DispatcherTimer.Tick handler;

namespace Tower_Defense
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            private int _x;
            private int _y;


            public MainWindow()
            {
                InitializeComponent();

                _x = 50;
            }

            private void loaded(object sender, RoutedEventArgs e)
            {

            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {

            }

            private void MainWindow_Paint(object sender, PaintEventArgs e)
            {
                e.Graphics.FillRectangle(Brushes.Blue, _x, _y, 100, 100);
            }

            public event EventHandler Tick;
            public TimeSpan Interval { get; set; }
            public TimeSpan TimeSpan { get; }

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick +=new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        private void dispatcherTimer_Tick(object sender, EventArgs e)

            {

                // code

            }
        }
}
