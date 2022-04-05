using System;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Responsibility

            Console.WriteLine("Single Responsibility\n");

            Console.WriteLine(DirectoryService.GetProjectFolderPath());

            Console.WriteLine('\n');

            // Open-Closed

            Console.WriteLine("Open-Closed\n");

            foreach (var item in TypeService.GetDerivedTypes(typeof(Fruit).FullName))
                Console.WriteLine(item.FullName); // Yeni fruitden inherited olunmus class gelse bele yene tapacaq

            Console.WriteLine('\n');

            // Liskov Substitution 

            Console.WriteLine("Liskov Substitution\n");

            var Transport = new Car();
            Console.WriteLine(Transport.GetClassFullname());

            Console.WriteLine('\n');

            // Interface Segregation 

            Console.WriteLine("Interface Segregation\n");

            var contentControl = new ContentControl();
            var itemsControl = new ItemsControl();

            contentControl.IAddChild("item");
            itemsControl.IAddChild("item");

            contentControl.Hit();

            Console.WriteLine('\n');

            // Depedency Inversion

            Console.WriteLine("Depedency Inversion\n");

            var computer = new Computer();
            computer.SetSystem(new KaliLinux());
            // computer.SetSystem(new Windows());

            Console.WriteLine(string.Format("Operation System: {0}", computer.System.ToString()));

            Console.WriteLine('\n');
        }
    }
}
