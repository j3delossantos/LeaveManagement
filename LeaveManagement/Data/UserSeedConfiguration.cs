using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = "f7cbed5a-2b5f-4419-8467-36c29c947e1c",
                    UserName = "j3delossantos@gmail.com",
                    NormalizedUserName = "J3DELOSSANTOS@GMAIL.COM",
                    FirstName = "Super",
                    LastName = "Admin",
                    Email = "j3delossantos@gmail.com",
                    NormalizedEmail = "J3DELOSSANTOS@GMAIL.COM",
                    EmailConfirmed = true,                    
                    PasswordHash = "AQAAAAEAACcQAAAAEGqGLBIv/2FoCH2cS60g/DSbSz8PrjmdbeWiwvPeDSYJNPGE4WtPu9SkKCrewp1T7Q=="                    
                },
                new Employee
                {
                    Id = "ccac559a-254c-4873-9adb-7eefb498a20c",
                    UserName = "test@test.com",
                    NormalizedUserName = "TEST@TESt.COM",
                    FirstName = "User",
                    LastName = "User",
                    Email = "test@test.com",
                    NormalizedEmail = "TEST@TESt.COM",
                    EmailConfirmed = true,                    
                    PasswordHash = "AQAAAAEAACcQAAAAEGqGLBIv/2FoCH2cS60g/DSbSz8PrjmdbeWiwvPeDSYJNPGE4WtPu9SkKCrewp1T7Q=="
                }                
           );
        }
    }
}