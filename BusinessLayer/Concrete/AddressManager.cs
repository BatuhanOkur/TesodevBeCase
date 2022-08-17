using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        AddressRepository addressRepository = new AddressRepository();
        public Address CreateAddress(Address address)
        {
            return addressRepository.CreateAddress(address);
        }

        public void DeleteAddress(Guid id)
        {
            addressRepository.DeleteAddress(id);
        }

        public Address GetAddress(Guid id)
        {
            return addressRepository.GetAddress(id);
        }

        public List<Address> GetAddresses()
        {
            return addressRepository.GetAddresses();
        }

        public Address UpdateAddress(Address address)
        {
            return addressRepository.UpdateAddress(address);
        }
    }
}
