using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PcCreator.Models
{
    public class Pc
    {
        [HiddenInput]
        public int Id { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Musisz podać nazwę")]
        public string Name { get; set; }

        [Display(Name = "Procesor")]
        [Required(ErrorMessage = "Należy wybrać model procesora")]
        public string Processor { get; set; }

        [Display(Name = "Pamięć RAM")]
        [Required(ErrorMessage = "Należy wybrać ilość pamięci RAM")]
        public string RAM { get; set; }

        [Display(Name = "Model dysku")]
        [Required(ErrorMessage = "Należy wybrać ilosć dostępnej pamięci")]
        public string Disk { get; set; }

        [Display(Name = "Typ dysku")]
        [Required(ErrorMessage = "Należy wybrać typ dysku")]
        public DiskType DiskType { get; set; }

        [Display(Name = "Model karty graficznej")]
        [Required(ErrorMessage = "Należy wybrać model karty graficznej")]
        public string GPU { get; set; }

        [Display(Name = "Producent")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Data oddania do użytku")]
        [DataType(DataType.Date)]
        public DateTime? ProductionDate { get; set; }
    }
}
