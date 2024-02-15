using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _02_Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    InstallationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DeviceType = table.Column<int>(type: "integer", nullable: false),
                    Payload = table.Column<string>(type: "jsonb", nullable: false, defaultValueSql: "'{}'::jsonb")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDevices",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Alias = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDevices", x => new { x.DeviceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserDevices_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "DeviceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupUserDevice",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserDevicesDeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserDevicesUserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUserDevice", x => new { x.GroupId, x.UserDevicesDeviceId, x.UserDevicesUserId });
                    table.ForeignKey(
                        name: "FK_GroupUserDevice_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUserDevice_UserDevices_UserDevicesDeviceId_UserDevices~",
                        columns: x => new { x.UserDevicesDeviceId, x.UserDevicesUserId },
                        principalTable: "UserDevices",
                        principalColumns: new[] { "DeviceId", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "DeviceType", "InstallationId", "Name", "Payload" },
                values: new object[,]
                {
                    { new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "ardella.net", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"0527c550-1bc1-efb2-b041-0565e42a3ea4\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "kris.name", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"08991fac-4a35-03c9-be3e-eb82b5f50bb5\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "candido.name", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"1b3bdf5c-ab3f-f233-a231-a953b0110105\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "tiara.biz", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"264c2e76-e3aa-9112-54bf-90ee23b78f43\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "hailey.com", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"55242e0d-0559-bdc0-d674-7a54773f6fdb\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "kaelyn.net", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"5ecbeeec-2e75-254e-61b1-55e8d4eda3bd\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "andy.net", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"66c6d7c7-9a93-928e-8a72-a07a49ef77d7\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "mabel.biz", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"66f98c5c-14ac-dd24-bbf8-8dae4db00793\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"), 1, new Guid("00000000-0000-0000-0000-000000000000"), "allie.info", "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"91f224e3-cb0c-3b9f-599a-2a11704aa833\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), "Peru", new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), "Cocos (Keeling) Islands", new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), "Czech Republic", new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") }
                });

            migrationBuilder.InsertData(
                table: "UserDevices",
                columns: new[] { "DeviceId", "UserId", "Alias" },
                values: new object[,]
                {
                    { new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "ardella.net" },
                    { new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "kris.name" },
                    { new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "candido.name" },
                    { new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "tiara.biz" },
                    { new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "hailey.com" },
                    { new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "kaelyn.net" },
                    { new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "andy.net" },
                    { new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "mabel.biz" },
                    { new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "allie.info" }
                });

            migrationBuilder.InsertData(
                table: "GroupUserDevice",
                columns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                values: new object[,]
                {
                    { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupUserDevice_UserDevicesDeviceId_UserDevicesUserId",
                table: "GroupUserDevice",
                columns: new[] { "UserDevicesDeviceId", "UserDevicesUserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupUserDevice");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "UserDevices");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
