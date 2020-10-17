using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polymorphic_model_binding.Models
{
    public abstract class Device
    {
        public string Kind { get; set; }
    }

    public class Laptop : Device
    {
        public string CPUIndex { get; set; }
    }

    public class SmartPhone : Device
    {
        public string ScreenSize { get; set; }
    }

}
