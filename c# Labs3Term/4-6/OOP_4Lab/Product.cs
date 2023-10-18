using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml.Linq;

namespace OOP4_Lab
{
    public interface IPrice
    {
        int SetPrice();
        bool DoClone();
    }

    internal class Product : IPrice
    {
        private string ProductName;
        private int ProductPrice;
        private string ProductDescription;

        public Product()
        {
            ProductName = "Name";
            ProductPrice = 0;
            ProductDescription = "Description";
        }

        public Product(string Name, int Price, string Description)
        {
            ProductName = Name;
            ProductPrice = Price;
            ProductDescription = Description;
        }

        int IPrice.SetPrice()
        {
            ProductPrice = Convert.ToInt32(Console.ReadLine());
            return ProductPrice;
        }

        bool IPrice.DoClone()
        {
            return true;
        }

        public string getProductName()
        {
            return ProductName;
        }

        public int getProductPrice()
        {
            return ProductPrice;
        }

        public string getProductDescription()
        {
            return ProductDescription;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("ProductPrice" + ProductPrice);
            Console.WriteLine("ProductDescription" + ProductDescription);
        }
    }

    class Device : Product
    {
        private string ModelDevice;
        private int YearDevice;

        public Device()
        {
            ModelDevice = "Model";
            YearDevice = 2000;
        }

        public Device(string Model, int Year, string Name, int Price, string Description) : base(Name, Price, Description)
        {
            ModelDevice = Model;
            YearDevice = Year;
        }

        public string getDevise()
        {
            return ModelDevice;
        }

        public int getYearDevice()
        {
            return YearDevice;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("ModelDevice: " + ModelDevice);
            Console.WriteLine("YearDevice: " + YearDevice);

        }

    }

    abstract class Computer : Device
    {
        private string CPUType;
        private int RAM;
        private int ROM;

        public abstract string Size();
        public abstract bool DoClone();

        public Computer()
        {
            CPUType = "Type";
            RAM = 2;
            ROM = 200;
        }

        public Computer(string CPUType, int RAM, int ROM, string Model, int Year, string Name, int Price, string Description) : base(Name, Price, Description, Year, Model)
        {
            this.CPUType = CPUType;
            this.RAM = RAM;
            this.ROM = ROM;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("CPUType: " + CPUType);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("ROM: " + ROM);
        }
    }

    class PersonalComputer : Computer
    {
        private string GPUType;
        private string ComputerType;
        private int Monitors;

        public override string Size()
        {
            string str = "Большой и тяжелый";
            return str;
        }

        public override bool DoClone()
        {
            if (GPUType != "amd")
                return true;
            else
                return false;
        }

        public PersonalComputer() : base()
        {
            GPUType = "Type";
            ComputerType = "Type";
            Monitors = 0;
        }

        public PersonalComputer(string GPUType, string ComputerType, int Monitors, string CPUType, int RAM, int ROM, string Model, int Year, string Name, int Price, string Description) : base(CPUType, RAM, ROM, Name, Price, Description, Year, Model)
        {
            this.GPUType = GPUType;
            this.ComputerType = ComputerType;
            this.Monitors = Monitors;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("GPUType: " + GPUType);
            Console.WriteLine("ComputerType: " + ComputerType);
            Console.WriteLine("Monitors: " + Monitors);
        }
    }

    class Notebook : Computer
    {
        private string CamType;
        private string ScreenSize;

        public Notebook()
        {
            CamType = "Type";
            ScreenSize = "Size";
        }

        public Notebook(string camType, string screen, string CPUType, int RAM, int ROM, string Model, int Year, string Name, int Price, string Description) : base(CPUType, RAM, ROM, Name, Price, Description, Year, Model)
        {
            CamType = camType;
            ScreenSize = screen;
        }

        public override string Size()
        {
            string str = "Маленький и легкий";
            return str;
        }

        public override bool DoClone()
        {
            if (CamType == "saf")
                return false;
            else
                return true;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("CamType: " + CamType);
            Console.WriteLine("ScreenSize: " + ScreenSize);
        }
    }

    class Tablet : Device
    {
        private string ScreenSize;
        private string OS;

        public Tablet()
        {
            ScreenSize = "1024x720";
            OS = "osb";
        }

        public Tablet(string screenSize, string os, string Model, int Year, string Name, int Price, string Description) : base(Name, Price, Description, Year, Model)
        {
            ScreenSize = screenSize;
            OS = os;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("ScreenSize: " + ScreenSize);
            Console.WriteLine("OS: " + OS);

        }
    }

    class PeripheralDevice : Device
    {
        private string InterfaceType;
        private string MaxResolution;

        public PeripheralDevice()
        {
            InterfaceType = "Type";
            MaxResolution = "Resolution";
        }

        public PeripheralDevice(string interfaceType, string Model, int Year, string Name, int Price, string Description) : base(Name, Price, Description, Year, Model)
        {
            InterfaceType = interfaceType;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("InterfaceType: " + InterfaceType);
        }
    }

    class Printer : PeripheralDevice
    {
        private string PrintType;
        private string MinResolution;

        public Printer()
        {
            PrintType = "Type";
            MinResolution = "Resolution";
        }

        public Printer(string printType, string minResolution, string interfaceType, string Model, int Year, string Name, int Price, string Description) : base(interfaceType, Name, Price, Description, Year, Model)
        {
            PrintType = printType;
            MinResolution = minResolution;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("PrintType: " + PrintType);
            Console.WriteLine("MinResolution: " + MinResolution);

        }
    }

    sealed class Scanner : PeripheralDevice
    {
        private string ScanType;

        public Scanner()
        {
            ScanType = "Type";
        }

        public Scanner(string scanType, string interfaceType, string Model, int Year, string Name, int Price, string Description) : base(interfaceType, Name, Price, Description, Year, Model)
        {
            ScanType = scanType;
        }
    }

    class Laboratory
    {
        private List<Device> devices = new List<Device>();

        public void AddDevice(Device device)
        {
            devices.Add(device);
        }

        public void RemoveDevice(Device device)
        {
            devices.Remove(device);
        }

        public void DisplayDevices()
        {
            foreach (Device device in devices)
            {
                Console.WriteLine($"Name: {device.getProductName()}");
                Console.WriteLine($"Price: {device.getProductPrice()}");
                Console.WriteLine($"Description: {device.getProductDescription()}");
                Console.WriteLine($"Model: {device.getDevise()}");
                Console.WriteLine($"Year: {device.getYearDevice()}");
                Console.WriteLine();
            }
        }

        public List<Device> FindDevicesOlderThan(int year)
        {
            return devices.Where(d => d.getYearDevice() < year).ToList();
        }

        public Dictionary<string, int> CountDevicesByType()
        {
            Dictionary<string, int> countByType = new Dictionary<string, int>();

            foreach (Device device in devices)
            {
                string deviceType = device.GetType().Name;

                if (countByType.ContainsKey(deviceType))
                {
                    countByType[deviceType]++;
                }
                else
                {
                    countByType[deviceType] = 1;
                }
            }

            return countByType;
        }

        public void DisplayDevicesDescendingPrice()
        {
            var sortedDevices = devices.OrderByDescending(d => d.getProductPrice());

            foreach (Device device in sortedDevices)
            {
                Console.WriteLine($"Name: {device.getProductName()}");
                Console.WriteLine($"Price: {device.getProductPrice()}");
                Console.WriteLine($"Description: {device.getProductDescription()}");
                Console.WriteLine($"Model: {device.getDevise()}");
                Console.WriteLine($"Year: {device.getYearDevice()}");
                Console.WriteLine();
            }
        }
    }
}