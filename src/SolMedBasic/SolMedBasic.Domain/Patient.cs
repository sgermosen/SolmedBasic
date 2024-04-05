using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolMedBasic.Domain
{
    public class Patient: BaseEntity
    {
        public string Address { get; set; }
        public string Dni { get; set; }
        public DateTime BornDate { get; set; }

    }
}
