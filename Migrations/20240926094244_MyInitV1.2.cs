using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymany_API.Migrations
{
    public partial class MyInitV12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admin_username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    admin_password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    admin_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    admin_age = table.Column<DateTime>(type: "datetime2", nullable: true),
                    admin_salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    admin_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cate_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cate_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cate_img = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    cate_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cate_id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    cus_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cus_username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cus_password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cus_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cus_address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cus_age = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cus_image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    cus_phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    cus_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.cus_id);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    exc_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    exc_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    exc_description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    exc_guide = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    exc_video = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.exc_id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalTrainers",
                columns: table => new
                {
                    pt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pt_username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pt_password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pt_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pt_age = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pt_address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pt_salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    pt_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pt_phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    pt_img = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalTrainers", x => x.pt_id);
                });

            migrationBuilder.CreateTable(
                name: "SystemAdmins",
                columns: table => new
                {
                    sysad_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sysad_username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sysad_password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sysad_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    sysad_age = table.Column<DateTime>(type: "datetime2", nullable: true),
                    sysad_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAdmins", x => x.sysad_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    prod_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prod_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prod_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prod_amount = table.Column<int>(type: "int", nullable: true),
                    prod_img = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    prod_price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    cate_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.prod_id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_cate_id",
                        column: x => x.cate_id,
                        principalTable: "Categories",
                        principalColumn: "cate_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    noti_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noti_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    noti_context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noti_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cus_id = table.Column<int>(type: "int", nullable: false),
                    pt_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.noti_id);
                    table.ForeignKey(
                        name: "FK_Notifications_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_PersonalTrainers_pt_id",
                        column: x => x.pt_id,
                        principalTable: "PersonalTrainers",
                        principalColumn: "pt_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    post_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post_title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    post_img = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    pt_id = table.Column<int>(type: "int", nullable: false),
                    cus_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.post_id);
                    table.ForeignKey(
                        name: "FK_Posts_Admins_admin_id",
                        column: x => x.admin_id,
                        principalTable: "Admins",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_PersonalTrainers_pt_id",
                        column: x => x.pt_id,
                        principalTable: "PersonalTrainers",
                        principalColumn: "pt_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlans",
                columns: table => new
                {
                    workout_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    workout_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    workout_startDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    workout_endDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    workout_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    workout_session = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    workout_activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pt_id = table.Column<int>(type: "int", nullable: false),
                    exc_id = table.Column<int>(type: "int", nullable: false),
                    cus_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlans", x => x.workout_id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlans_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutPlans_Exercise_exc_id",
                        column: x => x.exc_id,
                        principalTable: "Exercise",
                        principalColumn: "exc_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutPlans_PersonalTrainers_pt_id",
                        column: x => x.pt_id,
                        principalTable: "PersonalTrainers",
                        principalColumn: "pt_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_quantity = table.Column<int>(type: "int", nullable: true),
                    cus_id = table.Column<int>(type: "int", nullable: false),
                    prod_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_id);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Products_prod_id",
                        column: x => x.prod_id,
                        principalTable: "Products",
                        principalColumn: "prod_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    order_startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    order_totalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    order_quantity = table.Column<int>(type: "int", nullable: false),
                    cus_id = table.Column<int>(type: "int", nullable: false),
                    prod_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_prod_id",
                        column: x => x.prod_id,
                        principalTable: "Products",
                        principalColumn: "prod_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    pay_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pay_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pay_quantity = table.Column<int>(type: "int", nullable: true),
                    cus_id = table.Column<int>(type: "int", nullable: false),
                    prod_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.pay_id);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Products_prod_id",
                        column: x => x.prod_id,
                        principalTable: "Products",
                        principalColumn: "prod_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course_description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course_episode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cus_id = table.Column<int>(type: "int", nullable: false),
                    workout_id = table.Column<int>(type: "int", nullable: false),
                    pt_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.course_id);
                    table.ForeignKey(
                        name: "FK_Courses_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_PersonalTrainers_pt_id",
                        column: x => x.pt_id,
                        principalTable: "PersonalTrainers",
                        principalColumn: "pt_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_WorkoutPlans_workout_id",
                        column: x => x.workout_id,
                        principalTable: "WorkoutPlans",
                        principalColumn: "workout_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    exam_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    exam_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    exam_question = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course_id = table.Column<int>(type: "int", nullable: false),
                    pt_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.exam_id);
                    table.ForeignKey(
                        name: "FK_Examinations_Courses_course_id",
                        column: x => x.course_id,
                        principalTable: "Courses",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_PersonalTrainers_pt_id",
                        column: x => x.pt_id,
                        principalTable: "PersonalTrainers",
                        principalColumn: "pt_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessions",
                columns: table => new
                {
                    lession_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lession_context = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lesson_topic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessions", x => x.lession_id);
                    table.ForeignKey(
                        name: "FK_Lessions_Courses_course_id",
                        column: x => x.course_id,
                        principalTable: "Courses",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cus_id",
                table: "Carts",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_prod_id",
                table: "Carts",
                column: "prod_id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_cus_id",
                table: "Courses",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_pt_id",
                table: "Courses",
                column: "pt_id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_workout_id",
                table: "Courses",
                column: "workout_id");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_course_id",
                table: "Examinations",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_pt_id",
                table: "Examinations",
                column: "pt_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lessions_course_id",
                table: "Lessions",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_cus_id",
                table: "Notifications",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_pt_id",
                table: "Notifications",
                column: "pt_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_cus_id",
                table: "Orders",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_prod_id",
                table: "Orders",
                column: "prod_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_cus_id",
                table: "Payments",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_prod_id",
                table: "Payments",
                column: "prod_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_admin_id",
                table: "Posts",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_cus_id",
                table: "Posts",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_pt_id",
                table: "Posts",
                column: "pt_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_cate_id",
                table: "Products",
                column: "cate_id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlans_cus_id",
                table: "WorkoutPlans",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlans_exc_id",
                table: "WorkoutPlans",
                column: "exc_id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlans_pt_id",
                table: "WorkoutPlans",
                column: "pt_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "Lessions");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "SystemAdmins");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "WorkoutPlans");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "PersonalTrainers");
        }
    }
}
