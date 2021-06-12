using Microsoft.AspNetCore.Mvc;
using PaymentDetails.AppService.PaymentDetailsAppService;
using PaymentDetails.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentDetailAPI.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]

    public class PaymentDetailsController : ControllerBase
    {
        private readonly IPaymentDetailAppService _paymentDetailAppService;

        public PaymentDetailsController(IPaymentDetailAppService paymentDetailAppService)
        {
            _paymentDetailAppService = paymentDetailAppService;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> PostPaymentDetail(PaymentDetail paymentDetail)
        {

            var result = await _paymentDetailAppService.Insert(paymentDetail);

            return Ok(result);
            //return CreatedAtAction("GetPaymentDetail", new { id = paymentDetail.PaymentDetailId }, paymentDetail);
        }
    }
}
