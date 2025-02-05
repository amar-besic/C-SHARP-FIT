using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210178
{
    public class StudentiUvjerenjaIB210178
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Vrjeme { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }

        public bool Printano { get; set; }

        public override string ToString()
        {
            return Vrsta;
        }
    }
}
