﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAUNSportsSystem.DomainClasses.Configuration
{
    public class TechnicalStaffRoleConfig : EntityTypeConfiguration<TechnicalStaffRole>
    {
        public TechnicalStaffRoleConfig()
        {
            Property(x => x.Name).HasMaxLength(50).IsRequired();
        }
    }
}
