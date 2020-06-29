using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop myLaptop = new Laptop(16, "Apple", "Macbool Pro", 2019);

            myLaptop.SwitchOn();
            Console.WriteLine(myLaptop.IsDeviceOn);
            myLaptop.SwitchOff();
            Console.WriteLine(myLaptop.IsDeviceOn);

            Console.WriteLine(Computer.FirstComputer);
            Console.WriteLine(Computer.YearOfFirstComputer);

            SmartPhone mySmartPhone = new SmartPhone("Sprint", "iPhone", "iPhone 8", 2016);

            Console.WriteLine(mySmartPhone.OnCall);
            mySmartPhone.Call();
            Console.WriteLine(mySmartPhone.OnCall);
            mySmartPhone.HangUp();
            Console.WriteLine(mySmartPhone.OnCall);
            Console.WriteLine(mySmartPhone.Carrier);

            Computer newComputer = new Computer("x", "x.10", 2020);
            Console.WriteLine(newComputer.ObjectId);
            Computer computer = new Computer("y", "yyy", 2020);
            Console.WriteLine(computer.ObjectId);

            Laptop laptop = new Laptop(5, "lap", "lap.10", 2020);
            Console.WriteLine(laptop.ObjectId);

            SmartPhone smartPhone = new SmartPhone("AT&T", "phone", "smart", 2020);
            Console.WriteLine(smartPhone.ObjectId);
        }
    }
}
