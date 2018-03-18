using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkConsAPP
{
    using System.Data.Entity;
    class PersonDBContext:DbContext
    {

       public PersonDBContext():base("name=personContext")
        {

        }

        public DbSet<Person> Persons { get; set; }
        //here added, a property 'Dbset' to 'Person' model in the PersonDBContext file  
//Now add connection string to the project in athe App.config file and refer the name in the class
//PersonDBContext's default constructor (add default constructor)

    }
}
