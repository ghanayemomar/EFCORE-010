
using EFCORE_010.Entites;

namespace EFCORE_10.Entites
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? OfficeId { get; set; }
        public Office? Office { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();   
    }
}
