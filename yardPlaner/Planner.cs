using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace Planner
{
    /*
     *   ==============Namespace Description===========
     *   0.Input file should be a .csv file with content 'id,size' on each line
     *       For example:
     *           123456,L
     *           122333,M
     *           abcdef,S
     *       where L = Large car, M = Medium car, S = Small car
     *       Exceptions will be thrown if the format is not correct
     *   
     *   **To generate a parking plan:
     *   1.Provide a directory to function computeSlot(..)
     *   2.The returned list including two sublists:
     *       result[0] is the parking plan
     *       result[1] is the list of cars without a position
     *   3.For each car in the parking plan:
     *       a.The index is the position of the car where:
     *           0-29 for large cars
     *           30-69 for medium cars
     *           70-99 for small cars
     *       b.Use car.checkEmptyState() at first to check whether the position is empty
     *       c.If the position is not empty:
     *           -Use car.getId() to get the id, the id is a string
     *           -Use car.getSize() to get the size, 0 is large, 1 is med, 2 is small
     *           
     */

    //=================Test Class==================
    //class Planner_Test
    //{
    //    static void Main(string[] args)
    //    {
    //        List<List<Car>> result = Planner.computeSlots("C:/Users/Meng/Desktop/yard/test.csv");
    //        List<Car> parkingLot = result[0];
    //        List<Car> noneSlotCars = result[1];

    //        string[] sizeName = { "Large", "Medium", "Small" };
    //        for (int i = 0; i < parkingLot.Capacity; i++)
    //        {
    //            Car car = parkingLot[i];
    //            if (!car.checkEmptyState())
    //                Console.WriteLine("Position: " + i + " - car id: " + car.getId() + ", size: " + sizeName[car.getSize()]);
    //            else
    //                Console.WriteLine("Position " + i + " is empty");
    //        }

    //        foreach(Car car in noneSlotCars)
    //        {
    //            Console.WriteLine("No slot avaliable for car id: " + car.getId());
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //==============Planner Program Start=================
    //Set the initial capacity for each size here.
    enum ParkingLotCapacity
    {
        LargeCar = 30,
        MediumCar = 40,
        SmallCar = 30
    }

    //Size identifier.
    enum CarSize
    {
        Large = 0x00,
        Medium = 0x01,
        Small = 0x02
    }

    class Car
    {
        private string id; //Car ID
        private int size; //Car size
        private bool isEmpty; //Empty indicates the car does not exist

        public Car() : this("", 0, true) { }
        public Car(string cid, int csize) : this(cid, csize, false) { }
        public Car(string cid, int csize, bool state)
        {
            id = cid;
            size = csize;
            isEmpty = state;
        }

        public string getId()
        {
            return id;
        }
        public int getSize()
        {
            return size;
        }
        public bool checkEmptyState()
        {
            return isEmpty;
        }
    }

    class Planner
    {
        public static List<List<Car>> computeSlots(string csvPath)
        {
            StreamReader file = new StreamReader(csvPath);

            //Create a parking lot.
            int totalSlots = (int)ParkingLotCapacity.LargeCar
                            + (int)ParkingLotCapacity.MediumCar
                            + (int)ParkingLotCapacity.SmallCar;
            List<Car> parkingLot = new List<Car>(totalSlots);
            //Fill in with empty items.
            for (int i = 0; i < parkingLot.Capacity; i++)
            {
                Car car = new Car();
                parkingLot.Add(car);
            }

            //For cars that cannot be assigned a seat.
            List<Car> noneSlotCars = new List<Car>();

            //Set the capacity for each size of car.
            int[] capacity = new int[3];
            capacity[(int)CarSize.Large] = (int)ParkingLotCapacity.LargeCar;
            capacity[(int)CarSize.Medium] = (int)ParkingLotCapacity.MediumCar;
            capacity[(int)CarSize.Small] = (int)ParkingLotCapacity.SmallCar;
            try
            {
                if (new FileInfo(csvPath).Length <= 1)
                {
                    throw new Exception("The file does not have any content!");
                }
                else
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        Car car;
                        string[] split_line = line.Split(',');

                        //Identify the input, the car size in the csv should be L/M/S.               
                        if (split_line[1].Equals("L")) //for large cars.
                        {
                            car = new Car(split_line[0], (int)CarSize.Large);

                            //Assign a parking slot. Large car can only park in L slots.
                            if (capacity[(int)CarSize.Large] > 0)
                            {
                                int position = (int)ParkingLotCapacity.LargeCar - capacity[(int)CarSize.Large];
                                parkingLot[position] = car;
                                capacity[(int)CarSize.Large]--;
                            }
                            else
                            {
                                noneSlotCars.Add(car);
                            }
                        }
                        else if (split_line[1].Equals("M")) //for medium cars.
                        {
                            car = new Car(split_line[0], (int)CarSize.Medium);

                            //Assign a parking slot. Med car can park in L and M slots.
                            if (capacity[(int)CarSize.Medium] > 0)
                            {
                                int position = (int)ParkingLotCapacity.MediumCar - capacity[(int)CarSize.Medium]
                                                + (int)ParkingLotCapacity.LargeCar;
                                parkingLot[position] = car;
                                capacity[(int)CarSize.Medium]--;
                            }
                            else if (capacity[(int)CarSize.Large] > 0)
                            {
                                int position = (int)ParkingLotCapacity.LargeCar - capacity[(int)CarSize.Large];
                                parkingLot[position] = car;
                                capacity[(int)CarSize.Large]--;
                            }
                            else
                            {
                                noneSlotCars.Add(car);
                            }
                        }
                        else if (split_line[1].Equals("S")) //for small cars.
                        {
                            car = new Car(split_line[0], (int)CarSize.Small);

                            //Assign a parking slot. Small car can park in all slots.
                            if (capacity[(int)CarSize.Small] > 0)
                            {
                                int position = (int)ParkingLotCapacity.SmallCar - capacity[(int)CarSize.Small]
                                                 + (int)ParkingLotCapacity.MediumCar
                                                 + (int)ParkingLotCapacity.LargeCar;
                                parkingLot[position] = car;
                                capacity[(int)CarSize.Small]--;
                            }
                            else if (capacity[(int)CarSize.Medium] > 0)
                            {
                                int position = (int)ParkingLotCapacity.MediumCar - capacity[(int)CarSize.Medium]
                                                + (int)ParkingLotCapacity.LargeCar;
                                parkingLot[position] = car;
                                capacity[(int)CarSize.Medium]--;
                            }
                            else if (capacity[(int)CarSize.Large] > 0)
                            {
                                int position = (int)ParkingLotCapacity.LargeCar - capacity[(int)CarSize.Large];
                                parkingLot[position] = car;
                                capacity[(int)CarSize.Large]--;
                            }
                            else
                            {
                                noneSlotCars.Add(car);
                            }
                        }
                        else
                        {
                            throw new Exception("There is something wrong with the input file, please check the format again!");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            List<List<Car>> ret = new List<List<Car>>();
            ret.Add(parkingLot);
            ret.Add(noneSlotCars);
            return ret;
        }
    }
}
