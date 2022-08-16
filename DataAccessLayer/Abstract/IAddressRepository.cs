using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAddressRepository
    {
        List<Address> GetAddresses();

        Address GetAddress(Guid id);

        Address CreateAddress(Address address);

        Address UpdateAddress(Address address);

        void DeleteAddress(Guid id);
    }
}
