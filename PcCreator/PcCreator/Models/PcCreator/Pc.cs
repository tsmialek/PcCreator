﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using PcCreator.Models.PcCreator;
using System.ComponentModel.DataAnnotations;

namespace PcCreator.Models
{
    public class Pc
    {
        [HiddenInput]
        public int Id { get; set; }

        [HiddenInput]
        [Display(Name = "Data utworzenia")]
        public DateTime Created { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Musisz podać nazwę")]
        public string Name { get; set; }

        [Display(Name = "Pamięć RAM")]
        [Required(ErrorMessage = "Należy wybrać ilość pamięci RAM")]
        public string RAM { get; set; }

        [Display(Name = "Wielkość dysku")]
        [Required(ErrorMessage = "Należy wybrać ilosć dostępnej pamięci")]
        public string Disk { get; set; }

        [Display(Name = "Typ dysku")]
        [Required(ErrorMessage = "Należy wybrać typ dysku")]
        public DiskType DiskType { get; set; }

        [Display(Name = "Producent")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Data oddania do użytku")]
        [DataType(DataType.Date)]
        public DateTime? ProductionDate { get; set; }

        [HiddenInput]
        public int CpuId { get; set; }
        [ValidateNever]
        public List<SelectListItem> Cpus { get; set; }

        [HiddenInput]
        public int GpuId { get; set; }
        [ValidateNever]
        public List<SelectListItem> Gpus { get; set;}
    }
}
