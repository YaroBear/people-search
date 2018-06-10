using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleSearch.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pictures (FileName) VALUES('john_smith.jpg')");
            migrationBuilder.Sql("INSERT INTO Pictures (FileName) VALUES('betty_jones.jpg')");
            migrationBuilder.Sql("INSERT INTO Pictures (FileName) VALUES('mike_robbins.jpg')");

            migrationBuilder.Sql("INSERT INTO People (Name, Age, Address, PictureId) VALUES ('John Smith', 25, '1234 Wasatch Blvd', (SELECT Id FROM Pictures WHERE FileName = 'john_smith.jpg'))");
            migrationBuilder.Sql("INSERT INTO People (Name, Age, Address, PictureId) VALUES ('Betty Jones', 40, '5000 State Street', (SELECT Id FROM Pictures WHERE FileName = 'betty_jones.jpg'))");
            migrationBuilder.Sql("INSERT INTO People (Name, Age, Address, PictureId) VALUES ('Mike Robbins', 30, '9000 Main Street', (SELECT Id FROM Pictures WHERE FileName = 'mike_robbins.jpg'))");

            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Skiing', (SELECT Id FROM People WHERE Name = 'John Smith'))");
            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Hiking', (SELECT Id FROM People WHERE Name = 'John Smith'))");
            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Biking', (SELECT Id FROM People WHERE Name = 'John Smith'))");

            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Skiing', (SELECT Id FROM People WHERE Name = 'Betty Jones'))");
            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Rock climbing', (SELECT Id FROM People WHERE Name = 'Betty Jones'))");

            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Singing', (SELECT Id FROM People WHERE Name = 'Mike Robbins'))");
            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Dancing', (SELECT Id FROM People WHERE Name = 'Mike Robbins'))");
            migrationBuilder.Sql("INSERT INTO Interests (Name, PersonId) VALUES ('Playing jazz piano', (SELECT Id FROM People WHERE Name = 'Mike Robbins'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM People");
            migrationBuilder.Sql("DELETE FROM Interests");
            migrationBuilder.Sql("DELETE FROM Pictures");
        }
    }
}
