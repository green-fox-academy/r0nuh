using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _06_centered_square
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
            // draw a green 10x10 square to the canvas' center.

            DrawRectangle(foxDraw);
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.BackgroundColor(Colors.LightSalmon);
            foxDraw.DrawRectangle(257.5, 170, 10, 10);
        }
    }
}
