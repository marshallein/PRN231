using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessObject.Migrations
{
    public partial class initial_ver_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publisher_Pub_id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Role_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Pub_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Role_id",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Role_id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pub_id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pub_id1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role_id1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Pub_id1",
                table: "Users",
                column: "Pub_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_id1",
                table: "Users",
                column: "Role_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publisher_Pub_id1",
                table: "Users",
                column: "Pub_id1",
                principalTable: "Publisher",
                principalColumn: "Pub_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Role_id1",
                table: "Users",
                column: "Role_id1",
                principalTable: "Roles",
                principalColumn: "Role_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publisher_Pub_id1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Role_id1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Pub_id1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Role_id1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Pub_id1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role_id1",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Role_id",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Pub_id",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Pub_id",
                table: "Users",
                column: "Pub_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_id",
                table: "Users",
                column: "Role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publisher_Pub_id",
                table: "Users",
                column: "Pub_id",
                principalTable: "Publisher",
                principalColumn: "Pub_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Role_id",
                table: "Users",
                column: "Role_id",
                principalTable: "Roles",
                principalColumn: "Role_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
