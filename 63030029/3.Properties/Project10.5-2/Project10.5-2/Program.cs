using System;
namespace Project_10._5_2
{
    class Lamp
    {
        private int voltage = 12;
        private string color = "White";
        public int Voltage
        {
            get { return voltage; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
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

                
                

                Console.WriteLine($"Traffic light #1 : color = {TrafficGreenLight.Color}, Voltage = {TrafficGreenLight.Voltage} V.");
                Console.WriteLine($"Traffic light #2 : color = {TrafficAmberLight.Color}, Voltage = {TrafficAmberLight.Voltage} V.");
                Console.WriteLine($"Traffic light #3 : color = {TrafficRedLight.Color}, Voltage = {TrafficRedLight.Voltage} V.");
            }
        }
    }
   
}
       