using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraphicEditor
{
    public partial class MainWindow : Window
    {
        private double brushSize = 5;

        public MainWindow()
        {
            InitializeComponent();

            IfCancasNeNull();
        }

        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = e.NewValue;
            IfCancasNeNull();
        }

        private void lbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IfCancasNeNull();
        }



        private void IfCancasNeNull()
        {
            if (Canvas != null)
            {
                Canvas.DefaultDrawingAttributes.Width = brushSize;
                Canvas.DefaultDrawingAttributes.Height = brushSize;
            }
        }

    }
}