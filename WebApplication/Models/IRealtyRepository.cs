using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyManager.Models
{
    public interface IRealtyRepository
    {
        Realty Get(int id);
        IEnumerable<Realty> GetAll();
        Realty Add(Realty realty);
        Realty Update(Realty realty);
        void Delete(int realtyId);
    }
}
