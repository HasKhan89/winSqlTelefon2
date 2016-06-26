using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winSqlTelefon2
{
    public class Adres
    {
        public int AdresID { get; set; }
        public string AdresTanim { get; set; }
        public int AdresKisiID { get; set; }

        public override string ToString()
        {
            return AdresTanim;
        }
    }
}
