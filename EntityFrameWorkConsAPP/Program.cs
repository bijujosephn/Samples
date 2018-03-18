using EntityFrameWorkConsAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkConsAPP
{// Ref:https://www.codeproject.com/tips/1046655/very-basic-console-application-using-entity-framew
 // after installing the Entity Frame work using the Tools->nuggest packagemanager
 // PM> Install-Package EntityFramework -Version 6.2.0
 //CREATE YOUR MODEL:now create a model class (context and entity classes that makes up your model)
 //   Project ->ADD  ->class..
 //Enter Model.CS and click OK
 //enter the following code
 public class Person
    {
        public Person()
        {
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; } 
        //Now create a new DBcontext class to communicate to the database
        //Project->add -> Class, name it as PersonDBContext.cs ,click ok
        //Let thisclass extends DBCONTEXT 
        // class PersonDBContext:DBContext  and add the code as added in the class
       }
    }

    //https://www.codeproject.com/tips/1046655/very-basic-console-application-using-entity-framew

    class Program
    {
    public static void Main(string[] args)
    {
        PerformDatabaseOperations();
        Console.Write("Person saved !");
        Console.ReadLine();
    }

    /// <summary>
    ///     The perform database operations.
    /// </summary>
    public static void PerformDatabaseOperations()
    {
        using (var db = new PersonDBContext())
        {
            var person = new Person
            {
                FirstName = "Biju",
                LastName = "Joseph",
                BirthDate = DateTime.Now
            };

            db.Persons.Add(person);
            db.SaveChanges();
        }
    }
}

