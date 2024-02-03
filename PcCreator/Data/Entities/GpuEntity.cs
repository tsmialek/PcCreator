using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class GpuEntity
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string FullName { get; set; }
        public int VRam { get; set; }
        public ISet<PcEntity> Pcs { get; set; }
    }
}
