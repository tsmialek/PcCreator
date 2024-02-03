using Data.Entities;

namespace PcCreator.Models.PcCreator
{
    public class PcDetailsViewModel
    {
        public Pc Pc { get; set; }
        public CpuEntity? Cpu { get; set; }
        public GpuEntity? Gpu { get; set; }
    }
}
