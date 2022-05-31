using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessObject.Migrations
{
    public partial class initial_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Author_Author_id1",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_Book_id1",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publisher_Pub_id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Role_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_Author_id1",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_Book_id1",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "Author_id1",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "Book_id1",
                table: "BookAuthors");

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

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_Book_id",
                table: "BookAuthors",
                column: "Book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Author_Author_id",
                table: "BookAuthors",
                column: "Author_id",
                principalTable: "Author",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_Book_id",
                table: "BookAuthors",
                column: "Book_id",
                principalTable: "Books",
                principalColumn: "Book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publisher_Pub_id",
                table: "Users",
                column: "Pub_id",
                principalTable: "Publisher",
                principalColumn: "Pub_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Role_id",
                table: "Users",
                column: "Role_id",
                principalTable: "Roles",
                principalColumn: "Role_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Author_Author_id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_Book_id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publisher_Pub_id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Role_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_Book_id",
                table: "BookAuthors");

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

            migrationBuilder.AddColumn<int>(
                name: "Author_id1",
                table: "BookAuthors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Book_id1",
                table: "BookAuthors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_Author_id1",
                table: "BookAuthors",
                column: "Author_id1");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_Book_id1",
                table: "BookAuthors",
                column: "Book_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Author_Author_id1",
                table: "BookAuthors",
                column: "Author_id1",
                principalTable: "Author",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_Book_id1",
                table: "BookAuthors",
                column: "Book_id1",
                principalTable: "Books",
                principalColumn: "Book_id",
                onDelete: ReferentialAction.Restrict);

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
