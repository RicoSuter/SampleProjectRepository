using System;
using SampleLibraryA;
using SampleLibraryB;
using SampleLibraryC;

namespace SampleApplication
{
    public static class Program
    {
        public static void Main()
        {
            PersonC person = null; // SampleLibraryC
            person = PersonFactory.Create(); // SampleLibraryB
            PersonPrinter.Print(person); // SampleLibraryA
            
            Console.ReadLine();
        }
    }
}
