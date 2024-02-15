using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "f8cbed6a-3b5f-5519-8467-40c29c948e2c",
                    UserId = "f7cbed5a-2b5f-4419-8467-36c29c947e1c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b1cbed6c-3b5f-5519-4563-41c21c941e1d",
                    UserId = "ccac559a-254c-4873-9adb-7eefb498a20c"
                }
                
                
            );
        }
    }
}