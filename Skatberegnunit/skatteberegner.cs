using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatberegnunit
{
   

    public class skatteberegner
    {
        public static int BeregnSkat(Person p)
        {
           
            if (p.Indkomst <= 0)
            {
                return 0;
            }

            
            else if (p.Indkomst <= 20000 && p.jobkategori != Person.Jobkategori.Pensionist)
            {
                return (int)(p.Indkomst * 0.10); 
            }

            
            else if (p.Indkomst > 20000 && p.jobkategori != Person.Jobkategori.Pensionist)
            {
                return (int)(p.Indkomst * 0.20); 
            }

            
            else
            {
                return (int)(p.Indkomst * 0.05); 
            }
        }
    }
}

