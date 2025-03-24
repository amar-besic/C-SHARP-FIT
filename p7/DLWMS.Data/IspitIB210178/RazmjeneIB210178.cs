using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210178
{
    public class RazmjeneIB210178
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UniverzitetId { get; set; }
        public UniverzitetiIB210178 Univerzit { get; set; }
        public DateTime PocetakRazmjene { get; set; }
        public DateTime KrajRazmjene { get; set; }
        public int ECTS { get; set; }
        public bool Okoncana { get; set; }

        public string UnDrz => $"{Univerzit?.Naziv} ({Univerzit?.Drzava?.Naziv})" ??"Nema";

        public int UniverzitId { get; set; }
    }
}
