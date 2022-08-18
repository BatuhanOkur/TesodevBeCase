using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        IAddressRepository _addressRepository;

        public AddressManager()
        {
            _addressRepository = new AddressRepository();
        }

        public Address CreateAddress(Address address)
        {
            return _addressRepository.CreateAddress(address);
        }

        public void DeleteAddress(Guid id)
        {
            _addressRepository.DeleteAddress(id);
        }

        public Address GetAddress(Guid id)
        {
            return _addressRepository.GetAddress(id);
        }

        public List<Address> GetAddresses()
        {
            return _addressRepository.GetAddresses();
        }

        public Address UpdateAddress(Address address)
        {
            return _addressRepository.UpdateAddress(address);
        }
    }
}
