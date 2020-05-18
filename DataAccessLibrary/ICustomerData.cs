using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    interface ICustomerData
    {
        Task<List<CustomerModel>> GetCustomer();
        Task InsertCustomer(CustomerModel customer);
    }
}