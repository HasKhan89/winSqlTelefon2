using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winSqlTelefon2
{
    public class Telefon
    {
        public int TelefonID { get; set; }
        public string TelefonNo { get; set; }
        public int TelefonKisiID { get; set; }

        public override string ToString()
        {
            return TelefonNo;
        }
    }
}
