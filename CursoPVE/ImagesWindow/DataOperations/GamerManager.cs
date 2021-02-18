using ImagesWindow.Data;
using ImagesWindow.DataContracts;
using System;
using System.Collections.Generic;

namespace ImagesWindow.DataOperations
{
    public class GamerManager : IDatabaseContract<Gamer>
    {
        public bool Create(Gamer item)
        {
            //iDisposable
            using (var context = new DataContext())
            {
                context.Gamer.Add(item);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(Gamer item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gamer> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Gamer item)
        {
            throw new NotImplementedException();
        }
    }
}
