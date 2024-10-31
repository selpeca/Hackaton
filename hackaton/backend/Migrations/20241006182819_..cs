using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    typeDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    document = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    numMembers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hackaton",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projectId = table.Column<int>(type: "int", nullable: false),
                    ownerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hackaton", x => x.id);
                    table.ForeignKey(
                        name: "FK_Hackaton_People_ownerId",
                        column: x => x.ownerId,
                        principalTable: "People",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mentors_People_personId",
                        column: x => x.personId,
                        principalTable: "People",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profession = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    personId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.id);
                    table.ForeignKey(
                        name: "FK_Participants_People_personId",
                        column: x => x.personId,
                        principalTable: "People",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    position = table.Column<int>(type: "int", nullable: false),
                    prize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hackatonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.id);
                    table.ForeignKey(
                        name: "FK_Awards_Hackaton_hackatonId",
                        column: x => x.hackatonId,
                        principalTable: "Hackaton",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    teamId = table.Column<int>(type: "int", nullable: true),
                    hackatonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.id);
                    table.ForeignKey(
                        name: "FK_Projects_Hackaton_hackatonId",
                        column: x => x.hackatonId,
                        principalTable: "Hackaton",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Projects_Teams_teamId",
                        column: x => x.teamId,
                        principalTable: "Teams",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "MentorsArea",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    area = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    mentorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorsArea", x => x.id);
                    table.ForeignKey(
                        name: "FK_MentorsArea_Mentors_mentorId",
                        column: x => x.mentorId,
                        principalTable: "Mentors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperiencesParticipant",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<int>(type: "int", nullable: false),
                    participantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperiencesParticipant", x => x.id);
                    table.ForeignKey(
                        name: "FK_ExperiencesParticipant_Participants_participantId",
                        column: x => x.participantId,
                        principalTable: "Participants",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantId = table.Column<int>(type: "int", nullable: true),
                    teamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Participants_participantId",
                        column: x => x.participantId,
                        principalTable: "Participants",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_teamId",
                        column: x => x.teamId,
                        principalTable: "Teams",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    judgment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mentorId = table.Column<int>(type: "int", nullable: true),
                    projectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Mentors_mentorId",
                        column: x => x.mentorId,
                        principalTable: "Mentors",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Evaluations_Projects_projectId",
                        column: x => x.projectId,
                        principalTable: "Projects",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Awards_hackatonId",
                table: "Awards",
                column: "hackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_mentorId",
                table: "Evaluations",
                column: "mentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_projectId",
                table: "Evaluations",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperiencesParticipant_participantId",
                table: "ExperiencesParticipant",
                column: "participantId");

            migrationBuilder.CreateIndex(
                name: "IX_Hackaton_ownerId",
                table: "Hackaton",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentors_personId",
                table: "Mentors",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_MentorsArea_mentorId",
                table: "MentorsArea",
                column: "mentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_personId",
                table: "Participants",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_People_document",
                table: "People",
                column: "document",
                unique: true,
                filter: "[document] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_hackatonId",
                table: "Projects",
                column: "hackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_teamId",
                table: "Projects",
                column: "teamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_participantId",
                table: "TeamMembers",
                column: "participantId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_teamId",
                table: "TeamMembers",
                column: "teamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "ExperiencesParticipant");

            migrationBuilder.DropTable(
                name: "MentorsArea");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Hackaton");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
