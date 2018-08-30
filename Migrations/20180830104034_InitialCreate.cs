using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PCParkPickerVN.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cpu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    Socket = table.Column<string>(nullable: true),
                    OperatingFrequency = table.Column<float>(nullable: false),
                    BoostFrequency = table.Column<float>(nullable: false),
                    CoresCount = table.Column<int>(nullable: false),
                    L1DataCache = table.Column<int>(nullable: false),
                    L1InstructionCache = table.Column<int>(nullable: false),
                    L2Cache = table.Column<int>(nullable: false),
                    L3Cache = table.Column<int>(nullable: false),
                    Lithography = table.Column<int>(nullable: false),
                    TDP = table.Column<int>(nullable: false),
                    MaxMemorySupported = table.Column<int>(nullable: false),
                    IsHyperthreaded = table.Column<bool>(nullable: false),
                    IsCpuCoolerIncluded = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cpu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MerchantName = table.Column<string>(nullable: true),
                    MerchantLinkReference = table.Column<string>(nullable: true),
                    BasePrice = table.Column<float>(nullable: false),
                    ShippingFee = table.Column<float>(nullable: false),
                    Promo = table.Column<float>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    PartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_price", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cpu");

            migrationBuilder.DropTable(
                name: "price");
        }
    }
}
