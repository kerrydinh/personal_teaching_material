using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KerryExample.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData("User", new string[] { "Id", "FirstName", "LastName", "UserName", "Password", "Email", "BirthDay", "Gender" },
                new string[] { Guid.NewGuid().ToString(), "John", "Terry", "john", "123456", "j.terry@gmail.com", "10/10/1990", "1" });

            migrationBuilder.InsertData("User", new string[] { "Id", "FirstName", "LastName", "UserName", "Password", "Email", "BirthDay", "Gender" },
                new string[] { Guid.NewGuid().ToString(), "Suzuki", "Mei", "suzu", "123456", "s.mei@gmail.com", "10/10/1989", "2" });

            migrationBuilder.InsertData("User", new string[] { "Id", "FirstName", "LastName", "UserName", "Password", "Email", "BirthDay", "Gender" },
                new string[] { Guid.NewGuid().ToString(), "Hori", "Tanaka", "hori12", "123456", "hori_tanaka123@gmail.com", "10/10/1978", "2" });

            migrationBuilder.InsertData("User", new string[] { "Id", "FirstName", "LastName", "UserName", "Password", "Email", "BirthDay", "Gender" },
                new string[] { Guid.NewGuid().ToString(), "Key", "Tom", "key.tom", "123456", "tomkeyz991@gmail.com", "10/12/1990", "1" });

            migrationBuilder.InsertData("User", new string[] { "Id", "FirstName", "LastName", "UserName", "Password", "Email", "BirthDay", "Gender" },
                new string[] { Guid.NewGuid().ToString(), "Viet", "Nguyen", "viet.nguyen", "123456", "v_nguyen_bamboo@gmail.com", "10/10/1992", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
