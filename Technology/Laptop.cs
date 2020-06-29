using System;

namespace Technology
{
    public class Laptop : Computer
    {
        public double TouchPadSize { get; set; }
        public bool UsbLoaded { get; set; } = false;

        public Laptop(double touchPadSize, string brandName, string model, int manufacturedYear) : base(NextObjectId, brandName, model, manufacturedYear)
        {
            TouchPadSize = touchPadSize;
            GenerateId();
        }



        public void InsertUsb()
        {
                UsbLoaded = true;        
        }

        public void EjectUsb()
        {
            UsbLoaded = false;
        }
    }
}
