using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice_DataAccessLayer.Migrations
{
    public partial class key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_students_CollegeID",
                table: "students",
                column: "CollegeID");

            migrationBuilder.AddForeignKey(
                name: "FK_students_colleges_CollegeID",
                table: "students",
                column: "CollegeID",
                principalTable: "colleges",
                principalColumn: "CollegeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_colleges_CollegeID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_CollegeID",
                table: "students");
        }
    }
}
