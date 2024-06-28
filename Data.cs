using System.Reflection;
using System.Collections.Generic;
using digiBookModel;
using digiBookDataLayer;

namespace digiBookDataLayer
{
    public class Data
    {
        public static List<bookss> book()
        {
            sqldbdata dataAccess = new sqldbdata();
            return dataAccess.GetBooks();
        }
    }
}
