using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210178
{
    public class StipendijeGodineIB210178
    {
        public int Id { get; set; }
        public int Godina { get; set; }
        public int StipendijaId { get; set; }
        public StipendijeIB210178 Stipendija { get; set; }
        public int Iznos { get; set; }
        public bool Dodjeljivana { get; set; }

        public override string ToString()
        {
            return Stipendija.ToString();
        }
    }
}
