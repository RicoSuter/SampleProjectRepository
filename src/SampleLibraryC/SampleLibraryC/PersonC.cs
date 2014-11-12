using System;

namespace SampleLibraryC
{
    public class PersonC
    {
        public string FirstName { get; set; }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Hello from SampleLibraryC: " + FirstName;
        }
    }
}
