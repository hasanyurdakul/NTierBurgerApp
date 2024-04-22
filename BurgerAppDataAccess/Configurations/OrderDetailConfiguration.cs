using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BurgerAppDataAccess.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            //OrderId ve ProductId propertylerini, OrderDetails tablosunda composite key olarak kullanmamızı sağlar.
            builder.HasKey(od => new { od.OrderId ,od.ProductId});
        }
    }
}
