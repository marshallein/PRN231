using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessObject.Migrations
{
    public partial class initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_Pub_id1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Pub_id1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Pub_id1",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Pub_id",
                table: "Books",
                column: "Pub_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_Pub_id",
                table: "Books",
                column: "Pub_id",
                principalTable: "Publisher",
                principalColumn: "Pub_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_Pub_id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Pub_id",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Pub_id1",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Pub_id1",
                table: "Books",
                column: "Pub_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_Pub_id1",
                table: "Books",
                column: "Pub_id1",
                principalTable: "Publisher",
                principalColumn: "Pub_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
