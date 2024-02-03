using Data.Entities;

namespace PcCreator.Models
{
    public interface IPcService
    {
        int Add(Pc pc);
        bool Delete(int id);
        void Update(Pc pc);
        List<Pc> GetAll();
        Pc? FindById(int id);
        List<CpuEntity> FindAllCpusForViewModel();
        List<GpuEntity> FindAllGpusForViewModel();
        CpuEntity? FindCpuById(int id);
        GpuEntity? FindGpuById(int id);
    }
}
