using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorMangementSystem.Migrations
{
    public partial class addentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MemberIDs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Balance = table.Column<decimal>(nullable: false),
                    CardIssued = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberIDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    OfficeIMG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReserveOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeHours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfficeId = table.Column<int>(nullable: true),
                    DayOfWeek = table.Column<int>(nullable: false),
                    OpenTime = table.Column<int>(nullable: false),
                    CloseTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficeHours_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TutorName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: false),
                    ReserveOptionId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    TutorIMG = table.Column<string>(nullable: true),
                    available = table.Column<string>(nullable: true),
                    OfficeLocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutors_Offices_OfficeLocationId",
                        column: x => x.OfficeLocationId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutors_ReserveOptions_ReserveOptionId",
                        column: x => x.ReserveOptionId,
                        principalTable: "ReserveOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TutorId = table.Column<int>(nullable: false),
                    MemberIdId = table.Column<int>(nullable: false),
                    ReservedSince = table.Column<DateTime>(nullable: false),
                    AvailiableSince = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registers_MemberIDs_MemberIdId",
                        column: x => x.MemberIdId,
                        principalTable: "MemberIDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registers_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TutorId = table.Column<int>(nullable: false),
                    MemberIDId = table.Column<int>(nullable: true),
                    ReservedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserves_MemberIDs_MemberIDId",
                        column: x => x.MemberIDId,
                        principalTable: "MemberIDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserves_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TutorId = table.Column<int>(nullable: true),
                    MemberIDId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_MemberIDs_MemberIDId",
                        column: x => x.MemberIDId,
                        principalTable: "MemberIDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishlists_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_OfficeId",
                table: "Students",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeHours_OfficeId",
                table: "OfficeHours",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Registers_MemberIdId",
                table: "Registers",
                column: "MemberIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Registers_TutorId",
                table: "Registers",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserves_MemberIDId",
                table: "Reserves",
                column: "MemberIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserves_TutorId",
                table: "Reserves",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_OfficeLocationId",
                table: "Tutors",
                column: "OfficeLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_ReserveOptionId",
                table: "Tutors",
                column: "ReserveOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_MemberIDId",
                table: "Wishlists",
                column: "MemberIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_TutorId",
                table: "Wishlists",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Offices_OfficeId",
                table: "Students",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Offices_OfficeId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "OfficeHours");

            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "MemberIDs");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "ReserveOptions");

            migrationBuilder.DropIndex(
                name: "IX_Students_OfficeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Students");
        }
    }
}
