using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSGC.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "psgc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PSGCCode = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CorrespondenceCode = table.Column<string>(type: "TEXT", nullable: true),
                    GeographicLevel = table.Column<string>(type: "TEXT", nullable: false),
                    OldNames = table.Column<string>(type: "TEXT", nullable: true),
                    CityClass = table.Column<string>(type: "TEXT", nullable: true),
                    IncomeClassification = table.Column<string>(type: "TEXT", nullable: true),
                    Population = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    RegionCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProvincialCode = table.Column<string>(type: "TEXT", nullable: false),
                    MunicipalCode = table.Column<string>(type: "TEXT", nullable: false),
                    BarangayCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_psgc", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "psgc");
        }
    }
}
