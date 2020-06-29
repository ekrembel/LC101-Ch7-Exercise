using System;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string Carrier { get; set; }
        public bool OnCall { get; set; } = false;

        public SmartPhone(string carrier, string brandName, string model, int manufacturedYear) : base(NextObjectId, brandName, model, manufacturedYear)
        {
            Carrier = carrier;
            GenerateId();
        }

        public void Call()
        {
            OnCall = true;
        }

        public void HangUp()
        {
            OnCall = false;
        }
    }
}
