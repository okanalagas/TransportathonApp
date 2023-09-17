using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportathonApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportationRequestOffers");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "TransportationOffers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "TransportationOffers");

            migrationBuilder.CreateTable(
                name: "TransportationRequestOffers",
                columns: table => new
                {
                    TransportationOfferId = table.Column<int>(type: "int", nullable: false),
                    TransportationRequestId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportationRequestOffers", x => new { x.TransportationOfferId, x.TransportationRequestId });
                    table.ForeignKey(
                        name: "FK_TransportationRequestOffers_TransportationOffers_TransportationOfferId",
                        column: x => x.TransportationOfferId,
                        principalTable: "TransportationOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportationRequestOffers_TransportationRequests_TransportationRequestId",
                        column: x => x.TransportationRequestId,
                        principalTable: "TransportationRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportationRequestOffers_TransportationRequestId",
                table: "TransportationRequestOffers",
                column: "TransportationRequestId");
        }
    }
}
