using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using OOP_4Lab;

namespace OOP4_Lab
{
    class DeviceController
    {
        private List<Device> devices = new List<Device>();

        // Метод для чтения из текстового файла и инициализации коллекции
        public void ReadFromTextFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Разделители между данными можно задать в зависимости от формата файла
                        string[] data = line.Split(';');

                        // Проверяем, что у нас есть достаточно данных для создания объекта
                        if (data.Length >= 9)
                        {
                            Device device = new Device(
                                data[0],        // Model
                                int.Parse(data[1]),     // Year
                                data[2],        // Name
                                int.Parse(data[3]),     // Price
                                data[4]        // Description
                            );

                            devices.Add(device);
                        }
                    }
                }

                Console.WriteLine("Data loaded from text file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from text file: {ex.Message}");
            }
        }

        // Метод для чтения из JSON файла и инициализации коллекции
        public void ReadFromJsonFile(string filePath)
        {
            try
            {
                string jsonText = File.ReadAllText(filePath);
                devices = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Device>>(jsonText);
                Console.WriteLine("Data loaded from JSON file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from JSON file: {ex.Message}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                //// Создаем объекты разных классов
                //Device device1 = new Device("Model1", 2001, "Device1", 500, "Description1");
                //Device device2 = new Device("Model2", 2002, "Device2", 600, "Description2");

                //PersonalComputer pc1 = new PersonalComputer("Nvidia", "Desktop", 2, "Intel", 8, 512, "PC1", 2001, "Device1", 500, "Description1");
                //PersonalComputer pc2 = new PersonalComputer("AMD", "Laptop", 1, "AMD", 16, 256, "PC2", 2002, "Device2", 600, "Description2");

                ////Notebook notebook1 = new Notebook("Webcam", "15-inch", "Intel", 16, 512, "Notebook1", 2022, "Notebook Description1");
                ////Notebook notebook2 = new Notebook("No webcam", "13-inch", "AMD", 8, 256, "Notebook2", 2021, "Notebook Description2");

                ////Tablet tablet1 = new Tablet("10-inch", "Android", "Tablet1", 300, "Tablet Description1");
                ////Tablet tablet2 = new Tablet("12-inch", "iOS", "Tablet2", 400, "Tablet Description2");

                ////Printer printer1 = new Printer("Inkjet", "1200x1200 dpi", "USB", "Printer1", 2022, "Printer Description1");
                ////Printer printer2 = new Printer("Laser", "600x600 dpi", "Wi-Fi", "Printer2", 2021, "Printer Description2");

                ////Scanner scanner1 = new Scanner("Flatbed", "USB", "Scanner1", 2022, "Scanner Description1");
                ////Scanner scanner2 = new Scanner("Sheet-fed", "Ethernet", "Scanner2", 2021, "Scanner Description2");

                //// Создаем лабораторию и добавляем объекты
                //Laboratory lab = new Laboratory();
                //lab.AddDevice(device1);
                //lab.AddDevice(device2);
                //lab.AddDevice(pc1);
                //lab.AddDevice(pc2);
                ////lab.AddDevice(notebook1);
                ////lab.AddDevice(notebook2);
                ////lab.AddDevice(tablet1);
                ////lab.AddDevice(tablet2);
                ////lab.AddDevice(printer1);
                ////lab.AddDevice(printer2);
                ////lab.AddDevice(scanner1);
                ////lab.AddDevice(scanner2);

                //// Выводим информацию о всех объектах
                //Console.WriteLine("All Devices:");
                //lab.DisplayDevices();

                //Console.WriteLine("\nDevices Older Than 2002:");
                //List<Device> olderDevices = lab.FindDevicesOlderThan(2002);
                //foreach (Device device in olderDevices)
                //{
                //    device.DisplayInfo();
                //    Console.WriteLine();
                //}

                //Console.WriteLine("\nDevice Counts by Type:");
                //Dictionary<string, int> counts = lab.CountDevicesByType();
                //foreach (var pair in counts)
                //{
                //    Console.WriteLine($"{pair.Key}: {pair.Value}");
                //}

                //Console.WriteLine("\nDevices Descending Price:");
                //lab.DisplayDevicesDescendingPrice();

                //DeviceController controller = new DeviceController();

                //// Чтение данных из текстового файла
                //controller.ReadFromTextFile("devices.txt");

                //// Чтение данных из JSON файла
                //controller.ReadFromJsonFile("devices.json");
            }

            try
            {
                // Генерируем пользовательские исключения
                throw new CustomException1("Custom Exception 1 occurred.");
            }
            catch (CustomException1 ex)
            {
                Console.WriteLine($"Caught CustomException1: {ex.Message}");
            }

            try
            {
                // Генерируем пользовательские исключения
                throw new CustomException2("Custom Exception 2 occurred.");
            }
            catch (CustomException2 ex)
            {
                Console.WriteLine($"Caught CustomException2: {ex.Message}");
            }

            Calculator calculator = new Calculator();

            try
            {
                int result = calculator.Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (CustomException3 ex)
            {
                Console.WriteLine($"Caught CustomArgumentException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught Exception: {ex.Message}");
            }

            try
            {
                // 1. Деление на ноль
                int x = 10;
                int y = 0;
                int result = x / y; // Генерируется System.DividedByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка деления на ноль: " + ex.Message);
            }

            try
            {
                // 2. Работа с нулевым указателем
                string str = null;
                int length = str.Length; // Генерируется System.NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Ошибка работы с нулевым указателем: " + ex.Message);
            }

            try
            {
                // 4. Доступ к элементу массива по неверному индексу
                int[] array = { 1, 2, 3 };
                int value = array[3]; // Генерируется System.IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка доступа к элементу массива по неверному индексу: " + ex.Message);
            }

            try
            {
                // 5. Исключение, сгенерированное пользовательским кодом
                throw new CustomException1("Пользовательская ошибка");
            }
            catch (CustomException1 ex)
            {
                Console.WriteLine("Пользовательская ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Общий обработчик исключений: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Этот блок будет выполнен независимо от исключений.");
            }

            try
            {
                Console.WriteLine("Начало выполнения программы.");
                DivideByZero();
                Console.WriteLine("Завершение выполнения программы.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Обработка исключения в методе Main: " + ex.Message);
            }

            try
            {
                Console.WriteLine("Начало выполнения программы.");
                DivideByZeroCustomka();
                Console.WriteLine("Завершение выполнения программы.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Обработка DivideByZeroException:");
                Console.WriteLine($"Исключение: {ex.GetType().Name}");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine($"Место: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Обработка исключения:");
                Console.WriteLine($"Исключение: {ex.GetType().Name}");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine($"Место: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен.");
            }

            int AssertValue = 10;

            Debug.Assert(AssertValue > 5, "Значение 'value' должно быть больше 5.");

            Console.WriteLine("Программа продолжает выполнение.");

            // Выберите, какой логгер использовать (FileLogger или ConsoleLogger)
            // и передайте его в конструктор класса Logger
            ILogger logger = new ConsoleLogger(); // Здесь можно заменить на FileLogger, чтобы записывать в файл
            Loger applicationLogger = new Loger(logger);

            try
            {
                // Некоторые операции, которые могут вызвать исключение
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (Exception ex)
            {
                // Логгирование ошибки
                applicationLogger.LogError(ex.Message);
            }

            // Логгирование предупреждения и информации
            applicationLogger.LogWarning("This is a warning message.");
            applicationLogger.LogInfo("This is an information message.");
        }

        static void DivideByZero()
        {
            try
            {
                Console.WriteLine("Начало метода DivideByZero.");
                int x = 10;
                int y = 0;
                int result = x / y; // Генерируется исключение DividedByZeroException
                Console.WriteLine("Завершение метода DivideByZero.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Обработка исключения в методе DivideByZero: " + ex.Message);
                throw; // Пробрасываем исключение выше по стеку вызовов
            }
        }

        static void DivideByZeroCustomka()
        {
            try
            {
                Console.WriteLine("Начало метода DivideByZero.");
                int x = 10;
                int y = 0;
                int result = x / y; // Генерируется исключение DivideByZeroException
                Console.WriteLine("Завершение метода DivideByZero.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Обработка DivideByZeroException в методе DivideByZero:");
                Console.WriteLine($"Исключение: {ex.GetType().Name}");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine($"Место: {ex.StackTrace}");
                throw; // Пробрасываем исключение выше по стеку вызовов
            }
        }
    }
}

