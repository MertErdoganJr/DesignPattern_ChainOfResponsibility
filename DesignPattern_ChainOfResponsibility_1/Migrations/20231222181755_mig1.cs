using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern_ChainOfResponsibility_1.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerProccesses",
                columns: table => new
                {
                    CustomerProccessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProccesses", x => x.CustomerProccessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProccesses");
        }
    }
}
