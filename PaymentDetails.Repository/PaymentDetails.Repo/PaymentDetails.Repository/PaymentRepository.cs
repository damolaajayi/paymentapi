using PaymentDetails.Core.Models;
using PaymentDetails.Repo.RepoDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDetails.Repo.PaymentDetails.Repository
{

    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentDetailsDbContext _context;

        public PaymentRepository(PaymentDetailsDbContext context)
        {
            _context = context;
        }

        public async Task<string> Insert(PaymentDetail model)
        {
            try
            {
                await _context.PaymentDetails.AddAsync(model);
                return "Inserted succesfully";
            }


            catch (Exception ex)
            {

                return "";
            }
        }
    }

}
