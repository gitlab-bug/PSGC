using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSGC.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeoDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PSGCCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    GeographicLevel = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    OldName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    RegionCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    ProvinceCode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    MunicipalityCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    BarangayCode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeoDatas");
        }
    }
}
