using Grades.DataContracts;
using Grades.Data;
using System;
using System.Collections.Generic;

namespace Grades.DataOperations
{
    public class GradesManager : IDatabaseContract<Data.Grades>
    {
        public bool Create(Data.Grades item)
        {
            using (var context = new DataContext())
            {
                context.Grades.Add(item);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(Data.Grades item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Data.Grades> Read()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Data.Grades item)
        {
            throw new System.NotImplementedException();
        }

    }
}
