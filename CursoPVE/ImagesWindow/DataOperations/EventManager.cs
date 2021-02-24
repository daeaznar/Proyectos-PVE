using ImagesWindow.Data;
using ImagesWindow.DataContracts;
using System;
using System.Collections.Generic;

namespace ImagesWindow.DataOperations
{
    public class EventManager : IDatabaseContract<Event>
    {
        public bool Create(Event item)
        {
            using (var context = new DataContext())
            {
                context.Event.Add(item);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(Event item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Event item)
        {
            throw new NotImplementedException();
        }
    }
}
