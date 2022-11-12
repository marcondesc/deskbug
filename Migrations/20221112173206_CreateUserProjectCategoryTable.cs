using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Deskbug.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserProjectCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    displayorder = table.Column<int>(name: "display_order", type: "int", nullable: false),
                    categorylevel = table.Column<int>(name: "category_level", type: "int", nullable: false),
                    categoryreference = table.Column<int>(name: "category_reference", type: "int", nullable: false),
                    createddate = table.Column<DateTime>(name: "created_date", type: "DateTime", nullable: false),
                    categorystatus = table.Column<int>(name: "category_status", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    shortname = table.Column<string>(name: "short_name", type: "nvarchar(50)", nullable: false),
                    projectcolor = table.Column<string>(name: "project_color", type: "nvarchar(7)", nullable: false),
                    createddate = table.Column<DateTime>(name: "created_date", type: "DateTime", nullable: false),
                    projectstatus = table.Column<int>(name: "project_status", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(name: "full_name", type: "nvarchar(150)", nullable: false),
                    username = table.Column<string>(name: "user_name", type: "nvarchar(50)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    token = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    tokendate = table.Column<DateTime>(name: "token_date", type: "DateTime", nullable: false),
                    userstatus = table.Column<int>(name: "user_status", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "project");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
