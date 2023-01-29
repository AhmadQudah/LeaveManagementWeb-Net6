using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "d6fa7f91-9cc6-41b5-9668-fba613c2d087",
                    Email = "ahiq95@gmail.com",
                    NormalizedEmail = "AHIQ95@GMAIL.COM",
                    UserName = "ahiq95@gmail.com",
                    NormalizedUserName = "AHIQ95@GMAIL.COM",
                    FirstName = "Ahmad",
                    LastName = "Qudah",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "0972a611-49fa-4f65-a9e4-fddbb724c38a",
                    Email = "ahmad@test.com",
                    NormalizedEmail = "AHMAD@TEST.COM",
                    UserName = "ahmad@test.com",
                    NormalizedUserName = "AHMAD@TEST.COM",
                    FirstName = "Ahmad",
                    LastName = "Test",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                    EmailConfirmed = true
                }
             );
        }

    }
}