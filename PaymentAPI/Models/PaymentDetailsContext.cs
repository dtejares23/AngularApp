using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models
{
    public class PaymentDetailsContext : DbContext
    {
        public PaymentDetailsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentsDetail> MyProperty { get; set; }
    }
}
