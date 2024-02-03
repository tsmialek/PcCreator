using Data;
using Data.Entities;
using PcCreator.Mappers;
    using PcCreator.Models.PcCreator;

    namespace PcCreator.Models
    {
        public class EFPcService : IPcService
        {
            private readonly AppDbContext _context;
        private IDateTimeProvider _timeProvider;

        public EFPcService()
        {
            _context = new AppDbContext();
            _timeProvider = new CurrentDateTimeProvider();
        }

        public int Add(Pc pc)
        {
            var e = _context.Pcs.Add(PcMapper.ToEntity(pc));
            e.Entity.Created = _timeProvider.GetCurrentDateTime();
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public bool Delete(int id)
        {
            var Find = _context.Pcs.Find(id);
            if (Find != null)
            {
                _context.Pcs.Remove(Find);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<CpuEntity> FindAllCpusForViewModel()
        {
            return _context.Cpus.ToList();
        }

        public List<GpuEntity> FindAllGpusForViewModel()
        {
            return _context.Gpus.ToList();
        }

        public Pc? FindById(int id)
        {
            return PcMapper.ToModel(_context.Pcs.Find(id));
        }

        public List<Pc> GetAll()
        {
            return _context.Pcs.Select(e => PcMapper.ToModel(e)).ToList();
        }

        public void Update(Pc pc)
        {
            var entityToUpdate = _context.Pcs.Find(pc.Id);
            if (entityToUpdate != null)
            {
                // Teraz aktualizujemy właściwości istniejącego obiektu
                entityToUpdate.Name = pc.Name;
                entityToUpdate.CpuId = pc.CpuId;
                entityToUpdate.RAM = pc.RAM;
                entityToUpdate.Disk = pc.Disk;
                entityToUpdate.DiskType = pc.DiskType.ToString();
                entityToUpdate.CpuId = pc.CpuId;
                entityToUpdate.GpuId = pc.GpuId;
                entityToUpdate.Manufacturer = pc.Manufacturer;
                entityToUpdate.ProductionDate = pc.ProductionDate;

                _context.Update(entityToUpdate); // Może być opcjonalne w zależności od konfiguracji EF
                _context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
