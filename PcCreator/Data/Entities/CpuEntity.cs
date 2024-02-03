using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CpuEntity
    {
        public int Id { get; set; }

        [Display(Name = "Pełna nazwa")]
        public string Name { get; set; }

        [Display(Name = "Liczba rdzeni")]
        public int Cores { get; set; }

        [Display(Name = "Liczba wątków")]
        public int Threads { get; set; }

        [Display(Name = "Taktowanie bazowe")]
        public float Frequency { get; set; }

        [Display(Name = "Taktowanie turbo")]
        public float? TurboFrequency { get; set; }

        [Display(Name = "Pamięć L3")]
        public int? L3Cache { get; set; }

        public ISet<PcEntity> Pcs { get; set; }
    }
}
