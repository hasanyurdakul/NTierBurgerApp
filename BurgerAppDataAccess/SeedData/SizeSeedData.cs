using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDataAccess.SeedData
{
    internal class SizeSeedData : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size { SizeId="S", PriceDifference=0},
                new Size { SizeId="M", PriceDifference=3},
                new Size { SizeId="L", PriceDifference=5}
            );
                
                
                
                }
    }
}
