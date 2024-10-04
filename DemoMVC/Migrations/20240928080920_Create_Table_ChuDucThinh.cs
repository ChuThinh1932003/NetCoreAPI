using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_ChuDucThinh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChuDucThinh",
                table: "ChuDucThinh");

            migrationBuilder.RenameColumn(
                name: "ChuDucThinhName",
                table: "ChuDucThinh",
                newName: "MSV");

            migrationBuilder.RenameColumn(
                name: "ChuDucThinhID",
                table: "ChuDucThinh",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "ChuDucThinh",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChuDucThinh",
                table: "ChuDucThinh",
                column: "FullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChuDucThinh",
                table: "ChuDucThinh");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "ChuDucThinh");

            migrationBuilder.RenameColumn(
                name: "MSV",
                table: "ChuDucThinh",
                newName: "ChuDucThinhName");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "ChuDucThinh",
                newName: "ChuDucThinhID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChuDucThinh",
                table: "ChuDucThinh",
                column: "ChuDucThinhID");
        }
    }
}
