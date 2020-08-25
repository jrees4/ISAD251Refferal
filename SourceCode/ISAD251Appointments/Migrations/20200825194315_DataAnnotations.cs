using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISAD251Appointments.Migrations
{
    public partial class DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentName = table.Column<string>(maxLength: 100, nullable: false),
                    AppointmentDescription = table.Column<string>(maxLength: 255, nullable: true),
                    AppointmentTarget = table.Column<string>(maxLength: 255, nullable: false),
                    AppointmentTime = table.Column<DateTime>(nullable: false),
                    AppointmentNote = table.Column<string>(maxLength: 400, nullable: true),
                    AppointmentIsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
