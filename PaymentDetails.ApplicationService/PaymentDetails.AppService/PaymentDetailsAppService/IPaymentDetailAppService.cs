using PaymentDetails.Core.Models;
using System.Threading.Tasks;

namespace PaymentDetails.AppService.PaymentDetailsAppService
{
    public interface IPaymentDetailAppService
    {
        Task<string> Insert(PaymentDetail model);
    }
}