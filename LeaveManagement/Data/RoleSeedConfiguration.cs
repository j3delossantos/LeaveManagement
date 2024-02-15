using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "f8cbed6a-3b5f-5519-8467-40c29c948e2c",
                    Name = Roles.Admin,
                    NormalizedName = Roles.Admin.ToUpper()
                },
                new IdentityRole
                {
                    Id = "b1cbed6c-3b5f-5519-4563-41c21c941e1d",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            );
        }
    }
}