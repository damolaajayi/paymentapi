using Microsoft.EntityFrameworkCore;
using PaymentDetails.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDetails.Repo.RepoDbContext
{
    public class PaymentDetailsDbContext : DbContext
    {
        public PaymentDetailsDbContext(DbContextOptions<PaymentDetailsDbContext> options) : base(options)
        {


        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }


       

    }

}
