namespace EFCORE_010.Entites
{
    public class Particpant
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
    public class Individaul : Particpant
    {
        public string University { get; set; }
        public int YearOfGraduation { get; set; }
        public bool isIntern { get; set; }
        public override string ToString()
        {
            return $"{Id} | {FName}| {LName}| {University} | {YearOfGraduation} | Not internship {isIntern} ";
        }
    }
    public class Coporate : Particpant
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public override string ToString()
        {
            return $"{Id} | {FName}| {LName}| {JobTitle} | {Company}";
        }
    }
}
