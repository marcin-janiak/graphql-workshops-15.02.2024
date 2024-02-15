using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _02_Database.Migrations
{
    /// <inheritdoc />
    public partial class Thermometer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"), new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"), new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"), new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"));

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"));

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "DeviceType", "InstallationId", "Name", "Payload" },
                values: new object[,]
                {
                    { new Guid("0197cc7b-e64d-e562-ebf7-7af1d33993eb"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "lelah.biz", "{\"$\":\"Thermometer\",\"DeviceId\":\"0197cc7b-e64d-e562-ebf7-7af1d33993eb\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("02b38e71-42b7-29ae-47a0-49ac20a68cd8"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "bernie.biz", "{\"$\":\"Thermometer\",\"DeviceId\":\"02b38e71-42b7-29ae-47a0-49ac20a68cd8\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("066d814c-ccee-4564-ab76-904cd6270f08"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "leopold.info", "{\"$\":\"Thermometer\",\"DeviceId\":\"066d814c-ccee-4564-ab76-904cd6270f08\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("11f94ef4-83ca-9a69-440e-d4deb91de2e3"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "manuela.biz", "{\"$\":\"Thermometer\",\"DeviceId\":\"11f94ef4-83ca-9a69-440e-d4deb91de2e3\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("66eab3b8-57e9-7913-8214-a9f2e5deaf24"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "nestor.name", "{\"$\":\"Thermometer\",\"DeviceId\":\"66eab3b8-57e9-7913-8214-a9f2e5deaf24\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("8b5cd8f5-b94e-1307-a0d9-21e474199943"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "marques.info", "{\"$\":\"Thermometer\",\"DeviceId\":\"8b5cd8f5-b94e-1307-a0d9-21e474199943\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("bb867d7f-3d37-c6d4-1885-3984dd3cdda9"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "ilene.name", "{\"$\":\"Thermometer\",\"DeviceId\":\"bb867d7f-3d37-c6d4-1885-3984dd3cdda9\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("e84e8b78-400b-1a75-3cfc-8a9dec836df8"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "gene.name", "{\"$\":\"Thermometer\",\"DeviceId\":\"e84e8b78-400b-1a75-3cfc-8a9dec836df8\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" },
                    { new Guid("fcaa94ae-c920-7af4-2ba2-fba0b11247fd"), 3, new Guid("00000000-0000-0000-0000-000000000000"), "gwen.info", "{\"$\":\"Thermometer\",\"DeviceId\":\"fcaa94ae-c920-7af4-2ba2-fba0b11247fd\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), "Belarus", new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), "Lithuania", new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), "Cocos (Keeling) Islands", new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") }
                });

            migrationBuilder.InsertData(
                table: "UserDevices",
                columns: new[] { "DeviceId", "UserId", "Alias" },
                values: new object[,]
                {
                    { new Guid("0197cc7b-e64d-e562-ebf7-7af1d33993eb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "lelah.biz" },
                    { new Guid("02b38e71-42b7-29ae-47a0-49ac20a68cd8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "bernie.biz" },
                    { new Guid("066d814c-ccee-4564-ab76-904cd6270f08"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "leopold.info" },
                    { new Guid("11f94ef4-83ca-9a69-440e-d4deb91de2e3"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "manuela.biz" },
                    { new Guid("66eab3b8-57e9-7913-8214-a9f2e5deaf24"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "nestor.name" },
                    { new Guid("8b5cd8f5-b94e-1307-a0d9-21e474199943"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "marques.info" },
                    { new Guid("bb867d7f-3d37-c6d4-1885-3984dd3cdda9"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "ilene.name" },
                    { new Guid("e84e8b78-400b-1a75-3cfc-8a9dec836df8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "gene.name" },
                    { new Guid("fcaa94ae-c920-7af4-2ba2-fba0b11247fd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"), "gwen.info" }
                });

            migrationBuilder.InsertData(
                table: "GroupUserDevice",
                columns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                values: new object[,]
                {
                    { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), new Guid("0197cc7b-e64d-e562-ebf7-7af1d33993eb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), new Guid("11f94ef4-83ca-9a69-440e-d4deb91de2e3"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), new Guid("8b5cd8f5-b94e-1307-a0d9-21e474199943"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), new Guid("066d814c-ccee-4564-ab76-904cd6270f08"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), new Guid("e84e8b78-400b-1a75-3cfc-8a9dec836df8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), new Guid("fcaa94ae-c920-7af4-2ba2-fba0b11247fd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), new Guid("02b38e71-42b7-29ae-47a0-49ac20a68cd8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), new Guid("66eab3b8-57e9-7913-8214-a9f2e5deaf24"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") },
                    { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), new Guid("bb867d7f-3d37-c6d4-1885-3984dd3cdda9"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), new Guid("0197cc7b-e64d-e562-ebf7-7af1d33993eb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), new Guid("11f94ef4-83ca-9a69-440e-d4deb91de2e3"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"), new Guid("8b5cd8f5-b94e-1307-a0d9-21e474199943"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), new Guid("066d814c-ccee-4564-ab76-904cd6270f08"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), new Guid("e84e8b78-400b-1a75-3cfc-8a9dec836df8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"), new Guid("fcaa94ae-c920-7af4-2ba2-fba0b11247fd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), new Guid("02b38e71-42b7-29ae-47a0-49ac20a68cd8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), new Guid("66eab3b8-57e9-7913-8214-a9f2e5deaf24"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "GroupUserDevice",
                keyColumns: new[] { "GroupId", "UserDevicesDeviceId", "UserDevicesUserId" },
                keyValues: new object[] { new Guid("edf0867e-c3a1-29b3-2070-6884af130704"), new Guid("bb867d7f-3d37-c6d4-1885-3984dd3cdda9"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4357bedd-20db-25d5-c7a8-22fd641151e6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6ba61df8-caf1-974e-0d63-891e2cac8056"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("edf0867e-c3a1-29b3-2070-6884af130704"));

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("0197cc7b-e64d-e562-ebf7-7af1d33993eb"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("02b38e71-42b7-29ae-47a0-49ac20a68cd8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("066d814c-ccee-4564-ab76-904cd6270f08"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("11f94ef4-83ca-9a69-440e-d4deb91de2e3"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("66eab3b8-57e9-7913-8214-a9f2e5deaf24"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("8b5cd8f5-b94e-1307-a0d9-21e474199943"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("bb867d7f-3d37-c6d4-1885-3984dd3cdda9"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("e84e8b78-400b-1a75-3cfc-8a9dec836df8"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "UserDevices",
                keyColumns: new[] { "DeviceId", "UserId" },
                keyValues: new object[] { new Guid("fcaa94ae-c920-7af4-2ba2-fba0b11247fd"), new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad") });

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("0197cc7b-e64d-e562-ebf7-7af1d33993eb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("02b38e71-42b7-29ae-47a0-49ac20a68cd8"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("066d814c-ccee-4564-ab76-904cd6270f08"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("11f94ef4-83ca-9a69-440e-d4deb91de2e3"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("66eab3b8-57e9-7913-8214-a9f2e5deaf24"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("8b5cd8f5-b94e-1307-a0d9-21e474199943"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("bb867d7f-3d37-c6d4-1885-3984dd3cdda9"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("e84e8b78-400b-1a75-3cfc-8a9dec836df8"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("fcaa94ae-c920-7af4-2ba2-fba0b11247fd"));

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
        }
    }
}
