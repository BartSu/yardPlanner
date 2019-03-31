using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using Alturos.Yolo;
using Alturos.Yolo.Model;
using Planner;

namespace yardPlaner
{
    /// <summary>
    /// Classifier.xaml 的交互逻辑
    /// </summary>

    class SizeInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public partial class Classifier : Window
    {
        private YoloWrapper wrapper;

        public Classifier()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //initialize components
            List<SizeInfo> sizeList = new List<SizeInfo>();
            sizeList.Add(new SizeInfo { Name = "Large", Value = "L" });
            sizeList.Add(new SizeInfo { Name = "Medium", Value = "M" });
            sizeList.Add(new SizeInfo { Name = "Small", Value = "S" });

            carSizeList.ItemsSource = sizeList;
            carSizeList.DisplayMemberPath = "Name";
            carSizeList.SelectedValuePath = "Value";
            carSizeList.SelectedIndex = 0;

            //initialize classifier
            try
            {
                var configurationDetector = new ConfigurationDetector();
                var config = configurationDetector.Detect();
                wrapper = new YoloWrapper(config);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
        }

        //Select image button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            openFileDlg.DefaultExt = ".jpg";
            openFileDlg.Filter = "JPEG image (.jpg)|*.jpg";
            openFileDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            bool? file;
            try
            {
                file = openFileDlg.ShowDialog();
                if (file == true)
                {
                    carPreview.Source = new BitmapImage(new Uri(openFileDlg.FileName));
                    analyzeImg(openFileDlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        //Add button
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string line = carID.Text + "," + carSizeList.SelectedValue;
            addedCarList.Text += line + "\r\n";
            confirmButton.IsEnabled = true;
        }

        //Confirm button
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            string tempFile = Path.GetTempFileName();
            string ls_fileNeme = Path.ChangeExtension(tempFile, ".csv");
            File.Move(tempFile, ls_fileNeme);
            using (FileStream fs = new FileStream(ls_fileNeme, FileMode.Open))
            {
                StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
                sw.WriteLine(addedCarList.Text);
                sw.Flush();
                sw.Close();
            }

            try
            {
                List<List<Car>> result = Planner.Planner.computeSlots(ls_fileNeme);

                List<Car> parkingLot = result[0];
                List<Car> noneSlotCars = result[1];

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

        private void analyzeImg(string path)
        {
            List<YoloItem> items = wrapper.Detect(path).ToList();

            if (items.Capacity > 3)
            {
                throw new Exception("Too many items found in the image.");
            }
            if (items.Capacity == 0)
            {
                throw new Exception("No items found in the image.");
            }

            string type = items[0].Type;

            if (type.Equals("bus") || type.Equals("train"))
            {
                label2.Content = "bus/truck";
                carSizeList.SelectedIndex = 0;
            }
            else if (type.Equals("bicycle") || type.Equals("motorbike"))
            {
                label2.Content = type;
                carSizeList.SelectedIndex = 2;
            }
            else if (type.Equals("car"))
            {
                label2.Content = type;
                carSizeList.SelectedIndex = 1;
            }
            else
            {
                throw new Exception("No vehicles found in the image.");
            }

            //Randomly assign an ID
            Random random = new Random();
            carID.Text = random.Next(1, 10000).ToString();
            addButton.IsEnabled = true;
        }       
    }
}