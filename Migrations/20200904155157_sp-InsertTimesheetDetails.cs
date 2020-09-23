using Microsoft.EntityFrameworkCore.Migrations;

namespace TimesheetService.Migrations
{
    public partial class spInsertTimesheetDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[sp_InsertTimesheetDetails]
                    @FirstName varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Students where FirstName like @FirstName +'%'
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
