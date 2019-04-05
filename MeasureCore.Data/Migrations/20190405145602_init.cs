using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RandREng.MeasureCore.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PrinterName = table.Column<string>(nullable: true),
                    PrinterPort = table.Column<string>(nullable: true),
                    PrinterDriver = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    FaxNumber = table.Column<string>(nullable: true),
                    ManagerId = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    LabelPrinter = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    VendorId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessUnits_BusinessUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckNumber = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Amount = table.Column<decimal>(type: "Money", nullable: true),
                    VendorId = table.Column<int>(nullable: false),
                    QBTxnId = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    WaiverSignature = table.Column<byte[]>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    QRCodePrefix = table.Column<string>(nullable: true),
                    TollFree = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    QBClass = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscrepancyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscrepancyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    PagerNumber = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: true),
                    ReceiveCallNotes = table.Column<bool>(nullable: false),
                    SMTPEmail = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntryMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobStatusDescription = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    AlwaysSkipInitialCall = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true),
                    Billable = table.Column<bool>(nullable: false),
                    Installable = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatSubCat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatSubCat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasureCustomerStores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    StoreId = table.Column<int>(nullable: true),
                    Enterred = table.Column<DateTime>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    MeasureId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureCustomerStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoteTypeDescription = table.Column<string>(nullable: true),
                    ShowInList = table.Column<bool>(nullable: false),
                    ShowEmployees = table.Column<bool>(nullable: false),
                    ShowSpokeWith = table.Column<bool>(nullable: false),
                    RequireSpokeWith = table.Column<bool>(nullable: false),
                    EnableSchedulingInfo = table.Column<bool>(nullable: false),
                    CanSendToExpeditor = table.Column<bool>(nullable: false),
                    ShowStoreManagement = table.Column<bool>(nullable: false),
                    PermissionRequiredToSelect = table.Column<bool>(nullable: false),
                    DisplayOrder = table.Column<byte>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ShowCloset = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlotTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubContractors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    HomePhoneNumber = table.Column<string>(nullable: true),
                    CellPhoneNumber = table.Column<string>(nullable: true),
                    Pager = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true),
                    WorkmansCompInsuranceOK = table.Column<bool>(nullable: true),
                    BackgroundChkDateApproved = table.Column<DateTime>(nullable: true),
                    BackgroundCheckPassed = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Retainage = table.Column<decimal>(type: "Money", nullable: true),
                    SavingsRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RetainageRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Helper = table.Column<bool>(nullable: false),
                    InsuranceRate = table.Column<double>(nullable: false),
                    InsuranceDollarAmount = table.Column<decimal>(type: "Money", nullable: false),
                    BadgeStatus = table.Column<string>(nullable: true),
                    BackgroundRptRequested = table.Column<bool>(nullable: false),
                    AssignedTo = table.Column<int>(nullable: true),
                    MarketId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    WorkmansCompInsuranceDate = table.Column<DateTime>(type: "Date", nullable: true),
                    LiabilityInsuranceDate = table.Column<DateTime>(type: "Date", nullable: true),
                    PictureFilename = table.Column<string>(nullable: true),
                    LiabilityInsuranceOK = table.Column<bool>(nullable: true),
                    QBSubContractorId = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Divisor = table.Column<int>(nullable: false),
                    NumberOfDecimals = table.Column<int>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    LongDescriptionSOSI = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTaskType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTaskType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<double>(nullable: false),
                    MaterialTypeId = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    EmailTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTemplates_EmailTypes_EmailTypeId",
                        column: x => x.EmailTypeId,
                        principalTable: "EmailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ConfirmationToken = table.Column<string>(nullable: true),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    ResetPasswordToken = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    BillingAddress_Address1 = table.Column<string>(nullable: true),
                    BillingAddress_Address2 = table.Column<string>(nullable: true),
                    BillingAddress_City = table.Column<string>(nullable: true),
                    BillingAddress_State = table.Column<string>(nullable: true),
                    BillingAddress_ZipCode = table.Column<string>(nullable: true),
                    BillingAddress_Latitude = table.Column<double>(nullable: true),
                    BillingAddress_Longitude = table.Column<double>(nullable: true),
                    Directions = table.Column<string>(nullable: true),
                    Modified_UserId = table.Column<int>(nullable: true),
                    Modified_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    QBCustomerId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true, computedColumnSql: "ISnull(CompanyName, LastName + ', ' + FirstName)"),
                    ParentId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Clients_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Employees_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MarketName = table.Column<string>(nullable: true),
                    PrinterName = table.Column<string>(nullable: true),
                    PrinterPort = table.Column<string>(nullable: true),
                    PrinterDriver = table.Column<string>(nullable: true),
                    ManagerId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketId);
                    table.ForeignKey(
                        name: "FK_Markets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerTypeId = table.Column<int>(nullable: true),
                    MinimumPrice = table.Column<decimal>(type: "Money", nullable: true),
                    MinimumCost = table.Column<decimal>(type: "Money", nullable: true),
                    MinimumRetail = table.Column<decimal>(type: "Money", nullable: true),
                    CustomMultiplier = table.Column<double>(nullable: true),
                    TripChargeMultiplier = table.Column<double>(nullable: true),
                    CostMultiplier = table.Column<double>(nullable: true),
                    Valid = table.Column<bool>(nullable: true),
                    OnlyBasicToMinimum = table.Column<bool>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    BusinesUnitId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Furnish = table.Column<bool>(nullable: false),
                    SKU = table.Column<string>(nullable: true),
                    SKUDesc = table.Column<string>(nullable: true),
                    MaterialTypeName = table.Column<string>(nullable: true),
                    InsuranceReplacement = table.Column<bool>(nullable: false),
                    AllowMaterialStatusUpdate = table.Column<bool>(nullable: false),
                    JobTypeId = table.Column<int>(nullable: true),
                    WoodWaiver = table.Column<bool>(nullable: false),
                    CustomCostByRetail = table.Column<bool>(nullable: false),
                    MarkDown = table.Column<int>(nullable: true),
                    MarkDownMin = table.Column<int>(nullable: true),
                    MarkDownMax = table.Column<int>(nullable: true),
                    BusinessUnitId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Program_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Program_CustomerType_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Program_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PermissionTypeId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    PermissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permission_PermissionType_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientTypeReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReportTypeId = table.Column<int>(nullable: false),
                    ClientTypeId = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    StoreTypeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTypeReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientTypeReports_ReportTypes_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientTypeReports_CustomerType_StoreTypeId",
                        column: x => x.StoreTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubContractorId = table.Column<int>(nullable: false),
                    TotalPaid = table.Column<decimal>(type: "Money", nullable: false),
                    Retainage = table.Column<decimal>(type: "Money", nullable: false),
                    Insurance = table.Column<decimal>(type: "Money", nullable: false),
                    PayDay = table.Column<DateTime>(type: "Date", nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false),
                    QBTxnId = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_SubContractors_SubContractorId",
                        column: x => x.SubContractorId,
                        principalTable: "SubContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    LastModifiedById = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teches_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teches_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    PhoneNumberTypeId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_PhoneNumberTypes_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalTable: "PhoneNumberTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstallationCrew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CrewName = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    LeadId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    InstallationManager = table.Column<bool>(nullable: false),
                    MarketId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallationCrew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstallationCrew_SubContractors_LeadId",
                        column: x => x.LeadId,
                        principalTable: "SubContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstallationCrew_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstallationCrew_SubContractors_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "SubContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserMarketDivisionAssignment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    MarketId = table.Column<int>(nullable: false),
                    BusinessUnitId = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMarketDivisionAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMarketDivisionAssignment_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMarketDivisionAssignment_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMarketDivisionAssignment_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    WorkOrderDescription = table.Column<string>(nullable: true),
                    UnitOfMeasureId = table.Column<int>(nullable: true),
                    PrintOnWO = table.Column<bool>(nullable: false),
                    PrintOnInvoice = table.Column<bool>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Size = table.Column<bool>(nullable: false),
                    JobSize = table.Column<bool>(nullable: false),
                    ApplyToMinimun = table.Column<bool>(nullable: false),
                    ApplyToMinimumWO = table.Column<bool>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: true),
                    UnitCost = table.Column<decimal>(type: "Money", nullable: true),
                    RetailPrice = table.Column<decimal>(type: "Money", nullable: true),
                    ProgramId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Items_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: true),
                    PurchaseOrderNumber = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ScheduleStartDate = table.Column<DateTime>(type: "Date", nullable: true),
                    BilledDate = table.Column<DateTime>(nullable: true),
                    Scheduled = table.Column<bool>(nullable: false),
                    Billed = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Called = table.Column<bool>(nullable: false),
                    ProgramId = table.Column<int>(nullable: false),
                    InternalNotes = table.Column<string>(nullable: true),
                    CostAmount = table.Column<decimal>(type: "Money", nullable: false),
                    BilledAmount = table.Column<decimal>(type: "Money", nullable: false),
                    OrderAmount = table.Column<decimal>(type: "Money", nullable: false),
                    TripCharge = table.Column<decimal>(type: "Money", nullable: false),
                    RetailAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NoMinimum = table.Column<bool>(nullable: false),
                    ScheduledAM = table.Column<bool>(nullable: false),
                    Cancelled = table.Column<bool>(nullable: false),
                    Warrenty = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    SevenDay = table.Column<bool>(nullable: false),
                    DrawingNumber = table.Column<string>(nullable: true),
                    DrawingDate = table.Column<DateTime>(nullable: true),
                    CustomerToCall = table.Column<bool>(nullable: false),
                    Invoice = table.Column<bool>(nullable: false),
                    OriginalPO = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    EntryMethodId = table.Column<int>(nullable: false),
                    Assigned_UserId = table.Column<int>(nullable: true),
                    Assigned_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    Created_UserId = table.Column<int>(nullable: true),
                    Created_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    Entered_UserId = table.Column<int>(nullable: true),
                    Entered_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    Reviewed_UserId = table.Column<int>(nullable: true),
                    Reviewed_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    FollowUpDate = table.Column<DateTime>(nullable: true),
                    FollowUpAction = table.Column<string>(nullable: true),
                    SPNNotes = table.Column<string>(nullable: true),
                    XMLOrderCostAmount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    VendorId = table.Column<int>(nullable: true),
                    CustomerOrderNumber = table.Column<string>(nullable: true),
                    SvcCompleteSentDate = table.Column<DateTime>(nullable: true),
                    ScheduleEndDate = table.Column<DateTime>(nullable: true),
                    SalesPersonId = table.Column<int>(nullable: true),
                    Estimate = table.Column<bool>(nullable: false),
                    NUMBER = table.Column<string>(nullable: true),
                    JobId = table.Column<int>(nullable: true),
                    MarkDown = table.Column<int>(nullable: true),
                    JobSize = table.Column<double>(nullable: true),
                    JobStatusId = table.Column<int>(nullable: true),
                    PrimaryOrderId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_EntryMethods_EntryMethodId",
                        column: x => x.EntryMethodId,
                        principalTable: "EntryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Orders_PrimaryOrderId",
                        column: x => x.PrimaryOrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_Assigned_UserId",
                        column: x => x.Assigned_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_Created_UserId",
                        column: x => x.Created_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_Entered_UserId",
                        column: x => x.Entered_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_Reviewed_UserId",
                        column: x => x.Reviewed_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramMarketMapping",
                columns: table => new
                {
                    ProgramId = table.Column<int>(nullable: false),
                    MarketId = table.Column<int>(nullable: false),
                    AllowEntry = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramMarketMapping", x => new { x.ProgramId, x.MarketId });
                    table.ForeignKey(
                        name: "FK_ProgramMarketMapping_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramMarketMapping_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReportTypeId = table.Column<int>(nullable: false),
                    ProgramId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramReport_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramReport_ReportTypes_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPermission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    MarketId = table.Column<int>(nullable: false),
                    BusinessUnitId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermission_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermission_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermission_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address_Address1 = table.Column<string>(nullable: true),
                    Address_Address2 = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_ZipCode = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    BillingAddress_Address1 = table.Column<string>(nullable: true),
                    BillingAddress_Address2 = table.Column<string>(nullable: true),
                    BillingAddress_City = table.Column<string>(nullable: true),
                    BillingAddress_State = table.Column<string>(nullable: true),
                    BillingAddress_ZipCode = table.Column<string>(nullable: true),
                    BillingAddress_Latitude = table.Column<double>(nullable: true),
                    BillingAddress_Longitude = table.Column<double>(nullable: true),
                    AspNetUserId = table.Column<string>(nullable: true),
                    CustomerTypeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    MarketId = table.Column<int>(nullable: true),
                    TechId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Store_CustomerType_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Store_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Store_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Store_Teches_TechId",
                        column: x => x.TechId,
                        principalTable: "Teches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechCapacities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TechId = table.Column<string>(nullable: true),
                    SlotTypeId = table.Column<int>(nullable: false),
                    Capacity = table.Column<byte>(nullable: false),
                    DayOfWeek = table.Column<byte>(nullable: false),
                    TechId1 = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechCapacities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechCapacities_SlotTypes_SlotTypeId",
                        column: x => x.SlotTypeId,
                        principalTable: "SlotTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechCapacities_Teches_TechId1",
                        column: x => x.TechId1,
                        principalTable: "Teches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstallationCrewType",
                columns: table => new
                {
                    InstallationCrewId = table.Column<int>(nullable: false),
                    JobTypeId = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: true),
                    MaxSizeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallationCrewType", x => new { x.InstallationCrewId, x.JobTypeId });
                    table.ForeignKey(
                        name: "FK_InstallationCrewType_InstallationCrew_InstallationCrewId",
                        column: x => x.InstallationCrewId,
                        principalTable: "InstallationCrew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstallationCrewType_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCatagory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    IsPadding = table.Column<bool>(nullable: false),
                    YardsPerRoll = table.Column<int>(nullable: true),
                    UnitOfMeasureId = table.Column<int>(nullable: false),
                    SubCatId = table.Column<int>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    Furnish = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MatSubCatId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    ItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCatagory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialCatagory_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialCatagory_MatSubCat_MatSubCatId",
                        column: x => x.MatSubCatId,
                        principalTable: "MatSubCat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialCatagory_UnitOfMeasures_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActionReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ReportDate = table.Column<DateTime>(nullable: true),
                    Nature = table.Column<string>(nullable: true),
                    ActionRequired = table.Column<string>(nullable: true),
                    Cause = table.Column<string>(nullable: true),
                    Closed = table.Column<bool>(nullable: true),
                    StoreError = table.Column<int>(nullable: true),
                    MillError = table.Column<int>(nullable: true),
                    InstallerError = table.Column<int>(nullable: true),
                    MeasureError = table.Column<int>(nullable: true),
                    StoreErrorText = table.Column<string>(nullable: true),
                    MillErrorText = table.Column<string>(nullable: true),
                    InstallerErrorText = table.Column<string>(nullable: true),
                    MeasureErrorText = table.Column<string>(nullable: true),
                    EnteredBy = table.Column<int>(nullable: true),
                    LastEditedDate = table.Column<DateTime>(nullable: true),
                    LastEditedBy = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionReport_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChargeBacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    AmountToSub = table.Column<decimal>(type: "Money", nullable: false),
                    SubcontractorId = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(type: "Date", nullable: false),
                    OriginalPO = table.Column<string>(nullable: true),
                    CostAdjustment = table.Column<bool>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    ApprovalNumber = table.Column<int>(nullable: false),
                    Approved = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargeBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChargeBacks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckDetails_Checks_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Checks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discrepancy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiscrepancyTypeId = table.Column<int>(nullable: true),
                    DiscrepancySubTypeId = table.Column<int>(nullable: true),
                    CurrentData = table.Column<string>(nullable: true),
                    NewData = table.Column<string>(nullable: true),
                    XMLFilePath = table.Column<string>(nullable: true),
                    DateFound = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    DetailId = table.Column<int>(nullable: true),
                    Reviewed = table.Column<bool>(nullable: false),
                    ReviewedById = table.Column<int>(nullable: true),
                    DateReviewed = table.Column<DateTime>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discrepancy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discrepancy_DiscrepancyType_DiscrepancyTypeId",
                        column: x => x.DiscrepancyTypeId,
                        principalTable: "DiscrepancyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discrepancy_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discrepancy_Employees_ReviewedById",
                        column: x => x.ReviewedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderCustoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    SubContractorId = table.Column<int>(nullable: true),
                    RetailPrice = table.Column<decimal>(type: "Money", nullable: true),
                    UnitCost = table.Column<decimal>(type: "Money", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    ExtendedPrice = table.Column<decimal>(type: "Money", nullable: false),
                    ExtendedCost = table.Column<decimal>(type: "Money", nullable: false),
                    Quanity = table.Column<double>(nullable: false),
                    UnitOfMeasureId = table.Column<int>(nullable: true),
                    NotOnInvoice = table.Column<bool>(nullable: true),
                    NotOnWorkOrder = table.Column<bool>(nullable: true),
                    SubContractorPaid = table.Column<bool>(nullable: true),
                    SubContractorPay = table.Column<double>(nullable: true),
                    EntryMethodId = table.Column<int>(nullable: false),
                    CustomItemNumber = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Reviewed = table.Column<bool>(nullable: false),
                    ReviewedById = table.Column<int>(nullable: true),
                    ReviewedDate = table.Column<DateTime>(nullable: true),
                    PrintOnWorkOrder = table.Column<bool>(nullable: false),
                    PrintOnInvoice = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCustoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderCustoms_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderCustoms_EntryMethods_EntryMethodId",
                        column: x => x.EntryMethodId,
                        principalTable: "EntryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderCustoms_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderCustoms_SubContractors_SubContractorId",
                        column: x => x.SubContractorId,
                        principalTable: "SubContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderCustoms_UnitOfMeasures_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDiagram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    DiagramNumber = table.Column<string>(nullable: true),
                    DiagramDateTime = table.Column<DateTime>(nullable: true),
                    DiagramFileName = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDiagram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDiagram_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    InstallQuantity = table.Column<double>(nullable: false),
                    UnitCost = table.Column<decimal>(type: "Money", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    UnitRetail = table.Column<decimal>(type: "Money", nullable: true),
                    MaterialCost = table.Column<decimal>(type: "Money", nullable: false),
                    ExtendedPrice = table.Column<decimal>(type: "Money", nullable: false),
                    ExtendedCost = table.Column<decimal>(type: "Money", nullable: false),
                    SubContractorId = table.Column<int>(nullable: true),
                    PrintOnInvoice = table.Column<bool>(nullable: false),
                    PrintOnWO = table.Column<bool>(nullable: false),
                    EntryMethodId = table.Column<int>(nullable: false),
                    ReviewedById = table.Column<int>(nullable: true),
                    ReviewedDate = table.Column<DateTime>(nullable: true),
                    SubContractorPaid = table.Column<bool>(nullable: true),
                    SubContractorPay = table.Column<decimal>(type: "Money", nullable: true),
                    ServiceLineNumber = table.Column<int>(nullable: true),
                    MaterialStatusId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Reviewed = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_EntryMethods_EntryMethodId",
                        column: x => x.EntryMethodId,
                        principalTable: "EntryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_MaterialStatus_MaterialStatusId",
                        column: x => x.MaterialStatusId,
                        principalTable: "MaterialStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Employees_ReviewedById",
                        column: x => x.ReviewedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    NoteTypeId = table.Column<int>(nullable: false),
                    SpokeWithId = table.Column<int>(nullable: false),
                    ContactName = table.Column<string>(nullable: true),
                    DateTimeEntered = table.Column<DateTime>(nullable: false),
                    NoteText = table.Column<string>(nullable: true),
                    EnteredById = table.Column<int>(nullable: true),
                    CustomerToCallBack = table.Column<bool>(nullable: false),
                    Scheduled = table.Column<bool>(nullable: false),
                    UnScheduled = table.Column<bool>(nullable: false),
                    ScheduledAM = table.Column<bool>(nullable: true),
                    ScheduledDate = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    SentViaXML = table.Column<bool>(nullable: false),
                    DateTimeSent = table.Column<DateTime>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderNotes_Employees_EnteredById",
                        column: x => x.EnteredById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderNotes_NoteTypes_NoteTypeId",
                        column: x => x.NoteTypeId,
                        principalTable: "NoteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderNotes_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderRegMerchandiseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    SKUNumber = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: true),
                    UnitOfMeasureId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    EntryMethodId = table.Column<int>(nullable: false),
                    MaterialStatusId = table.Column<int>(nullable: true),
                    TransferredTo = table.Column<int>(nullable: true),
                    TransferredFrom = table.Column<int>(nullable: true),
                    Reviewed_UserId = table.Column<int>(nullable: true),
                    Reviewed_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    OriginalOrderId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "Money", nullable: true),
                    Retail = table.Column<decimal>(type: "Money", nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRegMerchandiseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderRegMerchandiseDetail_EntryMethods_EntryMethodId",
                        column: x => x.EntryMethodId,
                        principalTable: "EntryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRegMerchandiseDetail_MaterialStatus_MaterialStatusId",
                        column: x => x.MaterialStatusId,
                        principalTable: "MaterialStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRegMerchandiseDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRegMerchandiseDetail_UnitOfMeasures_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRegMerchandiseDetail_Employees_Reviewed_UserId",
                        column: x => x.Reviewed_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderSOMerchandiseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    SKUNumber = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: true),
                    UnitOfMeasureId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    EntryMethodId = table.Column<int>(nullable: false),
                    MaterialStatusId = table.Column<int>(nullable: true),
                    TransferredTo = table.Column<int>(nullable: true),
                    TransferredFrom = table.Column<int>(nullable: true),
                    Reviewed_UserId = table.Column<int>(nullable: true),
                    Reviewed_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    OriginalOrderId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    ExpectedArrivalDate = table.Column<DateTime>(type: "Date", nullable: true),
                    SOLineNumber = table.Column<int>(nullable: true),
                    SOMerLineNumber = table.Column<int>(nullable: true),
                    PreSplitQty = table.Column<double>(nullable: true),
                    Received_UserId = table.Column<int>(nullable: true),
                    Received_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    WillCallLineNumber = table.Column<int>(nullable: true),
                    NotNeeded = table.Column<bool>(nullable: false),
                    SONumber = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSOMerchandiseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSOMerchandiseDetail_EntryMethods_EntryMethodId",
                        column: x => x.EntryMethodId,
                        principalTable: "EntryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderSOMerchandiseDetail_MaterialStatus_MaterialStatusId",
                        column: x => x.MaterialStatusId,
                        principalTable: "MaterialStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderSOMerchandiseDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderSOMerchandiseDetail_UnitOfMeasures_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderSOMerchandiseDetail_Employees_Received_UserId",
                        column: x => x.Received_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderSOMerchandiseDetail_Employees_Reviewed_UserId",
                        column: x => x.Reviewed_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FilePath = table.Column<string>(nullable: true),
                    EnterredBy_UserId = table.Column<int>(nullable: true),
                    EnterredBy_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DateTimeEntered = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_POPhotos_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POPhotos_Employees_EnterredBy_UserId",
                        column: x => x.EnterredBy_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobId = table.Column<int>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UserTaskTypeId = table.Column<int>(nullable: false),
                    Added_UserId = table.Column<int>(nullable: true),
                    Added_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    Completed_UserId = table.Column<int>(nullable: true),
                    Completed_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    Assinged_UserId = table.Column<int>(nullable: true),
                    Assinged_DateTimeEntered = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTask_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTask_UserTaskType_UserTaskTypeId",
                        column: x => x.UserTaskTypeId,
                        principalTable: "UserTaskType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTask_Employees_Added_UserId",
                        column: x => x.Added_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTask_Employees_Assinged_UserId",
                        column: x => x.Assinged_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTask_Employees_Completed_UserId",
                        column: x => x.Completed_UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cancel = table.Column<bool>(nullable: false),
                    ScheduledAM = table.Column<bool>(nullable: false),
                    ScheduleEndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ScheduleStartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    CrewId = table.Column<int>(nullable: true),
                    JobId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    InstallationCrewId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrder_InstallationCrew_InstallationCrewId",
                        column: x => x.InstallationCrewId,
                        principalTable: "InstallationCrew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemCostings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    Cost_MarketId = table.Column<int>(nullable: true),
                    Cost_StoreId = table.Column<int>(nullable: true),
                    Cost_Amount = table.Column<decimal>(type: "Money", nullable: false),
                    Cost_Freight = table.Column<decimal>(type: "Money", nullable: true),
                    Cost_StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Cost_EndDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Cost_BusinessUnitId = table.Column<int>(nullable: true),
                    Cost_SalesTax = table.Column<double>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    MarketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCostings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCostings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemCostings_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemCostings_BusinessUnits_Cost_BusinessUnitId",
                        column: x => x.Cost_BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemCostings_Markets_Cost_MarketId",
                        column: x => x.Cost_MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemCostings_Store_Cost_StoreId",
                        column: x => x.Cost_StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemMatCostings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    MatCost_MarketId = table.Column<int>(nullable: true),
                    MatCost_StoreId = table.Column<int>(nullable: true),
                    MatCost_Amount = table.Column<decimal>(type: "Money", nullable: false),
                    MatCost_Freight = table.Column<decimal>(type: "Money", nullable: true),
                    MatCost_StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    MatCost_EndDate = table.Column<DateTime>(type: "Date", nullable: true),
                    MatCost_BusinessUnitId = table.Column<int>(nullable: true),
                    MatCost_SalesTax = table.Column<double>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    MarketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMatCostings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemMatCostings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatCostings_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatCostings_BusinessUnits_MatCost_BusinessUnitId",
                        column: x => x.MatCost_BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatCostings_Markets_MatCost_MarketId",
                        column: x => x.MatCost_MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatCostings_Store_MatCost_StoreId",
                        column: x => x.MatCost_StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemPricings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    Price_MarketId = table.Column<int>(nullable: true),
                    Price_StoreId = table.Column<int>(nullable: true),
                    Price_Amount = table.Column<decimal>(type: "Money", nullable: false),
                    Price_Freight = table.Column<decimal>(type: "Money", nullable: true),
                    Price_StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Price_EndDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Price_BusinessUnitId = table.Column<int>(nullable: true),
                    Price_SalesTax = table.Column<double>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    MarketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPricings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPricings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPricings_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPricings_BusinessUnits_Price_BusinessUnitId",
                        column: x => x.Price_BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPricings_Markets_Price_MarketId",
                        column: x => x.Price_MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPricings_Store_Price_StoreId",
                        column: x => x.Price_StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemRetailPricing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemI = table.Column<int>(nullable: false),
                    Retail_MarketId = table.Column<int>(nullable: true),
                    Retail_StoreId = table.Column<int>(nullable: true),
                    Retail_Amount = table.Column<decimal>(type: "Money", nullable: false),
                    Retail_Freight = table.Column<decimal>(type: "Money", nullable: true),
                    Retail_StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Retail_EndDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Retail_BusinessUnitId = table.Column<int>(nullable: true),
                    Retail_SalesTax = table.Column<double>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRetailPricing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemRetailPricing_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemRetailPricing_BusinessUnits_Retail_BusinessUnitId",
                        column: x => x.Retail_BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemRetailPricing_Markets_Retail_MarketId",
                        column: x => x.Retail_MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemRetailPricing_Store_Retail_StoreId",
                        column: x => x.Retail_StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    Enterred = table.Column<DateTime>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    EnterredById = table.Column<string>(nullable: true),
                    SpecialInstructions = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measures_Clients_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measures_AspNetUsers_EnterredById",
                        column: x => x.EnterredById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measures_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaterialCatId = table.Column<int>(nullable: false),
                    Cost_MarketId = table.Column<int>(nullable: true),
                    Cost_StoreId = table.Column<int>(nullable: true),
                    Cost_Amount = table.Column<decimal>(type: "Money", nullable: false),
                    Cost_Freight = table.Column<decimal>(type: "Money", nullable: true),
                    Cost_StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Cost_EndDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Cost_BusinessUnitId = table.Column<int>(nullable: true),
                    Cost_SalesTax = table.Column<double>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    MarketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialCost_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialCost_MaterialCatagory_MaterialCatId",
                        column: x => x.MaterialCatId,
                        principalTable: "MaterialCatagory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialCost_BusinessUnits_Cost_BusinessUnitId",
                        column: x => x.Cost_BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialCost_Markets_Cost_MarketId",
                        column: x => x.Cost_MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialCost_Store_Cost_StoreId",
                        column: x => x.Cost_StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaterialCatId = table.Column<int>(nullable: false),
                    Price_MarketId = table.Column<int>(nullable: true),
                    Price_StoreId = table.Column<int>(nullable: true),
                    Price_Amount = table.Column<decimal>(type: "Money", nullable: false),
                    Price_Freight = table.Column<decimal>(type: "Money", nullable: true),
                    Price_StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Price_EndDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Price_BusinessUnitId = table.Column<int>(nullable: true),
                    Price_SalesTax = table.Column<double>(nullable: true),
                    Material_CatagoryId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    MarketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialPrice_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialPrice_MaterialCatagory_Material_CatagoryId",
                        column: x => x.Material_CatagoryId,
                        principalTable: "MaterialCatagory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialPrice_BusinessUnits_Price_BusinessUnitId",
                        column: x => x.Price_BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialPrice_Markets_Price_MarketId",
                        column: x => x.Price_MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialPrice_Store_Price_StoreId",
                        column: x => x.Price_StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckCBDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckId = table.Column<int>(nullable: false),
                    ChargeBackId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckCBDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckCBDetails_ChargeBacks_ChargeBackId",
                        column: x => x.ChargeBackId,
                        principalTable: "ChargeBacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckCBDetails_Checks_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Checks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillId = table.Column<int>(nullable: false),
                    NoRetainage = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    WorkOrderId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PayAmount = table.Column<decimal>(type: "Money", nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    ClassificationId = table.Column<int>(nullable: false),
                    BackChargeOwnerId = table.Column<int>(nullable: true),
                    ChargeBackId = table.Column<int>(nullable: true),
                    QBUid = table.Column<string>(nullable: true),
                    SubContractorId = table.Column<int>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetail_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillDetail_ChargeBacks_ChargeBackId",
                        column: x => x.ChargeBackId,
                        principalTable: "ChargeBacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillDetail_SubContractors_SubContractorId",
                        column: x => x.SubContractorId,
                        principalTable: "SubContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillDetail_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    PathAndFilename = table.Column<string>(nullable: true),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    OrderSOMerchandiseDetailId = table.Column<int>(nullable: true),
                    WorkOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_OrderSOMerchandiseDetail_OrderSOMerchandiseDetailId",
                        column: x => x.OrderSOMerchandiseDetailId,
                        principalTable: "OrderSOMerchandiseDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrderEmail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkOrderId = table.Column<int>(nullable: false),
                    EmailType = table.Column<int>(nullable: false),
                    Sent = table.Column<DateTime>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrderEmail_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeasureEmails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeasureId = table.Column<int>(nullable: false),
                    Sent = table.Column<DateTime>(nullable: false),
                    EmailTemplateId = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasureEmails_EmailTemplates_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeasureEmails_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeasureMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaterialTypeId = table.Column<int>(nullable: false),
                    MeasureId = table.Column<int>(nullable: false),
                    WidthId = table.Column<int>(nullable: true),
                    AltWidthId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PatternMatchLength = table.Column<double>(nullable: true),
                    PatternMatchWidth = table.Column<double>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasureMaterials_Widths_AltWidthId",
                        column: x => x.AltWidthId,
                        principalTable: "Widths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeasureMaterials_Program_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeasureMaterials_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeasureMaterials_Widths_WidthId",
                        column: x => x.WidthId,
                        principalTable: "Widths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    SlotTypeId = table.Column<int>(nullable: false),
                    MeasureId = table.Column<int>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_SlotTypes_SlotTypeId",
                        column: x => x.SlotTypeId,
                        principalTable: "SlotTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentOrder",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentOrder", x => new { x.OrderId, x.DocumentId });
                    table.ForeignKey(
                        name: "FK_DocumentOrder_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeasureRooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MaterialId = table.Column<int>(nullable: false),
                    IncludeCloset = table.Column<bool>(nullable: false),
                    ENTRY_Created = table.Column<DateTime>(nullable: false),
                    ENTRY_LastModified = table.Column<DateTime>(nullable: false),
                    MeasureMaterialId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasureRooms_MeasureMaterials_MeasureMaterialId",
                        column: x => x.MeasureMaterialId,
                        principalTable: "MeasureMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeasureRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionReport_OrderId",
                table: "ActionReport",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_SubContractorId",
                table: "Bill",
                column: "SubContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillId",
                table: "BillDetail",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_ChargeBackId",
                table: "BillDetail",
                column: "ChargeBackId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_SubContractorId",
                table: "BillDetail",
                column: "SubContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_WorkOrderId",
                table: "BillDetail",
                column: "WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_ParentId",
                table: "BusinessUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ChargeBacks_OrderId",
                table: "ChargeBacks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckCBDetails_ChargeBackId",
                table: "CheckCBDetails",
                column: "ChargeBackId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckCBDetails_CheckId",
                table: "CheckCBDetails",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_CheckId",
                table: "CheckDetails",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_OrderId",
                table: "CheckDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ParentId",
                table: "Clients",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Modified_UserId",
                table: "Clients",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTypeReports_ReportTypeId",
                table: "ClientTypeReports",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTypeReports_StoreTypeId",
                table: "ClientTypeReports",
                column: "StoreTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Discrepancy_DiscrepancyTypeId",
                table: "Discrepancy",
                column: "DiscrepancyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Discrepancy_OrderId",
                table: "Discrepancy",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Discrepancy_ReviewedById",
                table: "Discrepancy",
                column: "ReviewedById");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentOrder_DocumentId",
                table: "DocumentOrder",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_OrderSOMerchandiseDetailId",
                table: "Documents",
                column: "OrderSOMerchandiseDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_WorkOrderId",
                table: "Documents",
                column: "WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_EmailTypeId",
                table: "EmailTemplates",
                column: "EmailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallationCrew_LeadId",
                table: "InstallationCrew",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallationCrew_MarketId",
                table: "InstallationCrew",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallationCrew_OwnerId",
                table: "InstallationCrew",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallationCrewType_JobTypeId",
                table: "InstallationCrewType",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCostings_ItemId",
                table: "ItemCostings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCostings_MarketId",
                table: "ItemCostings",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCostings_Cost_BusinessUnitId",
                table: "ItemCostings",
                column: "Cost_BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCostings_Cost_MarketId",
                table: "ItemCostings",
                column: "Cost_MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCostings_Cost_StoreId",
                table: "ItemCostings",
                column: "Cost_StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatCostings_ItemId",
                table: "ItemMatCostings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatCostings_MarketId",
                table: "ItemMatCostings",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatCostings_MatCost_BusinessUnitId",
                table: "ItemMatCostings",
                column: "MatCost_BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatCostings_MatCost_MarketId",
                table: "ItemMatCostings",
                column: "MatCost_MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatCostings_MatCost_StoreId",
                table: "ItemMatCostings",
                column: "MatCost_StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPricings_ItemId",
                table: "ItemPricings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPricings_MarketId",
                table: "ItemPricings",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPricings_Price_BusinessUnitId",
                table: "ItemPricings",
                column: "Price_BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPricings_Price_MarketId",
                table: "ItemPricings",
                column: "Price_MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPricings_Price_StoreId",
                table: "ItemPricings",
                column: "Price_StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRetailPricing_ItemId",
                table: "ItemRetailPricing",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRetailPricing_Retail_BusinessUnitId",
                table: "ItemRetailPricing",
                column: "Retail_BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRetailPricing_Retail_MarketId",
                table: "ItemRetailPricing",
                column: "Retail_MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRetailPricing_Retail_StoreId",
                table: "ItemRetailPricing",
                column: "Retail_StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ParentId",
                table: "Items",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProgramId",
                table: "Items",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UnitOfMeasureId",
                table: "Items",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Markets_EmployeeId",
                table: "Markets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCatagory_ItemId",
                table: "MaterialCatagory",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCatagory_MatSubCatId",
                table: "MaterialCatagory",
                column: "MatSubCatId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCatagory_UnitOfMeasureId",
                table: "MaterialCatagory",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCost_MarketId",
                table: "MaterialCost",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCost_MaterialCatId",
                table: "MaterialCost",
                column: "MaterialCatId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCost_Cost_BusinessUnitId",
                table: "MaterialCost",
                column: "Cost_BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCost_Cost_MarketId",
                table: "MaterialCost",
                column: "Cost_MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCost_Cost_StoreId",
                table: "MaterialCost",
                column: "Cost_StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPrice_MarketId",
                table: "MaterialPrice",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPrice_Material_CatagoryId",
                table: "MaterialPrice",
                column: "Material_CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPrice_Price_BusinessUnitId",
                table: "MaterialPrice",
                column: "Price_BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPrice_Price_MarketId",
                table: "MaterialPrice",
                column: "Price_MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPrice_Price_StoreId",
                table: "MaterialPrice",
                column: "Price_StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureEmails_EmailTemplateId",
                table: "MeasureEmails",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureEmails_MeasureId",
                table: "MeasureEmails",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureMaterials_AltWidthId",
                table: "MeasureMaterials",
                column: "AltWidthId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureMaterials_MaterialTypeId",
                table: "MeasureMaterials",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureMaterials_MeasureId",
                table: "MeasureMaterials",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureMaterials_WidthId",
                table: "MeasureMaterials",
                column: "WidthId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureRooms_MeasureMaterialId",
                table: "MeasureRooms",
                column: "MeasureMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasureRooms_RoomId",
                table: "MeasureRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Measures_CustomerId",
                table: "Measures",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Measures_EnterredById",
                table: "Measures",
                column: "EnterredById");

            migrationBuilder.CreateIndex(
                name: "IX_Measures_StoreId",
                table: "Measures",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustoms_EmployeeId",
                table: "OrderCustoms",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustoms_EntryMethodId",
                table: "OrderCustoms",
                column: "EntryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustoms_OrderId",
                table: "OrderCustoms",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustoms_SubContractorId",
                table: "OrderCustoms",
                column: "SubContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustoms_UnitOfMeasureId",
                table: "OrderCustoms",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDiagram_OrderId",
                table: "OrderDiagram",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_EntryMethodId",
                table: "OrderItems",
                column: "EntryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemId",
                table: "OrderItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MaterialStatusId",
                table: "OrderItems",
                column: "MaterialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ReviewedById",
                table: "OrderItems",
                column: "ReviewedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrderNotes_EnteredById",
                table: "OrderNotes",
                column: "EnteredById");

            migrationBuilder.CreateIndex(
                name: "IX_OrderNotes_NoteTypeId",
                table: "OrderNotes",
                column: "NoteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderNotes_OrderId",
                table: "OrderNotes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRegMerchandiseDetail_EntryMethodId",
                table: "OrderRegMerchandiseDetail",
                column: "EntryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRegMerchandiseDetail_MaterialStatusId",
                table: "OrderRegMerchandiseDetail",
                column: "MaterialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRegMerchandiseDetail_OrderId",
                table: "OrderRegMerchandiseDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRegMerchandiseDetail_UnitOfMeasureId",
                table: "OrderRegMerchandiseDetail",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRegMerchandiseDetail_Reviewed_UserId",
                table: "OrderRegMerchandiseDetail",
                column: "Reviewed_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EntryMethodId",
                table: "Orders",
                column: "EntryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PrimaryOrderId",
                table: "Orders",
                column: "PrimaryOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProgramId",
                table: "Orders",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Assigned_UserId",
                table: "Orders",
                column: "Assigned_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Created_UserId",
                table: "Orders",
                column: "Created_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Entered_UserId",
                table: "Orders",
                column: "Entered_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Reviewed_UserId",
                table: "Orders",
                column: "Reviewed_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSOMerchandiseDetail_EntryMethodId",
                table: "OrderSOMerchandiseDetail",
                column: "EntryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSOMerchandiseDetail_MaterialStatusId",
                table: "OrderSOMerchandiseDetail",
                column: "MaterialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSOMerchandiseDetail_OrderId",
                table: "OrderSOMerchandiseDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSOMerchandiseDetail_UnitOfMeasureId",
                table: "OrderSOMerchandiseDetail",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSOMerchandiseDetail_Received_UserId",
                table: "OrderSOMerchandiseDetail",
                column: "Received_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSOMerchandiseDetail_Reviewed_UserId",
                table: "OrderSOMerchandiseDetail",
                column: "Reviewed_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionId",
                table: "Permission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionTypeId",
                table: "Permission",
                column: "PermissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_EmployeeId",
                table: "PhoneNumber",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId",
                table: "PhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_ClientId",
                table: "PhoneNumber",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_POPhotos_OrderId",
                table: "POPhotos",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_POPhotos_EnterredBy_UserId",
                table: "POPhotos",
                column: "EnterredBy_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_BusinessUnitId",
                table: "Program",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_CustomerTypeId",
                table: "Program",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_JobTypeId",
                table: "Program",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramMarketMapping_MarketId",
                table: "ProgramMarketMapping",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramReport_ProgramId",
                table: "ProgramReport",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramReport_ReportTypeId",
                table: "ProgramReport",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_MeasureId",
                table: "Slots",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_SlotTypeId",
                table: "Slots",
                column: "SlotTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_UserId",
                table: "Slots",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_AspNetUserId",
                table: "Store",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_CustomerTypeId",
                table: "Store",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_EmployeeId",
                table: "Store",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_MarketId",
                table: "Store",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_TechId",
                table: "Store",
                column: "TechId");

            migrationBuilder.CreateIndex(
                name: "IX_TechCapacities_SlotTypeId",
                table: "TechCapacities",
                column: "SlotTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TechCapacities_TechId1",
                table: "TechCapacities",
                column: "TechId1");

            migrationBuilder.CreateIndex(
                name: "IX_Teches_LastModifiedById",
                table: "Teches",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Teches_UserId",
                table: "Teches",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMarketDivisionAssignment_BusinessUnitId",
                table: "UserMarketDivisionAssignment",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMarketDivisionAssignment_ManagerId",
                table: "UserMarketDivisionAssignment",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMarketDivisionAssignment_MarketId",
                table: "UserMarketDivisionAssignment",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_BusinessUnitId",
                table: "UserPermission",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_EmployeeId",
                table: "UserPermission",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_MarketId",
                table: "UserPermission",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_PermissionId",
                table: "UserPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_OrderId",
                table: "UserTask",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_UserTaskTypeId",
                table: "UserTask",
                column: "UserTaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_Added_UserId",
                table: "UserTask",
                column: "Added_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_Assinged_UserId",
                table: "UserTask",
                column: "Assinged_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_Completed_UserId",
                table: "UserTask",
                column: "Completed_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_InstallationCrewId",
                table: "WorkOrder",
                column: "InstallationCrewId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_OrderId",
                table: "WorkOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrderEmail_WorkOrderId",
                table: "WorkOrderEmail",
                column: "WorkOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionReport");

            migrationBuilder.DropTable(
                name: "BillDetail");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "CheckCBDetails");

            migrationBuilder.DropTable(
                name: "CheckDetails");

            migrationBuilder.DropTable(
                name: "ClientTypeReports");

            migrationBuilder.DropTable(
                name: "CompanyInfoes");

            migrationBuilder.DropTable(
                name: "Discrepancy");

            migrationBuilder.DropTable(
                name: "DocumentOrder");

            migrationBuilder.DropTable(
                name: "InstallationCrewType");

            migrationBuilder.DropTable(
                name: "ItemCostings");

            migrationBuilder.DropTable(
                name: "ItemMatCostings");

            migrationBuilder.DropTable(
                name: "ItemPricings");

            migrationBuilder.DropTable(
                name: "ItemRetailPricing");

            migrationBuilder.DropTable(
                name: "JobStatus");

            migrationBuilder.DropTable(
                name: "MaterialCost");

            migrationBuilder.DropTable(
                name: "MaterialPrice");

            migrationBuilder.DropTable(
                name: "MeasureCustomerStores");

            migrationBuilder.DropTable(
                name: "MeasureEmails");

            migrationBuilder.DropTable(
                name: "MeasureRooms");

            migrationBuilder.DropTable(
                name: "OrderCustoms");

            migrationBuilder.DropTable(
                name: "OrderDiagram");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OrderNotes");

            migrationBuilder.DropTable(
                name: "OrderRegMerchandiseDetail");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "POPhotos");

            migrationBuilder.DropTable(
                name: "ProgramMarketMapping");

            migrationBuilder.DropTable(
                name: "ProgramReport");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "TechCapacities");

            migrationBuilder.DropTable(
                name: "UserMarketDivisionAssignment");

            migrationBuilder.DropTable(
                name: "UserPermission");

            migrationBuilder.DropTable(
                name: "UserTask");

            migrationBuilder.DropTable(
                name: "WorkOrderEmail");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "ChargeBacks");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DropTable(
                name: "DiscrepancyType");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "MaterialCatagory");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "MeasureMaterials");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "NoteTypes");

            migrationBuilder.DropTable(
                name: "PhoneNumberTypes");

            migrationBuilder.DropTable(
                name: "ReportTypes");

            migrationBuilder.DropTable(
                name: "SlotTypes");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "UserTaskType");

            migrationBuilder.DropTable(
                name: "OrderSOMerchandiseDetail");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "MatSubCat");

            migrationBuilder.DropTable(
                name: "EmailTypes");

            migrationBuilder.DropTable(
                name: "Widths");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "PermissionType");

            migrationBuilder.DropTable(
                name: "MaterialStatus");

            migrationBuilder.DropTable(
                name: "InstallationCrew");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UnitOfMeasures");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "SubContractors");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "EntryMethods");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Teches");

            migrationBuilder.DropTable(
                name: "BusinessUnits");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
