
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BahatiGroup.Web.Shared.Core.Interfaces
{
   public interface IAddressRepository
    {
        Task<Address> AddAddressAsync(Address address);
        Task<List<Address>> GetAddressesAsync();
        Task<Address> GetAddressById(int addressId);
        Task<Address> UpdateAddressAsync(Address address);
        void DeleteAddress(int addressId);
    }
}
