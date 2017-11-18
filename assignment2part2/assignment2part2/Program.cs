/*created by Archana Lohani 
 * to understand the use of overload method
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ArchanaLohaniP2
{
    class Program
    {
        static double Volume(double Pi,double radius)
        {
            return  (4 / 3 * Pi * radius);
        }
        static double Volume(double Pi, double radius, double height)
        {
            return (Pi * radius * height);
        }

        static double Volume(float length, double width, double height)
        {
            return (length * width * height);
        }

        static void Main(string[] args)
        {
            int option;
            int sphere;
            int cylinder;
            int rectangularPrism;
            double radius;
            double height;
            float length;
            double width;
            const double Pi = 3.14159;
            double volumeOfSphere;
            double volumeOfCylinder;
            double volumeOfRectangularPrism;

            option = 0;
            sphere = 1;
            cylinder = 2;
            rectangularPrism = 3;
            radius = 0;
            height = 0;
            length = 0;
            width = 0;

            Console.WriteLine("Welcome to the program which can calculate the volume of sphere, cylinder or rectangular prism for you." + "\n");
            Console.WriteLine("What type of shape you want to make ? Choose from the following option:");
            Console.WriteLine("1 for sphere");
            Console.WriteLine("2 for cylinder");
            Console.WriteLine("3 for rectangularPrism" + "\n");

            Console.Write("Plese enter the option from 1 to 3 : ");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("please enter radius: ", +radius);
                radius = double.Parse(Console.ReadLine());
                volumeOfSphere = Volume(Pi,radius);
                Console.WriteLine("Volume of Sphere is : " + volumeOfSphere);
            }
            else if (option == 2)
            {
                Console.WriteLine("please enter radius: ", +radius);
                radius = double.Parse(Console.ReadLine());
                Console.WriteLine("please enter height: ", + height);
                height = double.Parse(Console.ReadLine());
                volumeOfCylinder = Volume(Pi,radius, height);
                Console.WriteLine("Volume of Cylinder is : " + volumeOfCylinder);
            }

            else if (option == 3)
            {
                Console.WriteLine("please enter length: ", +length);
                length = float.Parse(Console.ReadLine());
                Console.WriteLine("please enter height: ", +height);
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("please enter width: ", + width);
                width = double.Parse(Console.ReadLine());
                volumeOfRectangularPrism = Volume(length, width, height);
                Console.WriteLine("Volume of rectangular prism is : " + volumeOfRectangularPrism);
            }
            else
            {
                Console.WriteLine("Invalid option, enter option 1,2 or3");
            }
            Console.ReadLine();
        }
    }
}

