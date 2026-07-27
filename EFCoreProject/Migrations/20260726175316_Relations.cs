using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorksOns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmants",
                table: "Departmants");

            migrationBuilder.DropColumn(
                name: "ProjectNumber",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "EmployeeAddress",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeBdate",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeLname",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeMinit",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeSex",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DependentBirthdate",
                table: "dependents");

            migrationBuilder.DropColumn(
                name: "DependentSex",
                table: "dependents");

            migrationBuilder.DropColumn(
                name: "Relationship",
                table: "dependents");

            migrationBuilder.RenameTable(
                name: "Departmants",
                newName: "departments");

            migrationBuilder.RenameColumn(
                name: "Employeename",
                table: "employees",
                newName: "EmpName");

            migrationBuilder.RenameColumn(
                name: "NumberOfEmployees",
                table: "departments",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeAge",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "dependents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "DepartmentId");

            migrationBuilder.CreateTable(
                name: "empProjs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empProjs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empProjs_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empProjs_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentID",
                table: "employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_SupervisorID",
                table: "employees",
                column: "SupervisorID");

            migrationBuilder.CreateIndex(
                name: "IX_dependents_EmployeeId",
                table: "dependents",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_EmployeeId",
                table: "departments",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empProjs_EmployeeId",
                table: "empProjs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_empProjs_ProjectId",
                table: "empProjs",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_EmployeeId",
                table: "departments",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dependents_employees_EmployeeId",
                table: "dependents",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentID",
                table: "employees",
                column: "DepartmentID",
                principalTable: "departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_employees_SupervisorID",
                table: "employees",
                column: "SupervisorID",
                principalTable: "employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_EmployeeId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_dependents_employees_EmployeeId",
                table: "dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_employees_SupervisorID",
                table: "employees");

            migrationBuilder.DropTable(
                name: "empProjs");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_SupervisorID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_dependents_EmployeeId",
                table: "dependents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_EmployeeId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeAge",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "SupervisorID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "dependents");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Departmants");

            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "employees",
                newName: "Employeename");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Departmants",
                newName: "NumberOfEmployees");

            migrationBuilder.AddColumn<int>(
                name: "ProjectNumber",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeAddress",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeBdate",
                table: "employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmployeeLname",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMinit",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeSex",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DependentBirthdate",
                table: "dependents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DependentSex",
                table: "dependents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Relationship",
                table: "dependents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmants",
                table: "Departmants",
                column: "DepartmentId");

            migrationBuilder.CreateTable(
                name: "WorksOns",
                columns: table => new
                {
                    WorkOnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorksOns", x => x.WorkOnId);
                });
        }
    }
}
