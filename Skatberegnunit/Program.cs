namespace Skatberegnunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personer = new[]
             {
                new Person(20000, Person.Jobkategori.Studerende),
                new Person(40000, Person.Jobkategori.Studerende),
                new Person(20000, Person.Jobkategori.Underviser),
                new Person(40000, Person.Jobkategori.Underviser),
                new Person(0, Person.Jobkategori.Pensionist),
                new Person(20000, Person.Jobkategori.Pensionist),
                new Person(40000, Person.Jobkategori.Pensionist)
            };

            // Beregner og viser skatten for hver person
            foreach (var person in personer)
            {
                var skat = skatteberegner.BeregnSkat(person);
                Console.WriteLine($"{person} - Skat: {skat}");
            }
        }
    }
}
