using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additonal Namespaces
using System.ComponentModel;
using SystemDB.VIEWS;
using SystemDB.DAL;

namespace SystemDB.BLL
{
    [DataObject]
    public class BLL01_Artist
    {
        //due to the fact that the entities will be internal
        //  you will NOT be able to use them directly as return datatypes
        //instead, we will create view classes that will contain the data definition
        //  for your return data type
        //to fill these view classes we will use Linq queries
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<VIEW01_Artist> Artist_List()
        {
            using (var context = new Context())
            {
                //linq query
                //linq queries are returned as IEnumerable or IQueryable datasets
                //you can use var when declaring your query receiving variable
                var results = from x in context.DAL01_Artists
                              select new VIEW01_Artist
                              {
                                  VArtistId = x.ArtistId,
                                  VName = x.Name
                              };
                return results.OrderBy(x => x.VName).ToList();

                //we may need to keep the entities as public while we are doing the
                //    review of 1517 so as to not have to introduce Linq commands at this time
                //return context.DAL01_Artists.OrderBY(x => x.Name).ToList();
            }
        }
    }
}
