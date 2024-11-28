using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            trafficLightCode();
        }

        public static void trafficLightCode()
        {
            string light = "red";

            if (light == "red")
            {
                Console.WriteLine("Stop at the robot");
            }
            else if (light == "amber")
            {
                Console.WriteLine("Approach robot with caution");
            }
            else if (light == "green")
            {
                Console.WriteLine("Pass the robot");
            }
        }
    }
}
