using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
   /* interface IRealtyRepository
    {
        IEnumerable<Realty> GetAll();
        Realty Get(int id);
        Realty Add(Realty item);
        void Remove(int id);
        bool Update(Realty item);
    }*/

    public interface IRealtyRepository
    {
        Realty Get(int id);
        IEnumerable<Realty> GetAll();
        Realty Add(Realty realty);
        Realty Update(Realty realty);
        void Delete(int realtyId);
    }
}
