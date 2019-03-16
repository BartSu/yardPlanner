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

       

        Image[] smallInSmall = new Image[30];
        Image[] smallInMiddle = new Image[40];
        Image[] smallInLarge = new Image[30];

        Image[] middleInMiddle = new Image[40];
        Image[] middleInLarge = new Image[30];

        Image[] largeInLarge = new Image[30];



        public Parking()
        {
           

            InitializeComponent();

            smallInSmall[0] = image0small;
            smallInSmall[1] = image1small;
            smallInSmall[2] = image2small;
            smallInSmall[3] = image3small;
            smallInSmall[4] = image4small;
            smallInSmall[5] = image5small;
            smallInSmall[6] = image6small;
            smallInSmall[7] = image7small;
            smallInSmall[8] = image8small;
            smallInSmall[9] = image9small;
            smallInSmall[10] = image10small;
            smallInSmall[11] = image11small;
            smallInSmall[12] = image12small;
            smallInSmall[13] = image13small;
            smallInSmall[14] = image14small;
            smallInSmall[15] = image15small;
            smallInSmall[16] = image16small;
            smallInSmall[17] = image17small;
            smallInSmall[18] = image18small;
            smallInSmall[19] = image19small;
            smallInSmall[20] = image20small;
            smallInSmall[21] = image21small;
            smallInSmall[22] = image22small;
            smallInSmall[23] = image23small;
            smallInSmall[24] = image24small;
            smallInSmall[25] = image25small;
            smallInSmall[26] = image26small;
            smallInSmall[27] = image27small;
            smallInSmall[28] = image28small;
            smallInSmall[29] = image29small;
            smallInMiddle[0] = image30small;
            smallInMiddle[1] = image31small;
            smallInMiddle[2] = image32small;
            smallInMiddle[3] = image33small;
            smallInMiddle[4] = image34small;
            smallInMiddle[5] = image35small;
            smallInMiddle[6] = image36small;
            smallInMiddle[7] = image37small;
            smallInMiddle[8] = image38small;
            smallInMiddle[9] = image39small;
            smallInMiddle[10] = image40small;
            smallInMiddle[11] = image41small;
            smallInMiddle[12] = image42small;
            smallInMiddle[13] = image43small;
            smallInMiddle[14] = image44small;
            smallInMiddle[15] = image45small;
            smallInMiddle[16] = image46small;
            smallInMiddle[17] = image47small;
            smallInMiddle[18] = image48small;
            smallInMiddle[19] = image49small;
            smallInMiddle[20] = image50small;
            smallInMiddle[21] = image51small;
            smallInMiddle[22] = image52small;
            smallInMiddle[23] = image53small;
            smallInMiddle[24] = image54small;
            smallInMiddle[25] = image55small;
            smallInMiddle[26] = image56small;
            smallInMiddle[27] = image57small;
            smallInMiddle[28] = image58small;
            smallInMiddle[29] = image59small;
            smallInMiddle[30] = image60small;
            smallInMiddle[31] = image61small;
            smallInMiddle[32] = image62small;
            smallInMiddle[33] = image63small;
            smallInMiddle[34] = image64small;
            smallInMiddle[35] = image65small;
            smallInMiddle[36] = image66small;
            smallInMiddle[37] = image67small;
            smallInMiddle[38] = image68small;
            smallInMiddle[39] = image69small;
            smallInLarge[0] = image70small;
            smallInLarge[1] = image71small;
            smallInLarge[2] = image72small;
            smallInLarge[3] = image73small;
            smallInLarge[4] = image74small;
            smallInLarge[5] = image75small;
            smallInLarge[6] = image76small;
            smallInLarge[7] = image77small;
            smallInLarge[8] = image78small;
            smallInLarge[9] = image79small;
            smallInLarge[10] = image80small;
            smallInLarge[11] = image81small;
            smallInLarge[12] = image82small;
            smallInLarge[13] = image83small;
            smallInLarge[14] = image84small;
            smallInLarge[15] = image85small;
            smallInLarge[16] = image86small;
            smallInLarge[17] = image87small;
            smallInLarge[18] = image88small;
            smallInLarge[19] = image89small;
            smallInLarge[20] = image90small;
            smallInLarge[21] = image91small;
            smallInLarge[22] = image92small;
            smallInLarge[23] = image93small;
            smallInLarge[24] = image94small;
            smallInLarge[25] = image95small;
            smallInLarge[26] = image96small;
            smallInLarge[27] = image97small;
            smallInLarge[28] = image98small;
            smallInLarge[29] = image99small;

            middleInMiddle[0] = image30middle;
            middleInMiddle[1] = image31middle;
            middleInMiddle[2] = image32middle;
            middleInMiddle[3] = image33middle;
            middleInMiddle[4] = image34middle;
            middleInMiddle[5] = image35middle;
            middleInMiddle[6] = image36middle;
            middleInMiddle[7] = image37middle;
            middleInMiddle[8] = image38middle;
            middleInMiddle[9] = image39middle;
            middleInMiddle[10] = image40middle;
            middleInMiddle[11] = image41middle;
            middleInMiddle[12] = image42middle;
            middleInMiddle[13] = image43middle;
            middleInMiddle[14] = image44middle;
            middleInMiddle[15] = image45middle;
            middleInMiddle[16] = image46middle;
            middleInMiddle[17] = image47middle;
            middleInMiddle[18] = image48middle;
            middleInMiddle[19] = image49middle;
            middleInMiddle[20] = image50middle;
            middleInMiddle[21] = image51middle;
            middleInMiddle[22] = image52middle;
            middleInMiddle[23] = image53middle;
            middleInMiddle[24] = image54middle;
            middleInMiddle[25] = image55middle;
            middleInMiddle[26] = image56middle;
            middleInMiddle[27] = image57middle;
            middleInMiddle[28] = image58middle;
            middleInMiddle[29] = image59middle;
            middleInMiddle[30] = image60middle;
            middleInMiddle[31] = image61middle;
            middleInMiddle[32] = image62middle;
            middleInMiddle[33] = image63middle;
            middleInMiddle[34] = image64middle;
            middleInMiddle[35] = image65middle;
            middleInMiddle[36] = image66middle;
            middleInMiddle[37] = image67middle;
            middleInMiddle[38] = image68middle;
            middleInMiddle[39] = image69middle;

            middleInLarge[0] = image70middle;
            middleInLarge[1] = image71middle;
            middleInLarge[2] = image72middle;
            middleInLarge[3] = image73middle;
            middleInLarge[4] = image74middle;
            middleInLarge[5] = image75middle;
            middleInLarge[6] = image76middle;
            middleInLarge[7] = image77middle;
            middleInLarge[8] = image78middle;
            middleInLarge[9] = image79middle;
            middleInLarge[10] = image80middle;
            middleInLarge[11] = image81middle;
            middleInLarge[12] = image82middle;
            middleInLarge[13] = image83middle;
            middleInLarge[14] = image84middle;
            middleInLarge[15] = image85middle;
            middleInLarge[16] = image86middle;
            middleInLarge[17] = image87middle;
            middleInLarge[18] = image88middle;
            middleInLarge[19] = image89middle;
            middleInLarge[20] = image90middle;
            middleInLarge[21] = image91middle;
            middleInLarge[22] = image92middle;
            middleInLarge[23] = image93middle;
            middleInLarge[24] = image94middle;
            middleInLarge[25] = image95middle;
            middleInLarge[26] = image96middle;
            middleInLarge[27] = image97middle;
            middleInLarge[28] = image98middle;
            middleInLarge[29] = image99middle;

            largeInLarge[0] = image70large;
            largeInLarge[1] = image71large;
            largeInLarge[2] = image72large;
            largeInLarge[3] = image73large;
            largeInLarge[4] = image74large;
            largeInLarge[5] = image75large;
            largeInLarge[6] = image76large;
            largeInLarge[7] = image77large;
            largeInLarge[8] = image78large;
            largeInLarge[9] = image79large;
            largeInLarge[10] = image80large;
            largeInLarge[11] = image81large;
            largeInLarge[12] = image82large;
            largeInLarge[13] = image83large;
            largeInLarge[14] = image84large;
            largeInLarge[15] = image85large;
            largeInLarge[16] = image86large;
            largeInLarge[17] = image87large;
            largeInLarge[18] = image88large;
            largeInLarge[19] = image89large;
            largeInLarge[20] = image90large;
            largeInLarge[21] = image91large;
            largeInLarge[22] = image92large;
            largeInLarge[23] = image93large;
            largeInLarge[24] = image94large;
            largeInLarge[25] = image95large;
            largeInLarge[26] = image96large;
            largeInLarge[27] = image97large;
            largeInLarge[28] = image98large;
            largeInLarge[29] = image99large;

            show(glbV.smallslot, glbV.middleslot, glbV.largeslot);
        }

        // 3 array need to pass to this function
        // small array represent the small slot 
        // middle array represent the middle slot 
        // large array represent the large slot
        // 0 represent small car in it , 1 represent middle car in it , 2 represent large car in it
        public void show(int []small ,int [] middle,int []large)
        {
           for(int i =0; i < small.Length; i++)
            {
                if (small[i] == 0)
                {
                    smallInSmall[i].Visibility = Visibility.Visible;
                }
                if (middle[i] == 0)
                {
                    smallInMiddle[i].Visibility = Visibility.Visible;
                }
                if (middle[i] == 1)
                {
                    middleInMiddle[i].Visibility = Visibility.Visible;
                }
                if (large[i] == 0)
                {
                    smallInLarge[i].Visibility = Visibility.Visible;
                }
                if (large[i] == 1)
                {
                    middleInLarge[i].Visibility = Visibility.Visible;
                }
                if (large[i] == 2)
                {
                    largeInLarge[i].Visibility = Visibility.Visible;
                }
            }



        }
    }
}
