using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice_DataAccessLayer.Migrations
{
    public partial class dbrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_colleges_students_StudentID",
                table: "colleges");

            migrationBuilder.DropIndex(
                name: "IX_colleges_StudentID",
                table: "colleges");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "colleges");

            migrationBuilder.AddColumn<int>(
                name: "CollegeID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "CollegeID",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "colleges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_colleges_StudentID",
                table: "colleges",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_colleges_students_StudentID",
                table: "colleges",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
