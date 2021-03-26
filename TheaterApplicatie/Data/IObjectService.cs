using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterApplicatie.Data
{
    public interface IObjectService<TObject>
    {
        public List<TObject> GetAll();
        public TObject Get(int id);
        public bool Add(TObject apiObject);
        public bool Delete(int id);
        public bool Update(int id, TObject apiObject);
        public bool Exists(int id);
    }
}
