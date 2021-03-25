using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterApplicatie.Data
{
    public interface IObjectService<TObject>
    {
        List<TObject> GetAll();
        TObject Get(int id);
        void Add(TObject klant);
        bool Update(TObject klant);
        bool Delete(int id);
        bool Exists(int id);
    }
}
