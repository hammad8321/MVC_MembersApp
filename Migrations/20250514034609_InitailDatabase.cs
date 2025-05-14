using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberApp_MVC.Migrations
{
    /// <inheritdoc />
    public partial class InitailDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatToExpire",
                table: "MembersDb",
                newName: "DaysToExpire");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaysToExpire",
                table: "MembersDb",
                newName: "DatToExpire");
        }
    }
}
