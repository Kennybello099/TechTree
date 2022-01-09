using Microsoft.EntityFrameworkCore.Migrations;

namespace TechTreeMVC.Data.Migrations
{
    public partial class Add_Description_to_CategoryItem_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CategoryItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CategoryItems");
        }
    }
}
