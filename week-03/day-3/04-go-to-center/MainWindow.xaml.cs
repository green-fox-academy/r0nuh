using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _04_go_to_center
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
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.

            DrawLines(foxDraw, 0, 100);
            DrawLines(foxDraw, 100, 10);
            DrawLines(foxDraw, 50, 350);
        }
        public static void DrawLines(FoxDraw foxDraw, int X, int Y)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            var startPoint = new Point(X, Y);
            var endPoint = new Point(262.5, 175);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
