﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TASK3_Core.Entities;

namespace TASK3_DataAccess.Configurations {
  public class StudentConfiguration : IEntityTypeConfiguration<Student> {
    public void Configure(EntityTypeBuilder<Student> builder) {
      builder.Property(s => s.FirstName)
          .IsRequired()
          .HasMaxLength(50);

      builder.Property(s => s.LastName)
          .IsRequired()
          .HasMaxLength(50);

      builder.Property(s => s.Email)
          .IsRequired()
          .HasMaxLength(100);

      builder.Property(s => s.Phone)
          .IsRequired()
          .HasMaxLength(12);

      builder.Property(s => s.Address)
          .IsRequired()
          .HasMaxLength(200);

      builder.Property(s => s.BirthDate)
          .IsRequired();

      builder.HasOne(s => s.Group)
          .WithMany(g => g.Students)
          .HasForeignKey(s => s.GroupId); 
    }
  }
}
