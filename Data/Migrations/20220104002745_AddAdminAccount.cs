using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

namespace TechTree.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "07c12996-cae1-4f73-a5bf-aca90fe6035c";
        const string ADMIN_ROLE_GUID = "279c5547-b904-4d3d-bd31-061d4969d1da";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var passwordHash = hasher.HashPassword(null, "Password100!");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into AspNetUsers(Id, UserName, NormalizedUserName, Email, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp,FirstName)");
            sb.AppendLine("values(");
            sb.AppendLine($"'{ADMIN_USER_GUID}'");// ID
            sb.AppendLine(",'admin@techtree.com'");// UserName
            sb.AppendLine(",'ADMIN@TECHTREE.COM'");// NormalizedUserName
            sb.AppendLine(",'admin@techtree.com'");// Email
            sb.AppendLine(", 0"); // EmailConfirmed
            sb.AppendLine(", 0"); // PhoneNumberConfirmed
            sb.AppendLine(", 0"); // TwoFactorEnabled
            sb.AppendLine(", 0"); // LockoutEnabled
            sb.AppendLine(", 0"); // AccessFailedCount
            sb.AppendLine(",'ADMIN@TECHTREE.COM'");// NormalizedEmail
            sb.AppendLine($", '{passwordHash}'");// PasswordHash
            sb.AppendLine(", ''");// SecurityStamp
            sb.AppendLine(", 'Admin'");// FirstName
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());
            migrationBuilder.Sql($"insert into AspNetRoles(Id, Name, NormalizedName) values('{ADMIN_ROLE_GUID}', 'Admin', 'ADMIN')");
            migrationBuilder.Sql($"insert into AspNetUserRoles(UserId, RoleId) values('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"Delete from AspNetUserRoles where UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");
            migrationBuilder.Sql($"Delete from AspNetUsers where Id = '{ADMIN_USER_GUID}'");
            migrationBuilder.Sql($"Delete from AspNetRoles where Id = '{ADMIN_ROLE_GUID}'");
        }
    }
}
