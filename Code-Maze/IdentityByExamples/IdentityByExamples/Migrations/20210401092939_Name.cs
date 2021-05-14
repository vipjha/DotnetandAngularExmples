using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2e00879-8d38-495e-b582-5ccaa35cdb01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9c95b65-046f-456a-9f77-f12d30a5e954");

            migrationBuilder.RenameColumn(
                name: "LastNamr",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cb5273a-f295-41b8-a841-1a0ce7113f30", "e0419f47-27ac-48b1-969a-96fbe5133758", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d393f9db-afc3-415f-9c90-ee68154a629f", "4f72ba54-4dd6-4430-b9ad-875af2dcada1", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cb5273a-f295-41b8-a841-1a0ce7113f30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d393f9db-afc3-415f-9c90-ee68154a629f");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LastNamr");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9c95b65-046f-456a-9f77-f12d30a5e954", "bad5ee2b-64e6-4d30-8377-1618b3cd6804", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2e00879-8d38-495e-b582-5ccaa35cdb01", "7d13ca4e-8436-4a0f-968a-86a1f9e0c8b5", "Administrator", "ADMINISTRATOR" });
        }
    }
}
