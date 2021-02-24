using System.Collections.Generic;

namespace Grades.DataContracts
{
    interface IDatabaseContract<T> where T : class
    {
        bool Create(T item);

        IEnumerable<T> Read();

        bool Update(T item);

        bool Delete(T item);

    }
    
}
