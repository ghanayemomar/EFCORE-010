using EFCORE_010.Entites;
using EFCORE_10.Data;

var participant1 = new Individaul
{
    Id = 1,
    FName = "Ahmad",
    LName = "Ali",
    University = "AAUP",
    YearOfGraduation = 2024,
    isIntern = false
};

var participant2 = new Coporate
{
    Id = 2,
    FName = "Ahmad",
    LName = "Ali",
    Company = "Migration",
    JobTitle = "Developer"
};
var participant3 = new Coporate
{
    Id = 2,
    FName = "Reem",
    LName = "Ali",
    Company = "Migration",
    JobTitle = "QA"
};
using (var context = new AppDbContext())
{
    context.Particpants.Add(participant1);
    context.Particpants.Add(participant2);
    context.SaveChanges();

}

using (var context = new AppDbContext())
{
    Console.WriteLine("Coporate Part");
    Console.WriteLine("Individual Part");
    foreach (var particpant in context.Set<Particpant>().OfType<Individaul>())
    {
        Console.WriteLine(particpant);
    }
    foreach (var coporate in context.Set<Particpant>().OfType<Coporate>())
    {
        Console.WriteLine(coporate);
    }

}