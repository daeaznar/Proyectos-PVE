using Grades.DataContracts;
using Grades.Data;
using System;
using System.Collections.Generic;

namespace Grades.DataOperations
{
    public class GradesManager : IDatabaseContract<Grades>
    {
        public bool Create(Grades item)
        {
            using (var context = new DataContext())
            {
                context.Grades.Add(item);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(Grades item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Grades> Read()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Grades item)
        {
            throw new System.NotImplementedException();
        }

        internal bool Create(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
