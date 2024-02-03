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
            RAM = entity.RAM,
            Disk = entity.Disk,
            DiskType = (DiskType)Enum.Parse(typeof(DiskType), entity.DiskType),
            Manufacturer = entity.Manufacturer,
            ProductionDate = entity.ProductionDate,
            CpuId = entity.CpuId,
            GpuId = entity.GpuId
        };

        public static PcEntity ToEntity(Pc model) => new PcEntity
        {
            Id = model.Id,
            Created = model.Created,
            Name = model.Name,
            RAM = model.RAM,
            Disk = model.Disk,
            DiskType = model.DiskType.ToString(),
            Manufacturer = model.Manufacturer,
            ProductionDate = model.ProductionDate,
            CpuId = model.CpuId,
            GpuId = model.GpuId
        };

    }
}
