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
using static System.Net.Mime.MediaTypeNames;

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

            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
            timer.Start();

            /*RunButton.Click += RunButton_Click;*/
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int count = 150;

            if (MainPolyline.Points.Count == 0)
            {
                int nextX = 0;
                PointCollection pc = new PointCollection();
                for (int i = 0; i < count; i++)
                {
                    int randomY = random.Next(130, 170);
                    nextX += 10;
                    pc.Add(new Point(nextX, randomY));
                }
                MainPolyline.Points = pc;
            }
            else
            {
                PointCollection pc = new PointCollection();
                for (int i = 0; i < MainPolyline.Points.Count - 1; i++)
                {
                    // Index 단위로 Points List 에서 밀어내기
                    pc.Add(new Point(MainPolyline.Points[i].X, MainPolyline.Points[i + 1].Y));
                }


                int randomY = random.Next(130, 170);
                pc.Add(new Point(MainPolyline.Points[MainPolyline.Points.Count - 1].X, randomY));


                MainPolyline.Points = pc;
            }
        }
    }
}
