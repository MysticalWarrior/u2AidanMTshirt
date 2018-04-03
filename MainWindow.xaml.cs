//Aidan McClung
//April 2, 2018
//u2AidanMTshirt
// Generates a number of chuck norris photographs
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

namespace u2AidanMcClungTshirt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //make a frame
            

        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int input = 0;
            int.TryParse(txtInput.Text, out input);
            if (input > 9000)
            {
                Label victory = new Label();
                victory.Content = "That can't be right!";
                shirtCanvas.Children.Add(victory);
            }
            else
            {

                for (int i = 0; i < input; i++)
                {
                    Ellipse Frame = new Ellipse();
                    Frame.Width = 250;
                    Frame.Height = 450 / input;
                    Frame.StrokeThickness = 10 / input;
                    Frame.Stroke = Brushes.SandyBrown;
                    //put chuck noris in it
                    ImageBrush chuck = new ImageBrush();
                    chuck.ImageSource = new BitmapImage(new Uri
                       ("https://res.cloudinary.com/jerrick/image/upload/c_fit,f_auto,fl_progressive,q_auto,w_1100/wvanipvk1xocft2jsthp"));
                    Frame.Fill = chuck;
                    shirtCanvas.Children.Add(Frame);
                }
            }
        }

        private void myGrid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
