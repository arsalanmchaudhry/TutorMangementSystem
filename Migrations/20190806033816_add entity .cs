using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorMangementSystem.Migrations
{
    public partial class addentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberIDId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_MemberIDId",
                table: "Students",
                column: "MemberIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_MemberIDs_MemberIDId",
                table: "Students",
                column: "MemberIDId",
                principalTable: "MemberIDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_MemberIDs_MemberIDId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_MemberIDId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MemberIDId",
                table: "Students");
        }
    }
}
