namespace PcCreator.Models
{
    public interface IPcService
    {
        int Add(Pc pc);
        bool Delete(int id);
        void Update(Pc pc);
        List<Pc> GetAll();
        Pc? FindById(int id);
    }
}
