using PaymentDetails.Core.Models;
using PaymentDetails.Repo.PaymentDetails.Repository;
using PaymentDetails.Repo.RepoDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDetails.AppService.PaymentDetailsAppService
{
    public class PaymentDetailAppService : IPaymentDetailAppService
    {
        private readonly IPaymentRepository _paymentdetailrepo;
        public PaymentDetailAppService(IPaymentRepository paymentdetailrepo)
        {
            _paymentdetailrepo = paymentdetailrepo;
        }

        public async Task<string> Insert(PaymentDetail model)
        {
            try
            {
                var result = await _paymentdetailrepo.Insert(model);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
