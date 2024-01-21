namespace EFCORE_010.Entites
{
    public class Enrollment
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }
        public Section Section { get; set; } = null!;
        public Particpant Particpants { get; set; } = null!;
    }
}
