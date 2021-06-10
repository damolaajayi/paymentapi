using PaymentDetails.Core.Models;
using System.Threading.Tasks;

namespace PaymentDetails.Repo.PaymentDetails.Repository
{
    public interface IPaymentRepository
    {
        Task<string> Insert(PaymentDetail model);
    }
}