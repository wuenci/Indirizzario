using Indirizzario.Db.Models;
using Indirizzario.Wcf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indirizzario.Wcf
{
    public class ComunicationService : ICom
    {
        
        public void AddAddress(Address address)
        {
            using (var context = new IndirizzarioDbContext())
            {
                context.Addresses.Add(address);
                context.SaveChanges();
                Console.WriteLine("Persona inserito dal Server");
            }
        }

        public void AddPerson(Person person)
        {
            using (var context = new IndirizzarioDbContext())
            {
                context.People.Add(person);
                context.SaveChanges();
                Console.WriteLine("Indirizzo inserito dal Server");
            }
        }
    }
}
