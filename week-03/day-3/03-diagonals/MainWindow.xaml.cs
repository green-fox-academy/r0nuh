using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _03_diagonals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.

            DrawLines(foxDraw);
        }
        public static void DrawLines(FoxDraw foxDraw)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            foxDraw.StrokeColor(Colors.Green);

            var startPoint = new Point(0, 0);
            var endPoint = new Point(525, 350);
            foxDraw.DrawLine(startPoint, endPoint);

            var startPoint1 = new Point(0, 350);
            var endPoint1 = new Point(525, 0);
            foxDraw.DrawLine(startPoint1, endPoint1);
        }
    }
}
