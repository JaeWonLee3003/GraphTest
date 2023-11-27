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

namespace GraphTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            timer.Start();

            /*RunButton.Click += RunButton_Click;*/
            ExitButton.Click += ExitButton_Click;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {










            /*int count = 50;
            if (FirstPolyline.Points.Count == 0)
            {
                PointCollection pc = new PointCollection();
                int next = 150;
                for (int i = 0; i < count; i++)
                {
                    pc.Add(new Point(i*20 + 10, next));
                    int priv = random.Next(20) - 10;
                    next = priv + next;

                }
                FirstPolyline.Points = pc;
            }
            else
            {
                PointCollection pc = new PointCollection();
                for (int i = 0; i < FirstPolyline.Points.Count - 1; i++)
                {
                    pc.Add(new Point(FirstPolyline.Points[i].X, FirstPolyline.Points[i+1].Y));
                }
                double next = (random.Next(40) - 20) + FirstPolyline.Points[FirstPolyline.Points.Count - 1].Y;
                pc.Add(new Point(FirstPolyline.Points[FirstPolyline.Points.Count - 1].X, next));


                FirstPolyline.Points = pc;
            }*/
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
