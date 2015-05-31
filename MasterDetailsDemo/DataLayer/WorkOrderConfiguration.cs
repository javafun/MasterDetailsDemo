using MasterDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsDemo.DataLayer
{
    public class WorkOrderConfiguration : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderConfiguration()
        {
            Property(wo => wo.OrderDateTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(wo => wo.Description)
                .HasMaxLength(256);

            Property(wo => wo.Total)
                .HasPrecision(18, 2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(wo => wo.CertificateionRequirements)
                .HasMaxLength(120)
                .IsOptional();


        }
    }
}
