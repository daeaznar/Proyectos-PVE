using ImagesWindow.Data;
using ImagesWindow.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;

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
            using (var context = new DataContext())
            {
                var entry = context.Event.FirstOrDefault(x => x.EventId == item.EventId);
                if (entry == null)
                {
                    return false;
                }
                context.Event.Remove(entry);
                return context.SaveChanges() > 0;
            }
        }

        public IEnumerable<Event> Read()
        {
            using (var context = new DataContext())
            {
                //AsNoTracking no guarda los datos en caché, para dejarlos libres si alguien más hace petición de los datos
                return context.Event.AsNoTracking().ToArray();
            }
        }

        public bool Update(Event item)
        {
            using (var context = new DataContext())
            {
                var originalEvent = context.Event.FirstOrDefault(x => x.EventId == item.EventId);
                //Record was not found
                if (originalEvent == null)
                {
                    return false;
                }
                context.Entry(originalEvent).CurrentValues.SetValues(item);
                return context.SaveChanges() > 0;
            }
        }
    }
}
