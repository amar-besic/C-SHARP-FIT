using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210178
{
    public class StipendijeIB210178
    {
        public int Id { get; set; }
        public string TtpStipendije { get; set; }

        public override string ToString()
        {
            return TtpStipendije;
        }
    }
}
