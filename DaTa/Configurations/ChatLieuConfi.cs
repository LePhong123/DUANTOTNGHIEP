using DaTa.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Configurations
{
    internal class ChatLieuConfi : IEntityTypeConfiguration<ChatLieu>
    {
        public void Configure(EntityTypeBuilder<ChatLieu> builder)
        {
            builder.ToTable("ChatLieu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).HasColumnType("int");
        }
    }
}
