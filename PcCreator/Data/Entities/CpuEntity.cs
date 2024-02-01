using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CpuEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public float Frequency { get; set; }
        public float? TurboFrequency { get; set; }
        public int? L3Cache { get; set; }
        public ISet<PcEntity> Pcs { get; set; }
    }
}
