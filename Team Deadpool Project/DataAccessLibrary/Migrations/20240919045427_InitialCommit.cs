using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalID = table.Column<string>(type: "char(36)", nullable: false),
                    TankID = table.Column<string>(type: "char(36)", nullable: false),
                    VetID = table.Column<string>(type: "char(36)", nullable: false),
                    SpeciesID = table.Column<string>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalID);
                });

            migrationBuilder.CreateTable(
                name: "Aquariums",
                columns: table => new
                {
                    AquariumID = table.Column<string>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Hours = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aquariums", x => x.AquariumID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<string>(type: "char(36)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestID = table.Column<string>(type: "char(36)", nullable: false),
                    AquariumID = table.Column<string>(type: "char(36)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<string>(type: "char(36)", nullable: false),
                    PositionTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesID = table.Column<string>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Habitat = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Diet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesID);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    TankID = table.Column<string>(type: "char(36)", nullable: false),
                    AquariumID = table.Column<string>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.TankID);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<string>(type: "char(36)", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                });

            migrationBuilder.CreateTable(
                name: "TanksMovements",
                columns: table => new
                {
                    MovementId = table.Column<string>(type: "char(36)", nullable: false),
                    AnimalID = table.Column<string>(type: "char(36)", nullable: false),
                    CurrentTank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastTank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WhenMoved = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TanksMovements", x => x.MovementId);
                    table.ForeignKey(
                        name: "FK_TanksMovements_Animals_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animals",
                        principalColumn: "AnimalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vets",
                columns: table => new
                {
                    VetID = table.Column<string>(type: "char(36)", nullable: false),
                    AquariumID = table.Column<string>(type: "char(36)", nullable: false),
                    ContactInformation = table.Column<string>(type: "char(36)", nullable: false),
                    ContactID = table.Column<string>(type: "char(36)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vets", x => x.VetID);
                    table.ForeignKey(
                        name: "FK_Vets_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    WorkerID = table.Column<string>(type: "char(36)", nullable: false),
                    AquariumID = table.Column<string>(type: "char(36)", nullable: false),
                    ContactInformation = table.Column<string>(type: "char(36)", nullable: false),
                    ContactID = table.Column<string>(type: "char(36)", nullable: false),
                    PositionID = table.Column<string>(type: "char(36)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Years_of_Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.WorkerID);
                    table.ForeignKey(
                        name: "FK_Workers_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestsTickets",
                columns: table => new
                {
                    GuestsTicketsID = table.Column<string>(type: "char(36)", nullable: false),
                    TicketID = table.Column<string>(type: "char(36)", nullable: false),
                    GuestID = table.Column<string>(type: "char(36)", nullable: false),
                    ticketsTicketID = table.Column<string>(type: "char(36)", nullable: false),
                    guestsGuestID = table.Column<string>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestsTickets", x => x.GuestsTicketsID);
                    table.ForeignKey(
                        name: "FK_GuestsTickets_Guests_guestsGuestID",
                        column: x => x.guestsGuestID,
                        principalTable: "Guests",
                        principalColumn: "GuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestsTickets_Tickets_ticketsTicketID",
                        column: x => x.ticketsTicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkersTanks",
                columns: table => new
                {
                    WorkersTanksID = table.Column<string>(type: "char(36)", nullable: false),
                    WorkerID = table.Column<string>(type: "char(36)", nullable: false),
                    TankID = table.Column<string>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkersTanks", x => x.WorkersTanksID);
                    table.ForeignKey(
                        name: "FK_WorkersTanks_Tanks_TankID",
                        column: x => x.TankID,
                        principalTable: "Tanks",
                        principalColumn: "TankID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkersTanks_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "WorkerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuestsTickets_guestsGuestID",
                table: "GuestsTickets",
                column: "guestsGuestID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestsTickets_ticketsTicketID",
                table: "GuestsTickets",
                column: "ticketsTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_TanksMovements_AnimalID",
                table: "TanksMovements",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_Vets_ContactID",
                table: "Vets",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_ContactID",
                table: "Workers",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersTanks_TankID",
                table: "WorkersTanks",
                column: "TankID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersTanks_WorkerID",
                table: "WorkersTanks",
                column: "WorkerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aquariums");

            migrationBuilder.DropTable(
                name: "GuestsTickets");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "TanksMovements");

            migrationBuilder.DropTable(
                name: "Vets");

            migrationBuilder.DropTable(
                name: "WorkersTanks");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Tanks");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
