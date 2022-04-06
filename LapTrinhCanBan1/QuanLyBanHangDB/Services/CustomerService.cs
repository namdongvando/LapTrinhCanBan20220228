using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDB.Services
{
    class CustomerService
    {
        DataBanHangDataContext _db = new DataBanHangDataContext();

        public CustomerService(DataBanHangDataContext db)
        {
            _db = db;
        }
        public CustomerService()
        {
        }
         
        // lấy khách hàng theo Mã
        public Customer GetById(string id) {
            return _db.Customers.FirstOrDefault(
                item => item.CustomerID == id
                );
        }


    }
}
