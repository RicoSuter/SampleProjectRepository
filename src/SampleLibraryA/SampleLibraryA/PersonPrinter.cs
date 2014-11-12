using System;
using SampleLibraryC;

namespace SampleLibraryA
{
    public static class PersonPrinter
    {
        public static void Print(PersonC person)
        {
            person.Print();
        }
    }
}
