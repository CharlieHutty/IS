using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenege_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //This is for the two cameras
            //Using the DateTime variable type so that the user can input the specific times
            DateTime camera1;
            DateTime camera2;
            //This uses the TimeSpan variable type so that it can work out the difference between both times
            TimeSpan time;
            double hours;
            double speed;
            int distance = 1;

            //Allow the user to input the time the car went past the first camera
            Console.WriteLine("Please enter the time in the format HH:MM:SS");
            Console.Write("What was the time of the first camera: ");
            camera1 = Convert.ToDateTime(Console.ReadLine());

            //Allows the user to input the time the car went past the second camera
            Console.WriteLine("Please enter the time in the format HH:MM:SS");
            Console.Write("What was the time of the second camera: ");
            camera2 = Convert.ToDateTime(Console.ReadLine());

            //Works out the distance between the times
            //Converts this to hours
            time = camera2 - camera1;
            hours = time.TotalHours;

            //Uses the speed equation to work out the speed
            speed = (distance / hours);

            //Outputs the speed to the user
            Console.WriteLine(speed + "mph");

            Console.ReadKey();
        }
    }
}
