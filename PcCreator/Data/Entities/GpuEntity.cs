using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class GpuEntity
    {
        public int Id { get; set; }

        [Display(Name = "Producent")]
        public string Manufacturer { get; set; }

        [Display(Name = "Pełna nazwa")]
        public string FullName { get; set; }

        [Display(Name = "Pamięć VRAM")]
        public int VRam { get; set; }

        public ISet<PcEntity> Pcs { get; set; }
    }
}
