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

namespace Mevo.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MevoUniverseConfig conf = new MevoUniverseConfig();
            conf.CircleChance = .5f;
            conf.TriangleChance = .35f;
            conf.SquareChance = .15f;
            conf.SpawnRadiusInit = 50;
            conf.InitHeight = 300;
            conf.InitWidth = 500;

            MevoUniverse uni = new MevoUniverse();
            uni.Initialize(conf);

            foreach (MevoElement elem in uni.Elements)
            {
                _Viewer.AddElement(MevoUiElement.CreateElement(elem));
            }
        }
    }
}
