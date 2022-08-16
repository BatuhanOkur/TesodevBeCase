using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AddressRepository : IAddressRepository
    {
        Context dbContext = new Context();
        public Address CreateAddress(Address address)
        {
            dbContext.Addresses.Add(address);
            dbContext.SaveChanges();
            return address;
        }

        public void DeleteAddress(Guid id)
        {
            var deletedAdress = GetAddress(id);
            dbContext.Addresses.Remove(deletedAdress);
            dbContext.SaveChanges();
        }

        public Address GetAddress(Guid id)
        {
            return dbContext.Addresses.Find(id);
        }

        public List<Address> GetAddresses()
        {
            return dbContext.Addresses.ToList();
        }

        public Address UpdateAddress(Address address)
        {
            dbContext.Addresses.Update(address);
            dbContext.SaveChanges();
            return address;
        }
    }
}
