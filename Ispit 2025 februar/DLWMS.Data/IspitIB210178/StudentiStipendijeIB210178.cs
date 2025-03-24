using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210178
{
    public  class StudentiStipendijeIB210178
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int StipendijaGodinaId { get; set; }
        public StipendijeGodineIB210178 StipendijaGodina { get; set; }

        public string mjesecniIznos => $"{StipendijaGodina?.Iznos}" ??"Nema";
      
        public string Ukupno => StipendijaGodina.Godina != DateTime.Now.Year ? $"{StipendijaGodina.Iznos * 12}" : $"{StipendijaGodina.Iznos * DateTime.Now.Month}" ;
   


    }
}
