using EFCore_Session_2_Assignment.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_2_Assignment.Config
{
    internal class TopicConfigration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {

            builder.HasKey(d => d.ID);

            builder.Property(d=>d.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired().HasDefaultValue("Topic");
        }
    }
}
