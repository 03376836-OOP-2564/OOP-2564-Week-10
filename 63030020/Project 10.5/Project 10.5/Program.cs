using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10._5
{
    class Lamp
    {
        private int voltage = 12;
        private string color = "White";
        public int Voltage
        {
            get { return voltage; }
            set { color = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            Lamp TrafficAmberLight = new Lamp();
            Lamp TrafficRedLight = new Lamp();
            Lamp TrafficGreenLight = new Lamp();

            // กำหนดชื่อสีให้หลอดไฟจราจร
            TrafficGreenLight.Color = "Green";
            TrafficAmberLight.Color = "Amber";
            TrafficRedLight.Color = "Red";

            // กำหนดแรงดันให้หลอดไฟจราจร
            TrafficGreenLight.Voltage = 220;
            TrafficAmberLight.Voltage = 220;
            TrafficRedLight.Voltage = 220;

            Console.WriteLine($"Traffic light #1 : color = {TrafficGreenLight.Color}, Voltage = {TrafficGreenLight.Voltage} V.");
            Console.WriteLine($"Traffic light #2 : color = {TrafficAmberLight.Color}, Voltage = {TrafficAmberLight.Voltage} V.");
            Console.WriteLine($"Traffic light #3 : color = {TrafficRedLight.Color}, Voltage = {TrafficRedLight.Voltage} V.");
        }
    }
}
