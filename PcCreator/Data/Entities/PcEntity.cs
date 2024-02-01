using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PcEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime Created { get; set; } 

        [Required]
        [MaxLength(50), MinLength(3)]
        public string Name { get; set; }

        [Required]
        public string Processor { get; set; }

        [Required]
        public string RAM { get; set; }

        [Required]
        public string Disk { get; set; }

        [Required]
        public string DiskType { get; set; }

        [Required]
        public string GPU { get; set; }

        public string? Manufacturer { get; set; }

        [Column("production_date")]
        public DateTime? ProductionDate { get; set; }

        public int CpuId { get; set; }
        public CpuEntity? Cpu { get; set; }

    }
}
