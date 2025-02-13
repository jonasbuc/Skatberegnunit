using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatberegnunit
{
    public class Person
    {
        public int Indkomst { get; set; }
        public Jobkategori jobkategori { get; set; }

        public enum Jobkategori
        {
            Studerende = 1,
            Underviser = 2,
            Pensionist = 3
        }
        public Person(int indkomst, Jobkategori jobkategori)
        {
            Indkomst = indkomst;
            this.jobkategori = jobkategori;
        }
        public override string ToString()
        {
            return $"Indkomst: {Indkomst}, Jobkategori: {jobkategori}";
        }
    }
}
