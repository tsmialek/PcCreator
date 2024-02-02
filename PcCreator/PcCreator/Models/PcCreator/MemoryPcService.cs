using Data.Entities;
using PcCreator.Models.PcCreator;

namespace PcCreator.Models
{
    public class MemoryPcService : IPcService
    {
        private Dictionary<int, Pc> _pcs;
        private IDateTimeProvider _timeProvider;

        public MemoryPcService()
        {
            _pcs = new Dictionary<int, Pc>();
            _timeProvider = new CurrentDateTimeProvider();
        }

        public int Add(Pc pc)
        {
            pc.Id = _pcs.Count + 1;
            pc.Created = _timeProvider.GetCurrentDateTime();   
            _pcs.Add(pc.Id, pc);

            return pc.Id;
        }

        public bool Delete(int id)
        {
            if (_pcs.ContainsKey(id))
            {
                _pcs.Remove(id);
                return true;
            }
            else
                return false;
        }

        public List<CpuEntity> FindAllCpusForViewModel()
        {
            throw new NotImplementedException();
        }

        public Pc? FindById(int id)
        {
            return _pcs.ContainsKey(id) ? _pcs[id] : null;
        }

        public List<Pc> GetAll()
        {
            return _pcs.Values.ToList();
        }

        public void Update(Pc pc)
        {
            var timeCreated = _pcs[pc.Id].Created;
            _pcs[pc.Id] = pc;
            _pcs[_pcs[pc.Id].Id].Created = timeCreated;
        }
    }
}
