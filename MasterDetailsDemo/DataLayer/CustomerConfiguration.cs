﻿using MasterDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsDemo.DataLayer
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(c => c.AccountNumber)
                .HasMaxLength(8)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_Customer_CustomerAccountNumber") { IsUnique = true }));

            Property(c => c.CompanyName)
                .HasMaxLength(30)
                .IsRequired(); 
                
            Property(c => c.Address)
                .HasMaxLength(30)
                .IsRequired();

            Property(c => c.City)
                .HasMaxLength(15)
                .IsRequired();
            
            Property(c => c.State)
                .HasMaxLength(2)
                .IsRequired();

            Property(c => c.ZipCode)
                .HasMaxLength(10)
                .IsRequired();

            Property(c => c.Phone)
                .HasMaxLength(15)
                .IsOptional(); 

        }
    }
}