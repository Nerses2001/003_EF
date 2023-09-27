

using System.ComponentModel.DataAnnotations.Schema;

namespace _003_EF
{

  //  [NotMapped]
    internal class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }


}
