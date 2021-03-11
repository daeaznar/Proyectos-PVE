using SegundoExamenParcial.Data;
using SegundoExamenParcial.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExamenParcial.DataOperations
{
    class ChampionshipManager : IDatabaseContract<DanceChampionship>
    {
        public bool Create(DanceChampionship item)
        {
            using (var context = new DataContext())
            {
                context.DanceChampionship.Add(item);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(DanceChampionship item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DanceChampionship> Read()
        {
            using (var context = new DataContext())
            {
                //AsNoTracking no guarda los datos en caché, para dejarlos libres si alguien más hace petición de los datos
                return context.DanceChampionship.AsNoTracking().ToArray();
            }
        }

        public bool Update(DanceChampionship item)
        {
            using (var context = new DataContext())
            {
                var originalRegister = context.DanceChampionship.FirstOrDefault(x => x.RegisterId == item.RegisterId);
                //Record was not found
                if (originalRegister == null)
                {
                    return false;
                }
                context.Entry(originalRegister).CurrentValues.SetValues(item);
                return context.SaveChanges() > 0;
            }
        }
    }
}
