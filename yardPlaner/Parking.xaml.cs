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
using System.Windows.Shapes;

namespace yardPlaner
{
    /// <summary>
    /// Interaction logic for Parking.xaml
    /// </summary>
    public partial class Parking : Window
    {

        Image[] smallGreen = new Image[30];
        Image[] smallRed = new Image[30];
        Image[] middleGreen = new Image[40];
        Image[] middleRed = new Image[40];
        Image[] largeGreen = new Image[30];
        Image[] largeRed = new Image[30];


        public Parking()
        {
            smallGreen[1] = image1green;
            smallGreen[2] = image2green;
            smallGreen[3] = image3green;
            smallGreen[4] = image4green;
            smallGreen[5] = image5green;
            smallGreen[6] = image6green;
            smallGreen[7] = image7green;
            smallGreen[8] = image8green;
            smallGreen[9] = image9green;
            smallGreen[10] = image10green;
            smallGreen[11] = image11green;
            smallGreen[12] = image12green;
            smallGreen[13] = image13green;
            smallGreen[14] = image14green;
            smallGreen[15] = image15green;
            smallGreen[16] = image16green;
            smallGreen[17] = image17green;
            smallGreen[18] = image18green;
            smallGreen[19] = image19green;
            smallGreen[20] = image20green;
            smallGreen[21] = image21green;
            smallGreen[22] = image22green;
            smallGreen[23] = image23green;
            smallGreen[23] = image24green;
            smallGreen[25] = image25green;
            smallGreen[26] = image26green;
            smallGreen[27] = image27green;
            smallGreen[28] = image28green;
            smallGreen[29] = image29green;
            smallGreen[30] = image30green;


            middleGreen[1] = image31green;
            middleGreen[2] = image32green;
            middleGreen[3] = image33green;
            middleGreen[4] = image34green;
            middleGreen[5] = image35green;
            middleGreen[6] = image36green;
            middleGreen[7] = image37green;
            middleGreen[8] = image38green;
            middleGreen[9] = image39green;
            middleGreen[10] = image40green;
            middleGreen[11] = image41green;
            middleGreen[12] = image42green;
            middleGreen[13] = image43green;
            middleGreen[14] = image44green;
            middleGreen[15] = image45green;
            middleGreen[16] = image46green;
            middleGreen[17] = image47green;
            middleGreen[18] = image48green;
            middleGreen[19] = image49green;
            middleGreen[20] = image50green;
            middleGreen[21] = image51green;
            middleGreen[22] = image52green;
            middleGreen[23] = image53green;
            middleGreen[23] = image54green;
            middleGreen[25] = image55green;
            middleGreen[26] = image56green;
            middleGreen[27] = image57green;
            middleGreen[28] = image58green;
            middleGreen[29] = image59green;
            middleGreen[30] = image60green;
            middleGreen[31] = image61green;
            middleGreen[32] = image62green;
            middleGreen[33] = image63green;
            middleGreen[34] = image64green;
            middleGreen[35] = image65green;
            middleGreen[36] = image66green;
            middleGreen[37] = image67green;
            middleGreen[38] = image68green;
            middleGreen[39] = image69green;
            middleGreen[40] = image70green;

            largeGreen[1] = image71green;
            largeGreen[2] = image72green;
            largeGreen[3] = image73green;
            largeGreen[4] = image74green;
            largeGreen[5] = image75green;
            largeGreen[6] = image76green;
            largeGreen[7] = image77green;
            largeGreen[8] = image78green;
            largeGreen[9] = image79green;
            largeGreen[10] = image80green;
            largeGreen[11] = image81green;
            largeGreen[12] = image82green;
            largeGreen[13] = image83green;
            largeGreen[14] = image84green;
            largeGreen[15] = image85green;
            largeGreen[16] = image86green;
            largeGreen[17] = image87green;
            largeGreen[18] = image88green;
            largeGreen[19] = image89green;
            largeGreen[20] = image90green;
            largeGreen[21] = image91green;
            largeGreen[22] = image92green;
            largeGreen[23] = image93green;
            largeGreen[23] = image94green;
            largeGreen[25] = image95green;
            largeGreen[26] = image96green;
            largeGreen[27] = image97green;
            largeGreen[28] = image98green;
            largeGreen[29] = image99green;
            largeGreen[30] = image100green;

            smallRed[1] = image1red;
            smallRed[2] = image2red;
            smallRed[3] = image3red;
            smallRed[4] = image4red;
            smallRed[5] = image5red;
            smallRed[6] = image6red;
            smallRed[7] = image7red;
            smallRed[8] = image8red;
            smallRed[9] = image9red;
            smallRed[10] = image10red;
            smallRed[11] = image11red;
            smallRed[12] = image12red;
            smallRed[13] = image13red;
            smallRed[14] = image14red;
            smallRed[15] = image15red;
            smallRed[16] = image16red;
            smallRed[17] = image17red;
            smallRed[18] = image18red;
            smallRed[19] = image19red;
            smallRed[20] = image20red;
            smallRed[21] = image21red;
            smallRed[22] = image22red;
            smallRed[23] = image23red;
            smallRed[23] = image24red;
            smallRed[25] = image25red;
            smallRed[26] = image26red;
            smallRed[27] = image27red;
            smallRed[28] = image28red;
            smallRed[29] = image29red;
            smallRed[30] = image30red;


            middleRed[1] = image31red;
            middleRed[2] = image32red;
            middleRed[3] = image33red;
            middleRed[4] = image34red;
            middleRed[5] = image35red;
            middleRed[6] = image36red;
            middleRed[7] = image37red;
            middleRed[8] = image38red;
            middleRed[9] = image39red;
            middleRed[10] = image40red;
            middleRed[11] = image41red;
            middleRed[12] = image42red;
            middleRed[13] = image43red;
            middleRed[14] = image44red;
            middleRed[15] = image45red;
            middleRed[16] = image46red;
            middleRed[17] = image47red;
            middleRed[18] = image48red;
            middleRed[19] = image49red;
            middleRed[20] = image50red;
            middleRed[21] = image51red;
            middleRed[22] = image52red;
            middleRed[23] = image53red;
            middleRed[23] = image54red;
            middleRed[25] = image55red;
            middleRed[26] = image56red;
            middleRed[27] = image57red;
            middleRed[28] = image58red;
            middleRed[29] = image59red;
            middleRed[30] = image60red;
            middleRed[31] = image61red;
            middleRed[32] = image62red;
            middleRed[33] = image63red;
            middleRed[34] = image64red;
            middleRed[35] = image65red;
            middleRed[36] = image66red;
            middleRed[37] = image67red;
            middleRed[38] = image68red;
            middleRed[39] = image69red;
            middleRed[40] = image70red;

            largeRed[1] = image71red;
            largeRed[2] = image72red;
            largeRed[3] = image73red;
            largeRed[4] = image74red;
            largeRed[5] = image75red;
            largeRed[6] = image76red;
            largeRed[7] = image77red;
            largeRed[8] = image78red;
            largeRed[9] = image79red;
            largeRed[10] = image80red;
            largeRed[11] = image81red;
            largeRed[12] = image82red;
            largeRed[13] = image83red;
            largeRed[14] = image84red;
            largeRed[15] = image85red;
            largeRed[16] = image86red;
            largeRed[17] = image87red;
            largeRed[18] = image88red;
            largeRed[19] = image89red;
            largeRed[20] = image90red;
            largeRed[21] = image91red;
            largeRed[22] = image92red;
            largeRed[23] = image93red;
            largeRed[23] = image94red;
            largeRed[25] = image95red;
            largeRed[26] = image96red;
            largeRed[27] = image97red;
            largeRed[28] = image98red;
            largeRed[29] = image99red;
            largeRed[30] = image100red;

            foreach (Image i in smallGreen)
            {
                i.Visibility = Visibility.Collapsed;
            }
            foreach (Image i in middleGreen)
            {
                i.Visibility = Visibility.Collapsed;
            }
            foreach (Image i in largeGreen)
            {
                i.Visibility = Visibility.Collapsed;
            }
            foreach (Image i in smallRed)
            {
                i.Visibility = Visibility.Collapsed;
            }
            foreach (Image i in middleRed)
            {
                i.Visibility = Visibility.Collapsed;
            }
            foreach (Image i in largeRed)
            {
                i.Visibility = Visibility.Collapsed;
            }

            InitializeComponent();

            
        }

        // smallNumbers represent the numebrs of smmall car, 
        // middlenNumbers represent the numbers of middle car,
        // largeNumbers represent the numbers of large cars
        // this function need to pass the numbers of each catagory,
        // and show green as avalibe, red as unavalible
        public void show(int smallNumbers,int middleNumbers, int largeNumbers)
        {
            for(int i = 1; i <=smallNumbers; i++)
            {
                smallRed[i].Visibility = Visibility.Visible;
            }
            for(int i=smallNumbers+1; i <= smallGreen.Length; i++)
            {
                smallGreen[i].Visibility = Visibility.Visible;
            }
            for (int i = 1; i <= middleNumbers; i++)
            {
                middleRed[i].Visibility = Visibility.Visible;
            }
            for (int i = middleNumbers + 1; i <= middleGreen.Length; i++)
            {
                middleGreen[i].Visibility = Visibility.Visible;
            }
            for (int i = 1; i <= largeNumbers; i++)
            {
                largeRed[i].Visibility = Visibility.Visible;
            }
            for (int i = largeNumbers + 1; i <= largeGreen.Length; i++)
            {
                largeGreen[i].Visibility = Visibility.Visible;
            }




        }
    }
}
