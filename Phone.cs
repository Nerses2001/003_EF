
namespace _003_EF
{
    internal class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price {  get; set; }

        // Navigate proporty
        public Company Manufacter { get; set; }

    }
}
