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
        public static int[] smallslot = new int[15];
        public static int[] middleslot = new int[20];
        public static int[] largeslot = new int[10];
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
            openFileDlg.DefaultExt = ".csv";
            openFileDlg.Filter = "Comma-Separated Values (.csv)|*.csv";

            // Set initial directory    
            openFileDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> file;
            try
            {
                file = openFileDlg.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }

            if (file == true)
            {
                TextBlock1.Text = "";
                try
                {
                    List<List<Car>> result = Planner.Planner.computeSlots(openFileDlg.FileName);

                    List<Car> parkingLot = result[0];
                    List<Car> noneSlotCars = result[1];

                    string[] sizeName = { "Large", "Medium", "Small" };

                    for (int i = 0; i < parkingLot.Capacity; i++)
                    {
                        Car car = parkingLot[i];

                        if (!car.checkEmptyState())
                            TextBlock1.Text += "Position: " + i + " - car id: " + car.getId() + ", size: " + sizeName[car.getSize()] + "\r\n";
                        else
                            TextBlock1.Text += "Position " + i + " is empty" + "\r\n";
                    }

                    for (int l = 0; l < glbV.largeslot.Length; l++)
                    {
                        if (!parkingLot[l].checkEmptyState())
                            glbV.largeslot[l] = 2 - parkingLot[l].getSize();
                        else
                            glbV.largeslot[l] = -1;
                    }
                    for (int m = 0; m < glbV.middleslot.Length; m++)
                    {
                        if (!parkingLot[glbV.largeslot.Length + m].checkEmptyState())
                            glbV.middleslot[m] = 2 - parkingLot[glbV.largeslot.Length + m].getSize();
                        else
                            glbV.middleslot[m] = -1;
                    }
                    for (int s = 0; s < glbV.smallslot.Length; s++)
                    {
                        if (!parkingLot[glbV.largeslot.Length + glbV.middleslot.Length + s].checkEmptyState())
                            glbV.smallslot[s] = 2 - parkingLot[glbV.largeslot.Length + glbV.middleslot.Length + s].getSize();
                        else
                            glbV.smallslot[s] = -1;
                    }

                    Parking win = new Parking();
                    win.Show();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Classifier classifier = new Classifier();
            classifier.Show();
        }
    }
}
