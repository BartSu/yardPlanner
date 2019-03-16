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
using Planner;

namespace yardPlaner
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
            
                FileNameTextBox.Text = openFileDlg.FileName;
                //TextBlock1.Text = System.IO.File.ReadAllText(openFileDlg.FileName);
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
                        TextBlock1.Text +="Position: " + i + " - car id: " + car.getId() + ", size: " + sizeName[car.getSize()];
                    else
                        TextBlock1.Text += "Position " + i + " is empty";
                }

                foreach (Car car in noneSlotCars)
                {
                    TextBlock1.Text += "No slot avaliable for car id: " + car.getId();
                }
               
            }

        }
}
}
