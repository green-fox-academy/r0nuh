using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _01_middle_lines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.

            DrawLines(foxDraw);
        }

        public static void DrawLines(FoxDraw foxDraw)
        {
            foxDraw.BackgroundColor(Colors.Gray);
            foxDraw.StrokeColor(Colors.Red); 
            foxDraw.DrawLine(262.5, 0, 262.5, 350);

            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(0, 175);
            var endPoint = new Point(525, 175);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
