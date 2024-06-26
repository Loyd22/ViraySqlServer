using digiBookModel;
using System.Reflection;

using System.Collections.Generic;
using digiBookModel;

namespace digiBookDataLayer
{
    public class Data
    {
        public static List<bookss> book()
        {
            return sqldbdata.GetBooksFromDatabase();
        }
    }
}
