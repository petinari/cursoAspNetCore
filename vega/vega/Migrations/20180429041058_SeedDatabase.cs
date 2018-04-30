using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into \"Makes\" (\"Name\") values ('make1')");
            migrationBuilder.Sql("insert into \"Makes\" (\"Name\") values ('make2')");
            migrationBuilder.Sql("insert into \"Makes\" (\"Name\") values ('make3')");
            migrationBuilder.Sql("insert into \"Makes\" (\"Name\") values ('make4')");
            migrationBuilder.Sql("insert into \"Makes\" (\"Name\") values ('make5')");
            migrationBuilder.Sql("insert into \"Makes\" (\"Name\") values ('make6')");


            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make1-modelA',(select \"Id\" from \"Makes\" where \"Name\" = 'make1'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make1-modelB',(select \"Id\" from \"Makes\" where \"Name\" = 'make1'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make2-modelA',(select \"Id\" from \"Makes\" where \"Name\" = 'make2'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make2-modelB',(select \"Id\" from \"Makes\" where \"Name\" = 'make2'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make3-modelA',(select \"Id\" from \"Makes\" where \"Name\" = 'make3'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make3-modelB',(select \"Id\" from \"Makes\" where \"Name\" = 'make3'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make4-modelA',(select \"Id\" from \"Makes\" where \"Name\" = 'make4'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make4-modelB',(select \"Id\" from \"Makes\" where \"Name\" = 'make4'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make5-modelA',(select \"Id\" from \"Makes\" where \"Name\" = 'make5'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make5-modelB',(select \"Id\" from \"Makes\" where \"Name\" = 'make5'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make6-modelA',(select \"Id\" from \"Makes\" where \"Name\" = 'make6'))");
            migrationBuilder.Sql("insert into \"Models\" (\"Name\", \"MakeId\") values ('make6-modelB',(select \"Id\" from \"Makes\" where \"Name\" = 'make6'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from  \"Makes\" where \"Name\" in ('make1', 'make2', 'make3', 'make4', 'make5','make6')");
        
        }
    }
}
