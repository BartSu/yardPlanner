using Planner;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace yardPlaner
{
    /// <summary>
    /// Main.xaml 的交互逻辑
    /// </summary>
    /// 

        static class glbV
    {
        public static int[] smallslot = new int[30];
        public static int[] middleslot = new int[40];
        public static int[] largeslot = new int[30];
    }
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            // Set filter for file extension and default file extension  
            openFileDlg.DefaultExt = ".txt";
            openFileDlg.Filter = "Text documents (.csv)|*.csv";

            // Set initial directory    
            openFileDlg.InitialDirectory = @"C:\Users\Meng\Desktop\yard";

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> file = openFileDlg.ShowDialog();

            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock

            //FileNameTextBox.Text = openFileDlg.FileName;
            TextBox.Text = System.IO.File.ReadAllText(openFileDlg.FileName);
            if (file == true)
            {
                List<List<Car>> result = Planner.Planner.computeSlots(openFileDlg.FileName);
                List<Car> parkingLot = result[0];
                List<Car> noneSlotCars = result[1];

                string[] sizeName = { "Large", "Medium", "Small" };
                
                
                for (int i = 0; i < parkingLot.Capacity; i++)
                {
                    Car car = parkingLot[i];
                    
                    if (!car.checkEmptyState())
                        TextBlock1.Text +="Position: " + i + " - car id: " + car.getId() + ", size: " + car.getSize();
                    else
                        TextBlock1.Text += "Position " + i + " is empty";
                }

                for (int l = 0; l < glbV.largeslot.Length; l++)
                {
                    glbV.largeslot[l] = 2 - parkingLot[l].getSize();
                }
                for (int m = 0; m < glbV.middleslot.Length; m++)
                {
                    glbV.middleslot[m] = 2 - parkingLot[glbV.largeslot.Length + m].getSize();
                }
                for (int s = 0; s < glbV.smallslot.Length; s++)
                {
                    glbV.smallslot[s] = 2 - parkingLot[glbV.largeslot.Length + glbV.middleslot.Length + s].getSize();
                }

                foreach (Car car in noneSlotCars)
                {
                    TextBlock1.Text += "No slot avaliable for car id: " + car.getId();
                }

            }
            Parking win = new Parking();
            win.Show();
        }
    }
}
