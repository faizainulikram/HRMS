using Microsoft.EntityFrameworkCore.Migrations;

namespace BIA.Dashboard.Template.Migrations
{
    public partial class Migration095670 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FilesOnFileSystem",
                table: "FilesOnFileSystem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilesOnDatabase",
                table: "FilesOnDatabase");

            migrationBuilder.RenameTable(
                name: "FilesOnFileSystem",
                newName: "FileOnFileSystemModel");

            migrationBuilder.RenameTable(
                name: "FilesOnDatabase",
                newName: "FileOnDatabaseMode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileOnFileSystemModel",
                table: "FileOnFileSystemModel",
                column: "FileAttachmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileOnDatabaseMode",
                table: "FileOnDatabaseMode",
                column: "FileAttachmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FileOnFileSystemModel",
                table: "FileOnFileSystemModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileOnDatabaseMode",
                table: "FileOnDatabaseMode");

            migrationBuilder.RenameTable(
                name: "FileOnFileSystemModel",
                newName: "FilesOnFileSystem");

            migrationBuilder.RenameTable(
                name: "FileOnDatabaseMode",
                newName: "FilesOnDatabase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilesOnFileSystem",
                table: "FilesOnFileSystem",
                column: "FileAttachmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilesOnDatabase",
                table: "FilesOnDatabase",
                column: "FileAttachmentId");
        }
    }
}
