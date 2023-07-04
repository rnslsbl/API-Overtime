﻿// <auto-generated />
using System;
using API_Overtime.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Overtime.Migrations
{
    [DbContext(typeof(PayrollOvertimeContext))]
    [Migration("20230623172707_updatepsositionattributtable")]
    partial class updatepsositionattributtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_Overtime.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Employee_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employee_id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id")
                        .IsUnique();

                    b.ToTable("tb_m_accounts");
                });

            modelBuilder.Entity("API_Overtime.Models.AccountRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Account_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("account_id");

                    b.Property<Guid>("Role_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("Account_id");

                    b.HasIndex("Role_id");

                    b.ToTable("tb_tr_accountRoles");
                });

            modelBuilder.Entity("API_Overtime.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_departments");
                });

            modelBuilder.Entity("API_Overtime.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("birth_date");

                    b.Property<Guid>("Department_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("department_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<Guid>("EmployeeLevel_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employeeLevel_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .HasColumnName("gender");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("hiring_date");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("last_name");

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasColumnType("nchar(6)")
                        .HasColumnName("nik");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<Guid?>("ReportTo")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("reportTo");

                    b.HasKey("Id");

                    b.HasIndex("Department_id");

                    b.HasIndex("EmployeeLevel_id");

                    b.HasIndex("NIK", "Email", "PhoneNumber")
                        .IsUnique();

                    b.ToTable("tb_m_employees");
                });

            modelBuilder.Entity("API_Overtime.Models.EmployeeLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Allowence")
                        .HasColumnType("int")
                        .HasColumnName("allowence");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("level");

                    b.Property<int>("Salary")
                        .HasColumnType("int")
                        .HasColumnName("salary");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("tb_m_employeeLevels");
                });

            modelBuilder.Entity("API_Overtime.Models.Overtime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("deskripsi");

                    b.Property<Guid>("Employee_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("End_Overtime")
                        .HasColumnType("datetime2")
                        .HasColumnName("endOvertime");

                    b.Property<int>("Paid")
                        .HasColumnType("int")
                        .HasColumnName("Paid");

                    b.Property<DateTime>("Start_Overtime")
                        .HasColumnType("datetime2")
                        .HasColumnName("startOvertime");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("submitDate");

                    b.Property<int>("Tipe")
                        .HasColumnType("int")
                        .HasColumnName("tipe");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.ToTable("tb_m_overtimes");
                });

            modelBuilder.Entity("API_Overtime.Models.Payroll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Employee_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("payDate");

                    b.Property<int>("PayrollCuts")
                        .HasColumnType("int")
                        .HasColumnName("payrollCut");

                    b.Property<int>("TotalSalary")
                        .HasColumnType("int")
                        .HasColumnName("totalSalary");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.ToTable("tb_tr_payrolls");
                });

            modelBuilder.Entity("API_Overtime.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f147a695-1a4f-4960-bffc-08db60bf618f"),
                            Name = "Employee"
                        },
                        new
                        {
                            Id = new Guid("c22a20c5-0149-41fd-bffd-08db60bf618f"),
                            Name = "Manager"
                        },
                        new
                        {
                            Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("API_Overtime.Models.Account", b =>
                {
                    b.HasOne("API_Overtime.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("API_Overtime.Models.Account", "Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API_Overtime.Models.AccountRole", b =>
                {
                    b.HasOne("API_Overtime.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("Account_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Overtime.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API_Overtime.Models.Employee", b =>
                {
                    b.HasOne("API_Overtime.Models.Department", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("Department_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Overtime.Models.EmployeeLevel", "EmployeeLevel")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeLevel_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("EmployeeLevel");
                });

            modelBuilder.Entity("API_Overtime.Models.Overtime", b =>
                {
                    b.HasOne("API_Overtime.Models.Employee", "Employee")
                        .WithMany("Overtimes")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API_Overtime.Models.Payroll", b =>
                {
                    b.HasOne("API_Overtime.Models.Employee", "Employee")
                        .WithMany("Payrolls")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API_Overtime.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("API_Overtime.Models.Department", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API_Overtime.Models.Employee", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("Overtimes");

                    b.Navigation("Payrolls");
                });

            modelBuilder.Entity("API_Overtime.Models.EmployeeLevel", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("API_Overtime.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
