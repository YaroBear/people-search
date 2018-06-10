using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleSearch.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interest_People_PersonId",
                table: "Interest");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Picture_PictureId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interest",
                table: "Interest");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Picture");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "Interest",
                newName: "Interests");

            migrationBuilder.RenameIndex(
                name: "IX_Interest_PersonId",
                table: "Interests",
                newName: "IX_Interests_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "People",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Pictures",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Interests",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interests",
                table: "Interests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_People_PersonId",
                table: "Interests",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Pictures_PictureId",
                table: "People",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_People_PersonId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Pictures_PictureId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interests",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Pictures");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "Picture");

            migrationBuilder.RenameTable(
                name: "Interests",
                newName: "Interest");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_PersonId",
                table: "Interest",
                newName: "IX_Interest_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "People",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Picture",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Interest",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interest",
                table: "Interest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_People_PersonId",
                table: "Interest",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Picture_PictureId",
                table: "People",
                column: "PictureId",
                principalTable: "Picture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
