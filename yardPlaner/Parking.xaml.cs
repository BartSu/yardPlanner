using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace yardPlaner
{
    /// <summary>
    /// Interaction logic for Parking.xaml
    /// </summary>
    /// 

    public partial class Parking : Window
    {
        Image[] smallPlot = new Image[15];
        Image[] middlePlot = new Image[20];
        Image[] largePlot = new Image[10];

        public Parking()
        {
            InitializeComponent();

            smallPlot[0] = image0;
            smallPlot[1] = image1;
            smallPlot[2] = image2;
            smallPlot[3] = image3;
            smallPlot[4] = image4;
            smallPlot[5] = image5;
            smallPlot[6] = image6;
            smallPlot[7] = image7;
            smallPlot[8] = image8;
            smallPlot[9] = image9;
            smallPlot[10] = image10;
            smallPlot[11] = image11;
            smallPlot[12] = image12;
            smallPlot[13] = image13;
            smallPlot[14] = image14;
            middlePlot[0] = image15;
            middlePlot[1] = image16;
            middlePlot[2] = image17;
            middlePlot[3] = image18;
            middlePlot[4] = image19;
            middlePlot[5] = image20;
            middlePlot[6] = image21;
            middlePlot[7] = image22;
            middlePlot[8] = image23;
            middlePlot[9] = image24;
            middlePlot[10] = image25;
            middlePlot[11] = image26;
            middlePlot[12] = image27;
            middlePlot[13] = image28;
            middlePlot[14] = image29;
            middlePlot[15] = image30;
            middlePlot[16] = image31;
            middlePlot[17] = image32;
            middlePlot[18] = image33;
            middlePlot[19] = image34;
            largePlot[0] = image35;
            largePlot[1] = image36;
            largePlot[2] = image37;
            largePlot[3] = image38;
            largePlot[4] = image39;
            largePlot[5] = image40;
            largePlot[6] = image41;
            largePlot[7] = image42;
            largePlot[8] = image43;
            largePlot[9] = image44;

            // image1.Source = (ImageSource)Resources["small"];
            //image1.Visibility = Visibility.Visible;

            show(glbV.smallslot, glbV.middleslot, glbV.largeslot);
        }

        // 3 array need to pass to this function
        // small array represent the small slot 
        // middle array represent the middle slot 
        // large array represent the large slot
        // 0 represent small car in it , 1 represent middle car in it , 2 represent large car in it
        public void show(int[] small, int[] middle, int[] large)
        {
            for (int i = 0; i < smallPlot.Length; i++)
            {
                if (small[i] == 0)
                {
                    smallPlot[i].Source = (ImageSource)Resources["small"];
                }
            }
            for (int i = 0; i < middlePlot.Length; i++)
            {
                if (middle[i] == 0)
                {
                    middlePlot[i].Source = (ImageSource)Resources["small"];
                }
                if (middle[i] == 1)
                {
                    middlePlot[i].Source = (ImageSource)Resources["middle"];
                }
            }
            for (int i = 0; i < largePlot.Length; i++)
            {
                if (large[i] == 0)
                {
                    largePlot[i].Source = (ImageSource)Resources["small"];
                }
                if (large[i] == 1)
                {
                    largePlot[i].Source = (ImageSource)Resources["middle"];
                }
                if (large[i] == 2)
                {
                    largePlot[i].Source = (ImageSource)Resources["large"];
                }
            }
        }
    }
}
