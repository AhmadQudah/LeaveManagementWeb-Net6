using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "d6fa7f81-9cc7-41b6-9661-fba613c2d087",
                    UserId = "d6fa7f91-9cc6-41b5-9668-fba613c2d087"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "d6fb8f81-9dd7-48b8-9771-aea613c2d022",
                    UserId = "0972a611-49fa-4f65-a9e4-fddbb724c38a"
                }
            );
        }
    }
}