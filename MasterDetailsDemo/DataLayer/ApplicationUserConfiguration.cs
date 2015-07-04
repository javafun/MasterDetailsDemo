using MasterDetailsDemo.Models;
using System.Data.Entity.ModelConfiguration;

namespace MasterDetailsDemo.DataLayer
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            Property(au => au.FirstName)
                .HasMaxLength(15)
                .IsOptional();
        }
    }
}
