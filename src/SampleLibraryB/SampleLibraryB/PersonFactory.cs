using SampleLibraryC;

namespace SampleLibraryB
{
    public static class PersonFactory
    {
        public static PersonC Create()
        {
            return new PersonC { Name = "Foo" };
        }
    }
}
