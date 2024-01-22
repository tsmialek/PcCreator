using System.ComponentModel.DataAnnotations;

namespace PcCreator.Models
{
    public enum DiskType
    {
        [Display(Name = "SSD")] SSD = 1,
        [Display(Name = "HDD")] HDD = 2,
        [Display(Name = "Hybrydowy")] Hybrid = 3,
        [Display(Name = "NVMe")] NVMe = 4,
    }
}
