using System;
namespace Technology
{
    public class Computer : AbstractEntity
    {
        public static readonly string FirstComputer = "Apple 1";
        public static readonly int YearOfFirstComputer = 1976;
        public static int NextObjectId = 1;
        public int ObjectId { get; set; }
        public string BrandName { get; }
        public string Model { get; }
        public int ManufacturedYear { get; set; }
        public bool IsSoftwareUpToDate { get; set; } = false;
        public bool IsDeviceOn { get; set; } = false;

        public Computer(int objectId, string brandName, string model, int manufacturedYear)
        {
            BrandName = brandName;
            Model = model;
            ManufacturedYear = manufacturedYear;
            ObjectId = objectId;
        }

        public Computer(string brandName, string model, int manufacturedYear) : this(NextObjectId, brandName, model, manufacturedYear)
        {
            GenerateId();
        }

        public override void GenerateId()
        {
            NextObjectId++;
        }

        public void UpdateSoftware()
        {
            IsSoftwareUpToDate = true;
        }

        public void SwitchOn()
        {
            IsDeviceOn = true;
        }

        public void SwitchOff()
        {
            IsDeviceOn = false;
        }
    }
}
