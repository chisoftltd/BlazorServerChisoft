using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    class CustomerData : ICustomerData
    {
        private readonly ISqlDataAccess db;

        public CustomerData(ISqlDataAccess _db)
        {
            db = _db;
        }

        public Task<List<CustomerModel>> GetCustomer()
        {
            string sql = "select * from dbo.Customer";

            return db.LoadData<CustomerModel, dynamic>(sql, new { });
        }

        public Task InsertCustomer(CustomerModel customer)
        {
            string sql = @"insert into dbo.Customer (FirstName, LastName, Age, City)
                        values (@FirstName, @LastName, @Age, @City);";

            return db.SaveData(sql, customer);
        }
    }
}
