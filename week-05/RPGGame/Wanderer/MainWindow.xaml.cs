using GreenFox;
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

namespace Wanderer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var FoxDraw = new FoxDraw(canvas);

            int[,] map = new int[,]
            {
                {0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                {0, 0, 0, 1, 0, 1, 0, 1, 1, 0 },
                {0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                {1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                {0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                {0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                {0, 1, 1, 1, 0, 0, 0, 0, 1, 0 },
                {0, 0, 0, 1, 0, 1, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 0, 0, 0 }
            };
            int x = 0;
            int y = 0;

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (map[i,j] == 0)
                    {
                        FoxDraw.AddImage("Assets/floor.png", x, y);
                        x += 50;
                    }
                    else
                    {
                        FoxDraw.AddImage("Assets/wall.png", x, y);
                        x += 50;
                    }
                }
                x = 0;
                y += 50;
            }
        }

     
    }
}

