using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVideoGamePortal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GamerInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PreferredVideoGame = table.Column<string>(maxLength: 250, nullable: true),
                    GamesPurchased = table.Column<string>(nullable: true),
                    FavGame = table.Column<string>(maxLength: 250, nullable: true),
                    DateJoined = table.Column<DateTime>(nullable: true),
                    IsActiveCustomer = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamerInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VideoGame",
                columns: table => new
                {
                    VideoGameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Version = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    MemorySpace = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    IsSportsGame = table.Column<bool>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGame", x => x.VideoGameID);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    PurchaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountPaid = table.Column<decimal>(nullable: false),
                    ModeOfTransaction = table.Column<string>(nullable: true),
                    GamerID = table.Column<int>(nullable: false),
                    GamerInfoID = table.Column<int>(nullable: true),
                    VideoGameID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.PurchaseID);
                    table.ForeignKey(
                        name: "FK_Purchase_GamerInfo_GamerInfoID",
                        column: x => x.GamerInfoID,
                        principalTable: "GamerInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchase_VideoGame_VideoGameID",
                        column: x => x.VideoGameID,
                        principalTable: "VideoGame",
                        principalColumn: "VideoGameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_GamerInfoID",
                table: "Purchase",
                column: "GamerInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_VideoGameID",
                table: "Purchase",
                column: "VideoGameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "GamerInfo");

            migrationBuilder.DropTable(
                name: "VideoGame");
        }
    }
}
