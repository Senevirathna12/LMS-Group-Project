using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrpProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dbstudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegNo = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    GPA = table.Column<double>(type: "REAL", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: false),
                    Batch = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Project = table.Column<string>(type: "TEXT", nullable: false),
                    Gui = table.Column<string>(type: "TEXT", nullable: false),
                    Signal = table.Column<string>(type: "TEXT", nullable: false),
                    Acon = table.Column<string>(type: "TEXT", nullable: false),
                    Maths = table.Column<string>(type: "TEXT", nullable: false),
                    Analog = table.Column<string>(type: "TEXT", nullable: false),
                    Elec = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dbstudent", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dbstudent");
        }
    }
}
