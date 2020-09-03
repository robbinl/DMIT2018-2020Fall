using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additional Namespaces
using SystemDB.DAL;
using SystemDB.VIEWS;

namespace SystemDB.BLL
{
    public class BLL02_Album
    {
        public List<VIEW02_Album> AlbumsByArtist(int artistid)
        {
            using (var context = new Context())
            {
                var results = from x in context.DAL02_Albums
                              where x.ArtistId == artistid
                              select new VIEW02_Album
                              {
                                  VAlbumId = x.AlbumId,
                                  VTitle = x.Title,
                                  VArtistId = x.ArtistId,
                                  VReleaseYear = x.ReleaseYear,
                                  VReleaseLabel = x.ReleaseLabel
                              };
                return results.ToList();

                //we may need to keep the entities as public while we are doing the
                //    review of 1517 so as to not have to introduce Linq commands at this time
                //the sql procs return all attributes of the table therefore
                //    a public view would need to duplicate the entity
                //IEnumerable<Albums> info =
                //    context.Database.SqlQuery<Albums>("Albums_ByArtistId @artistid",
                //                new SqlParameter("artistid", artistid));
                //return info.ToList();
            }
        }
    }
}
