using Data.Entities;
using PcCreator.Models;

namespace PcCreator.Mappers
{
    public class PcMapper
    {
        public static Pc ToModel(PcEntity entity) => new Pc
        {
            Id = entity.Id,
            Created = entity.Created,
            Name = entity.Name,
            Processor = entity.Processor,
            RAM = entity.RAM,
            Disk = entity.Disk,
            DiskType = (DiskType)Enum.Parse(typeof(DiskType), entity.DiskType),
            GPU = entity.GPU,
            Manufacturer = entity.Manufacturer,
            ProductionDate = entity.ProductionDate
        };

        public static PcEntity ToEntity(Pc model) => new PcEntity
        {
            Id = model.Id,
            Created = model.Created,
            Name = model.Name,
            Processor = model.Processor,
            RAM = model.RAM,
            Disk = model.Disk,
            DiskType = model.DiskType.ToString(),
            GPU = model.GPU,
            Manufacturer = model.Manufacturer,
            ProductionDate = model.ProductionDate
        };

    }
}
