using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _02_colored_box
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
            // draw a box that has different colored lines on each edge.

            DrawRectangle(foxDraw);
            DrawLines(foxDraw);
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.YellowGreen);
            foxDraw.DrawRectangle(100, 100, 250, 100);
        }
        public static void DrawLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(100, 100, 350, 100);

            foxDraw.StrokeColor(Colors.BlueViolet);
            foxDraw.DrawLine(350, 100, 350, 200);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(100, 200, 350, 200);

            foxDraw.StrokeColor(Colors.Magenta);
            foxDraw.DrawLine(100, 100, 100, 200);
        }

        }
    }
