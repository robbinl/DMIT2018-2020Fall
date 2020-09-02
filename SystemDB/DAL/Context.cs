using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additional Namespaces
using System.Data.Entity;
using SystemDB.ENTITIES;

namespace SystemDB.DAL
{
    internal class Context:DbContext
    {
        public Context():base("name=ChinookDB")
        {

        }

        public DbSet<ENTITY01_Artist> DAL01_Artists { get; set; }
    }
}
