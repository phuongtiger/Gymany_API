using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymany_API.Migrations
{
    public partial class Gymany_DbV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "admin_id", "admin_age", "admin_email", "admin_name", "admin_password", "admin_salary", "admin_username" },
                values: new object[] { 1, new DateTime(1996, 1, 16, 17, 48, 0, 473, DateTimeKind.Local).AddTicks(7842), "Ezekiel.Thompson@yahoo.com", "Gilberto Shields", "gymanyadmin@123", 4376.30m, "gymanyadmin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cate_id", "cate_description", "cate_img", "cate_type" },
                values: new object[,]
                {
                    { 9, "Voluptatibus quidem facere ut iusto eligendi nobis omnis. Nobis praesentium sed veniam molestiae minus numquam eligendi. Quos est autem et magni nam sint inventore autem.", "https://picsum.photos/640/480/?image=558", "Baby" },
                    { 8, "Sit inventore minus est ut. Modi laboriosam nemo delectus et ut. Et id provident cum. Voluptas minima occaecati vel autem enim dignissimos maiores molestias. Quia et aspernatur dolores dolor illum. Voluptatum accusamus neque assumenda reprehenderit quo tempore aliquid.", "https://picsum.photos/640/480/?image=496", "Computers" },
                    { 7, "Eaque asperiores velit molestias vel nostrum qui. Non commodi deserunt qui sed facere. Animi consequatur eaque qui veritatis aut expedita. Qui et dolorem dolor et quis voluptates.", "https://picsum.photos/640/480/?image=638", "Outdoors" },
                    { 6, "Dolores rerum ducimus rerum vel officia maxime delectus sed perspiciatis. Omnis quos rerum. Aut dolores suscipit eum quam. Magni quae nemo eum inventore illo. Sequi beatae quisquam tenetur. Fugiat sit modi quae nemo iste qui magni corrupti.", "https://picsum.photos/640/480/?image=125", "Kids" },
                    { 10, "Possimus minima aliquid non pariatur quis eum distinctio. Quos ipsa explicabo autem voluptate a. Laudantium aut blanditiis distinctio omnis voluptatem.", "https://picsum.photos/640/480/?image=921", "Grocery" },
                    { 4, "Laboriosam sit incidunt consequuntur. Est qui aut architecto in culpa nam quod ratione. Vitae ut magnam assumenda modi id reprehenderit nihil fugit exercitationem.", "https://picsum.photos/640/480/?image=768", "Jewelery" },
                    { 3, "Eum inventore repellendus sed et non quisquam. Molestiae quo quae dolore non aut. Quis cumque et repellat consequatur soluta ullam quo sed. Soluta id voluptas assumenda enim ut. Magni doloremque odio rerum.", "https://picsum.photos/640/480/?image=802", "Toys" },
                    { 2, "Nisi minus qui. Dolorum doloremque rerum sit voluptatem sapiente. Necessitatibus illum non laudantium earum laborum eum et et corrupti. Cum ex quis quo qui dolorem perspiciatis deserunt consequuntur recusandae. Id dolorem optio sunt repudiandae et et veritatis. Distinctio sapiente qui at doloremque numquam quo est minima.", "https://picsum.photos/640/480/?image=184", "Grocery" },
                    { 1, "Sapiente totam voluptatem corrupti perspiciatis aut officia. Ipsum et quo ea non praesentium hic dolorem. Molestiae quibusdam maxime nulla qui corporis porro saepe.", "https://picsum.photos/640/480/?image=165", "Kids" },
                    { 5, "Consequuntur officia doloribus et omnis doloremque aliquid quasi. Omnis dolorem eos quos aliquam consequatur minus. Qui voluptatibus dolores ex exercitationem provident itaque omnis dolorum hic.", "https://picsum.photos/640/480/?image=125", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "cus_id", "cus_address", "cus_age", "cus_email", "cus_image", "cus_name", "cus_password", "cus_phone", "cus_username" },
                values: new object[,]
                {
                    { 1, "3296 Mike Isle", new DateTime(1978, 2, 21, 21, 48, 5, 293, DateTimeKind.Local).AddTicks(9856), "Ettie_Gerlach@hotmail.com", "https://picsum.photos/640/480/?image=764", "Ignacio Gibson", "gymanycus@123", "(993) 883-2023", "gymanycus" },
                    { 2, "0632 Reynolds Street", new DateTime(1986, 11, 13, 13, 57, 19, 149, DateTimeKind.Local).AddTicks(7424), "Felipa.Marks92@yahoo.com", "https://picsum.photos/640/480/?image=310", "Talia Hayes", "gymanycus@123", "(121) 487-0502", "gymanycus" },
                    { 3, "52090 Jaskolski Underpass", new DateTime(1981, 7, 17, 8, 21, 58, 704, DateTimeKind.Local).AddTicks(352), "Aiden78@yahoo.com", "https://picsum.photos/640/480/?image=848", "Troy Dach", "gymanycus@123", "(556) 999-2455", "gymanycus" },
                    { 4, "4547 Marge Drive", new DateTime(1996, 6, 12, 9, 14, 1, 710, DateTimeKind.Local).AddTicks(68), "Darius_Purdy@gmail.com", "https://picsum.photos/640/480/?image=626", "Aimee Hoeger", "gymanycus@123", "(287) 972-6076", "gymanycus" },
                    { 5, "6246 Roob Fields", new DateTime(2003, 7, 30, 12, 16, 27, 473, DateTimeKind.Local).AddTicks(8719), "Kaylie.Kiehn73@gmail.com", "https://picsum.photos/640/480/?image=400", "Donnie Nicolas", "gymanycus@123", "(114) 266-2685", "gymanycus" }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "exc_id", "exc_description", "exc_guide", "exc_title", "exc_video" },
                values: new object[,]
                {
                    { 7, "Et iste est. A esse quia autem provident quia quis", "Enim distinctio dolorem velit corporis.", "Ut vel facilis.", "https://dedrick.info" },
                    { 10, "Illo nemo nihil ea est error cumque totam. Omnis o", "Qui beatae consequuntur quo quisquam.", "Excepturi autem sit.", "https://ignacio.biz" },
                    { 9, "Consequatur aut reprehenderit magni quibusdam earu", "Rerum voluptatem et reiciendis architecto.", "Iste laborum recusandae.", "http://otilia.net" },
                    { 8, "Expedita est numquam tenetur nihil. Mollitia corpo", "Aliquam non quo in possimus.", "Aut non et.", "http://deanna.org" },
                    { 6, "Est expedita est ipsum magnam. Aut eligendi archit", "Minus et sunt est quis.", "Sed modi ut.", "http://grant.com" },
                    { 5, "Occaecati ullam maiores deleniti dolores numquam f", "Amet reprehenderit quis voluptatem repudiandae.", "Mollitia itaque ab.", "https://arnulfo.biz" },
                    { 4, "Consequatur vero hic. Tempore eius non commodi par", "Corrupti et nihil id voluptatibus.", "Eum dolorem aut.", "https://bernita.biz" },
                    { 3, "Aut velit et numquam. Ipsum commodi harum ut. Saep", "Mollitia voluptas accusantium occaecati alias.", "Non labore perferendis.", "https://velda.org" },
                    { 2, "Tempora necessitatibus et. Voluptatem quod ab quas", "Et aut quis dignissimos consequatur.", "Voluptatem voluptates saepe.", "http://jamie.net" },
                    { 1, "Dolor officiis cumque sequi natus qui doloremque. ", "Veritatis eius repellat dignissimos inventore.", "Quo qui blanditiis.", "http://adaline.info" }
                });

            migrationBuilder.InsertData(
                table: "PersonalTrainers",
                columns: new[] { "pt_id", "pt_address", "pt_age", "pt_email", "pt_img", "pt_name", "pt_password", "pt_phone", "pt_salary", "pt_username" },
                values: new object[,]
                {
                    { 1, "257 Turner Passage, Titusview, Oman", new DateTime(1985, 5, 30, 12, 4, 14, 195, DateTimeKind.Local).AddTicks(9315), "Moshe_Hegmann@gmail.com", "https://picsum.photos/640/480/?image=837", "Kari Huel", "gymanypt@123", "(512) 005-9696", 4425.70m, "gymanypt" },
                    { 2, "07509 Kristian Meadows, Mannborough, Oman", new DateTime(1993, 11, 4, 14, 2, 46, 587, DateTimeKind.Local).AddTicks(5684), "Hilma61@gmail.com", "https://picsum.photos/640/480/?image=23", "Gayle Kessler", "gymanypt@123", "(022) 182-9938", 4171.46m, "gymanypt" },
                    { 3, "60903 Corwin Summit, South Camilla, Equatorial Gui", new DateTime(1991, 10, 24, 11, 52, 16, 838, DateTimeKind.Local).AddTicks(4025), "Clementine81@hotmail.com", "https://picsum.photos/640/480/?image=992", "Carleton Kulas", "gymanypt@123", "(119) 072-0722", 5104.61m, "gymanypt" },
                    { 4, "45029 Durward Lights, Howellton, Portugal", new DateTime(1997, 3, 30, 13, 12, 33, 46, DateTimeKind.Local).AddTicks(1010), "Marlene_Lind7@yahoo.com", "https://picsum.photos/640/480/?image=737", "Leonel Bins", "gymanypt@123", "(027) 455-2674", 6310.12m, "gymanypt" },
                    { 5, "21802 Beahan Trafficway, East Ezra, Equatorial Gui", new DateTime(1976, 2, 4, 8, 20, 23, 525, DateTimeKind.Local).AddTicks(9862), "Gaston.Runte@yahoo.com", "https://picsum.photos/640/480/?image=193", "Gayle Bergnaum", "gymanypt@123", "(486) 888-2345", 6928.51m, "gymanypt" }
                });

            migrationBuilder.InsertData(
                table: "SystemAdmins",
                columns: new[] { "sysad_id", "sysad_age", "sysad_email", "sysad_name", "sysad_password", "sysad_username" },
                values: new object[,]
                {
                    { 8, new DateTime(1977, 4, 26, 4, 3, 33, 152, DateTimeKind.Local).AddTicks(6133), "Eldred99@yahoo.com", "Erick Hirthe", "gymanysysadmin@123", "gymanysysadmin" },
                    { 7, new DateTime(1996, 11, 26, 2, 50, 9, 693, DateTimeKind.Local).AddTicks(4890), "Clovis_Hintz6@gmail.com", "Shane Fahey", "gymanysysadmin@123", "gymanysysadmin" },
                    { 6, new DateTime(1985, 9, 22, 3, 47, 30, 85, DateTimeKind.Local).AddTicks(838), "Ellis42@yahoo.com", "Abraham Waters", "gymanysysadmin@123", "gymanysysadmin" },
                    { 5, new DateTime(1997, 5, 21, 0, 14, 21, 444, DateTimeKind.Local).AddTicks(1597), "Terence76@gmail.com", "Lorna Jacobi", "gymanysysadmin@123", "gymanysysadmin" },
                    { 1, new DateTime(1981, 11, 13, 18, 13, 16, 417, DateTimeKind.Local).AddTicks(7918), "Aditya.Schiller32@yahoo.com", "Alfonso Stoltenberg", "gymanysysadmin@123", "gymanysysadmin" },
                    { 3, new DateTime(1986, 11, 21, 17, 52, 17, 247, DateTimeKind.Local).AddTicks(1354), "Valentin_Beier@yahoo.com", "Justice Gaylord", "gymanysysadmin@123", "gymanysysadmin" },
                    { 2, new DateTime(2000, 12, 30, 21, 38, 44, 115, DateTimeKind.Local).AddTicks(3661), "Teagan.Turner39@gmail.com", "Ottis Bergstrom", "gymanysysadmin@123", "gymanysysadmin" },
                    { 9, new DateTime(1991, 8, 24, 18, 38, 14, 884, DateTimeKind.Local).AddTicks(7593), "Arnaldo.Kris@yahoo.com", "Fiona Goyette", "gymanysysadmin@123", "gymanysysadmin" },
                    { 4, new DateTime(2005, 11, 30, 10, 5, 10, 332, DateTimeKind.Local).AddTicks(9644), "Destany66@gmail.com", "Hattie Senger", "gymanysysadmin@123", "gymanysysadmin" },
                    { 10, new DateTime(2006, 4, 16, 19, 34, 55, 597, DateTimeKind.Local).AddTicks(4009), "Sigmund63@yahoo.com", "Sophie O'Kon", "gymanysysadmin@123", "gymanysysadmin" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "noti_id", "cus_id", "noti_context", "noti_date", "noti_type", "pt_id" },
                values: new object[,]
                {
                    { 10, 1, "Nesciunt quasi ut omnis sapiente aut quos cum harum excepturi.", new DateTime(2024, 11, 1, 8, 58, 7, 169, DateTimeKind.Local).AddTicks(30), "Alert", 1 },
                    { 8, 1, "Atque ipsum sit est enim ullam nulla consectetur est eaque.", new DateTime(2024, 10, 31, 21, 8, 59, 749, DateTimeKind.Local).AddTicks(5836), "Warning", 1 },
                    { 7, 1, "Dolores eos odit delectus ut accusantium at distinctio incidunt quidem.", new DateTime(2024, 10, 31, 22, 0, 53, 882, DateTimeKind.Local).AddTicks(759), "Warning", 1 },
                    { 6, 1, "Enim ut nisi nesciunt quisquam omnis cupiditate quo sunt autem.", new DateTime(2024, 10, 31, 23, 40, 30, 454, DateTimeKind.Local).AddTicks(4050), "Info", 1 },
                    { 5, 1, "Distinctio numquam quis ut voluptatum ut aperiam earum in vel.", new DateTime(2024, 11, 1, 4, 7, 31, 531, DateTimeKind.Local).AddTicks(6203), "Warning", 1 },
                    { 4, 1, "Consequatur veniam omnis necessitatibus et perferendis beatae voluptatem officia eaque.", new DateTime(2024, 11, 1, 6, 55, 57, 529, DateTimeKind.Local).AddTicks(280), "Alert", 1 },
                    { 3, 1, "Cumque quae quia repellat ipsa est ea dolores eaque nisi.", new DateTime(2024, 11, 1, 6, 32, 33, 113, DateTimeKind.Local).AddTicks(9886), "Info", 1 },
                    { 2, 1, "Inventore sit numquam doloremque architecto aliquam accusantium voluptates reiciendis ab.", new DateTime(2024, 11, 1, 3, 30, 45, 109, DateTimeKind.Local).AddTicks(3274), "Warning", 1 },
                    { 1, 1, "Doloribus et aliquam suscipit assumenda corrupti delectus iure recusandae consequuntur.", new DateTime(2024, 11, 1, 16, 49, 46, 444, DateTimeKind.Local).AddTicks(404), "Info", 1 },
                    { 9, 1, "Tempore et animi dolorem excepturi aspernatur qui et consectetur dolores.", new DateTime(2024, 10, 31, 21, 4, 49, 927, DateTimeKind.Local).AddTicks(9289), "Alert", 1 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "post_id", "admin_id", "cus_id", "post_content", "post_date", "post_img", "post_title", "pt_id" },
                values: new object[,]
                {
                    { 2, 1, 1, "Commodi tenetur nesciunt nisi. Culpa dolore quaerat facilis architecto deleniti laborum repudiandae. Fugit nobis eum eum repudiandae ad placeat ut. Id aliquid nihil enim ipsam deserunt. Quidem quae aut. Aliquid omnis aut laboriosam aut sed voluptates et.", new DateTime(2024, 8, 12, 11, 30, 53, 970, DateTimeKind.Local).AddTicks(5167), "https://picsum.photos/640/480/?image=957", "Distinctio aperiam quo enim facere.", 1 },
                    { 4, 1, 1, "Quibusdam dolores ut sunt accusamus sit voluptatem aut. Enim rerum ipsum culpa. Ipsum iusto quis. Unde quaerat dolores. Autem aperiam nihil possimus iure delectus at non maxime eveniet.\n\nLaboriosam accusantium quis ducimus. Velit sit accusantium quam ullam iste impedit modi voluptatibus quo. Doloribus tempore quo nostrum laborum. Cumque quas eum fugit harum aliquid quia perferendis similique. Mollitia vel assumenda.", new DateTime(2024, 1, 24, 10, 18, 44, 832, DateTimeKind.Local).AddTicks(5492), "https://picsum.photos/640/480/?image=82", "Ratione et molestiae magni eos.", 1 },
                    { 5, 1, 1, "Asperiores sed voluptate aliquam officia eius. Inventore minima officia. Quia et veritatis at omnis fugiat. Ea minus molestias aut nulla non error velit et perspiciatis.\n\nQuas ipsam quia accusantium. Culpa tempora explicabo sed quibusdam dolores. Voluptatem temporibus minima qui sed eos ad commodi et sed. Omnis ut rerum. Adipisci eligendi reprehenderit sequi cupiditate commodi veritatis vitae.", new DateTime(2024, 9, 23, 11, 23, 3, 59, DateTimeKind.Local).AddTicks(6902), "https://picsum.photos/640/480/?image=598", "Quia sed quo tempore ad.", 1 },
                    { 6, 1, 1, "Occaecati autem illo recusandae. Repellat sed ut suscipit aut corporis consectetur dignissimos. Molestias necessitatibus doloremque. Qui rerum ut et aliquam impedit. Nihil commodi consectetur.\n\nQuas quo sint non ducimus sunt quidem voluptatem hic. Hic quaerat accusantium sunt dolor maiores. Omnis dolorem eum cupiditate suscipit tempora ut voluptatem.", new DateTime(2024, 2, 5, 3, 53, 13, 833, DateTimeKind.Local).AddTicks(1268), "https://picsum.photos/640/480/?image=685", "Saepe ut nisi fugiat eaque.", 1 },
                    { 7, 1, 1, "Laudantium cum sint est esse magnam. Qui placeat eligendi quo animi dolorem non sed doloremque. Accusantium et quis dolorem laborum unde voluptatem. Omnis exercitationem et repudiandae omnis itaque asperiores. Dolorum ipsam nemo possimus dolorem placeat.", new DateTime(2024, 10, 28, 10, 21, 18, 166, DateTimeKind.Local).AddTicks(6480), "https://picsum.photos/640/480/?image=597", "Dolores possimus rerum voluptatum minima.", 1 },
                    { 8, 1, 1, "Consequatur quae maiores est labore corporis at magni. Illo eos a sit sed maiores facere quisquam. Perspiciatis laborum consequatur. Quam ad atque provident veniam.\n\nQuo voluptatem dolor debitis porro. Porro tenetur ut voluptatem ipsam praesentium quia aut fugit rerum. Nihil ut corrupti cupiditate.", new DateTime(2024, 7, 18, 1, 21, 47, 540, DateTimeKind.Local).AddTicks(5395), "https://picsum.photos/640/480/?image=800", "Eum consectetur eum et et.", 1 },
                    { 9, 1, 1, "Voluptatem quisquam eos earum temporibus nobis beatae et. Enim quibusdam autem voluptas incidunt sequi harum dolorem. Iure nemo odit itaque facilis.\n\nArchitecto aliquid architecto vel dolorem sunt et sit omnis exercitationem. Ipsam neque quia sed aspernatur consequatur quo eius. Blanditiis ut mollitia est ad sunt quia voluptatem. Animi vitae architecto sed veritatis porro suscipit consequatur aut. Dolor iste consectetur quis recusandae esse.\n\nVoluptatibus amet non. Modi molestiae sit molestiae est. Molestiae ut mollitia assumenda et voluptas hic non nam. Aspernatur est accusamus sunt.", new DateTime(2024, 3, 17, 5, 13, 21, 888, DateTimeKind.Local).AddTicks(2534), "https://picsum.photos/640/480/?image=65", "Consequatur magnam eaque ipsum voluptatem.", 1 },
                    { 10, 1, 1, "Laboriosam dolores facilis corporis eos est aut. Doloribus culpa culpa ut accusamus velit harum et. Est placeat quia et autem. Sed exercitationem aut iure nulla. Nam sunt consectetur qui. Molestiae temporibus soluta.", new DateTime(2024, 3, 3, 23, 46, 2, 727, DateTimeKind.Local).AddTicks(2465), "https://picsum.photos/640/480/?image=668", "Est ut perferendis explicabo totam.", 1 },
                    { 3, 1, 1, "Modi et dignissimos dolorem non quam doloribus quia ut. Libero cupiditate odio iusto minus quia quia laboriosam sunt quae. Impedit consequatur ipsam aut reprehenderit. Beatae libero molestiae et dolorem cupiditate autem dolorem tempora exercitationem. Dolore eligendi ut et itaque voluptatibus voluptas.\n\nEa ut culpa iste deleniti pariatur omnis. Sint veniam consequuntur rerum eos occaecati voluptates. Quo et quas alias facilis est quas.", new DateTime(2024, 1, 7, 12, 10, 24, 579, DateTimeKind.Local).AddTicks(6124), "https://picsum.photos/640/480/?image=392", "Debitis et sunt aut optio.", 1 },
                    { 1, 1, 1, "Omnis eos sed. Neque similique molestiae. Atque magnam blanditiis ut. Et ab eaque voluptatibus ullam molestias rerum omnis. Ipsa nisi eum. Quidem non atque numquam sunt.\n\nDolores sapiente maxime non distinctio esse. Iure nulla tenetur veritatis quia optio et dignissimos nulla. Inventore incidunt sunt accusamus dolore cumque aspernatur. Sit aut non quo qui ut soluta quod repellendus. Eligendi nemo odit voluptatem.", new DateTime(2024, 4, 21, 11, 59, 57, 793, DateTimeKind.Local).AddTicks(1254), "https://picsum.photos/640/480/?image=1061", "Aut nam iste recusandae aut.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "prod_id", "cate_id", "prod_amount", "prod_description", "prod_img", "prod_name", "prod_price" },
                values: new object[,]
                {
                    { 3, 2, 31, "Accusantium iusto omnis aperiam id iste officia possimus.", "https://picsum.photos/640/480/?image=836", "Intelligent Metal Pants", 470.88m },
                    { 6, 10, 4, "Soluta recusandae voluptatum sint accusamus.", "https://picsum.photos/640/480/?image=53", "Tasty Metal Shirt", 458.20m },
                    { 2, 9, 69, "Aliquam totam voluptas quos iure.", "https://picsum.photos/640/480/?image=912", "Sleek Steel Salad", 491.38m },
                    { 1, 9, 84, "Et ut qui est itaque corrupti.", "https://picsum.photos/640/480/?image=720", "Gorgeous Granite Fish", 481.70m },
                    { 9, 8, 78, "Dolorem dolor maiores est.", "https://picsum.photos/640/480/?image=678", "Practical Wooden Car", 396.40m },
                    { 7, 6, 62, "Deleniti et ab aut.", "https://picsum.photos/640/480/?image=608", "Intelligent Cotton Shoes", 453.64m },
                    { 5, 6, 93, "Non aperiam error facere consequatur tempora sed dolor.", "https://picsum.photos/640/480/?image=491", "Small Granite Tuna", 153.30m },
                    { 8, 5, 90, "Consectetur ut amet nesciunt dolore.", "https://picsum.photos/640/480/?image=330", "Tasty Frozen Keyboard", 453.73m },
                    { 10, 3, 73, "Reprehenderit laboriosam dolores voluptatum possimus.", "https://picsum.photos/640/480/?image=1081", "Awesome Cotton Sausages", 174.18m },
                    { 4, 2, 1, "Aut sequi rerum praesentium facere voluptas.", "https://picsum.photos/640/480/?image=315", "Handcrafted Soft Pants", 398.52m }
                });

            migrationBuilder.InsertData(
                table: "WorkoutPlans",
                columns: new[] { "workout_id", "cus_id", "exc_id", "pt_id", "workout_activity", "workout_description", "workout_endDate", "workout_name", "workout_session", "workout_startDate" },
                values: new object[,]
                {
                    { 8, 1, 1, 1, "Consectetur cumque repellendus consequatur tenetur hic.", "Vitae repudiandae voluptates enim necessitatibus eos sunt. Quibusdam nemo quod quis hic omnis. Ad et ut culpa aut ipsa quam non necessitatibus. Dolorem dolores sunt.", new DateTime(2024, 5, 21, 6, 32, 49, 182, DateTimeKind.Local).AddTicks(6480), "Handcrafted Concrete Tuna", "parsing", new DateTime(2024, 3, 21, 6, 32, 49, 182, DateTimeKind.Local).AddTicks(6480) },
                    { 7, 1, 10, 1, "Eos iure nulla dolorum saepe sed.", "Provident ea saepe et eos suscipit.", new DateTime(2025, 2, 17, 11, 11, 53, 112, DateTimeKind.Local).AddTicks(7592), "Fantastic Granite Cheese", "Valley", new DateTime(2024, 10, 17, 11, 11, 53, 112, DateTimeKind.Local).AddTicks(7592) },
                    { 6, 1, 10, 1, "Et adipisci et aut autem molestias.", "Quia aliquid et explicabo quod doloremque deleniti necessitatibus. Esse quia voluptatem et ea. Odio suscipit quia qui nemo libero et.", new DateTime(2024, 6, 16, 10, 21, 14, 542, DateTimeKind.Local).AddTicks(5832), "Fantastic Fresh Mouse", "Soft", new DateTime(2024, 1, 16, 10, 21, 14, 542, DateTimeKind.Local).AddTicks(5832) },
                    { 5, 1, 8, 1, "Quo dolor voluptatem ad ut voluptas unde.", "Cupiditate nulla porro pariatur voluptatem est laudantium et excepturi. Ut eum ratione qui dolor velit. Voluptatem quae itaque ullam harum. Ullam facilis rerum ratione odit qui quasi.", new DateTime(2024, 11, 2, 19, 52, 33, 973, DateTimeKind.Local).AddTicks(352), "Ergonomic Soft Fish", "Wooden", new DateTime(2024, 6, 2, 19, 52, 33, 973, DateTimeKind.Local).AddTicks(352) },
                    { 1, 1, 4, 1, "At omnis ipsum molestiae optio quo consequuntur quisquam officiis ratione.", "Error repellendus eaque vel. Voluptatibus repellendus vel et itaque sit enim nisi non facilis.", new DateTime(2024, 6, 30, 0, 39, 48, 144, DateTimeKind.Local).AddTicks(9236), "Handcrafted Soft Pizza", "open-source", new DateTime(2024, 1, 30, 0, 39, 48, 144, DateTimeKind.Local).AddTicks(9236) },
                    { 3, 1, 3, 1, "Possimus omnis ea cumque enim consequatur ratione est ut.", "Ipsa ratione voluptatibus nobis ea rerum reprehenderit distinctio facilis. Alias esse officiis debitis dolorem odio. Voluptatem fugit eum quos quae sequi officia optio. Cum beatae quia.", new DateTime(2025, 1, 23, 8, 32, 16, 625, DateTimeKind.Local).AddTicks(1192), "Incredible Concrete Ball", "Automotive", new DateTime(2024, 9, 23, 8, 32, 16, 625, DateTimeKind.Local).AddTicks(1192) },
                    { 2, 1, 1, 1, "Aperiam alias et nulla aut quod sapiente dolores.", "Ea in voluptatem velit omnis facere iste qui unde.", new DateTime(2024, 11, 3, 13, 32, 9, 782, DateTimeKind.Local).AddTicks(1439), "Rustic Fresh Chair", "Zimbabwe Dollar", new DateTime(2024, 7, 3, 13, 32, 9, 782, DateTimeKind.Local).AddTicks(1439) },
                    { 9, 1, 3, 1, "Aut iusto repudiandae minima sequi debitis facere cumque non tempore.", "Est aliquam numquam recusandae rerum tempora quo distinctio doloremque non. Iure voluptatem tempora quisquam facilis atque distinctio illum. Omnis officia neque delectus consequatur quia consequatur eius quibusdam asperiores.", new DateTime(2024, 10, 16, 7, 25, 36, 846, DateTimeKind.Local).AddTicks(7682), "Handcrafted Soft Bacon", "invoice", new DateTime(2024, 6, 16, 7, 25, 36, 846, DateTimeKind.Local).AddTicks(7682) },
                    { 4, 1, 2, 1, "Suscipit facilis eos explicabo distinctio.", "Ut a non laborum nemo repellat doloribus reprehenderit doloribus.", new DateTime(2024, 9, 28, 18, 30, 36, 127, DateTimeKind.Local).AddTicks(7070), "Practical Soft Towels", "concept", new DateTime(2024, 7, 28, 18, 30, 36, 127, DateTimeKind.Local).AddTicks(7070) },
                    { 10, 1, 9, 1, "Dolorum eos dolores.", "Porro assumenda facilis voluptas sit.", new DateTime(2024, 6, 30, 6, 41, 55, 762, DateTimeKind.Local).AddTicks(4417), "Rustic Rubber Sausages", "Gorgeous", new DateTime(2023, 12, 31, 6, 41, 55, 762, DateTimeKind.Local).AddTicks(4417) }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_id", "cart_quantity", "cus_id", "prod_id" },
                values: new object[,]
                {
                    { 5, 9, 1, 3 },
                    { 2, 2, 1, 2 },
                    { 10, 10, 1, 7 },
                    { 8, 5, 1, 5 },
                    { 9, 10, 1, 8 },
                    { 1, 6, 1, 8 },
                    { 7, 4, 1, 10 },
                    { 4, 2, 1, 10 },
                    { 6, 8, 1, 9 },
                    { 3, 1, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "course_id", "course_description", "course_episode", "course_title", "cus_id", "pt_id", "workout_id" },
                values: new object[,]
                {
                    { 6, "Cumque quisquam amet quod laudantium atque minima ", "4", "Refined Cotton Chips", 1, 1, 10 },
                    { 3, "Quia illum quod et adipisci ex. Deserunt fugiat cu", "11", "Tasty Wooden Sausages", 1, 1, 9 },
                    { 2, "Animi delectus earum earum perspiciatis porro sed.", "6", "Small Fresh Chips", 1, 1, 8 },
                    { 10, "Ut sit quasi reiciendis et assumenda omnis sint bl", "13", "Small Rubber Fish", 1, 1, 7 },
                    { 4, "Quia aspernatur consequatur quia quos dolor. In ma", "9", "Handmade Metal Chair", 1, 1, 7 },
                    { 5, "Omnis non dolorem. Odit sint eius quasi. Commodi d", "16", "Ergonomic Soft Chair", 1, 1, 5 },
                    { 1, "Labore consequuntur impedit commodi qui unde. Volu", "8", "Fantastic Frozen Chair", 1, 1, 5 },
                    { 8, "Tempora asperiores consectetur exercitationem eaqu", "18", "Sleek Steel Shirt", 1, 1, 4 },
                    { 9, "Sequi aliquid tempore maiores suscipit nulla volup", "2", "Awesome Soft Table", 1, 1, 1 },
                    { 7, "Perferendis laboriosam voluptas dolor id veniam. P", "6", "Rustic Frozen Shirt", 1, 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "order_id", "cus_id", "order_quantity", "order_startDate", "order_status", "order_totalPrice", "prod_id" },
                values: new object[,]
                {
                    { 1, 1, 5, new DateTime(2024, 10, 31, 18, 40, 48, 478, DateTimeKind.Local).AddTicks(9395), "Pending", 416.24m, 6 },
                    { 9, 1, 5, new DateTime(2024, 11, 1, 13, 1, 6, 33, DateTimeKind.Local).AddTicks(9890), "Completed", 250.66m, 2 },
                    { 6, 1, 5, new DateTime(2024, 11, 1, 4, 43, 8, 773, DateTimeKind.Local).AddTicks(6569), "Completed", 131.03m, 3 },
                    { 3, 1, 4, new DateTime(2024, 11, 1, 6, 21, 26, 429, DateTimeKind.Local).AddTicks(1735), "Pending", 172.60m, 4 },
                    { 2, 1, 5, new DateTime(2024, 11, 1, 8, 48, 59, 594, DateTimeKind.Local).AddTicks(1452), "Canceled", 253.93m, 4 },
                    { 10, 1, 2, new DateTime(2024, 10, 31, 19, 58, 8, 649, DateTimeKind.Local).AddTicks(4750), "Completed", 467.16m, 9 },
                    { 5, 1, 4, new DateTime(2024, 11, 1, 5, 44, 8, 497, DateTimeKind.Local).AddTicks(7617), "Pending", 431.51m, 7 },
                    { 7, 1, 4, new DateTime(2024, 11, 1, 14, 5, 20, 748, DateTimeKind.Local).AddTicks(7466), "Completed", 409.24m, 3 },
                    { 4, 1, 2, new DateTime(2024, 11, 1, 12, 44, 15, 478, DateTimeKind.Local).AddTicks(8512), "Pending", 368.74m, 5 },
                    { 8, 1, 2, new DateTime(2024, 11, 1, 10, 37, 9, 740, DateTimeKind.Local).AddTicks(4530), "Pending", 396.79m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "pay_id", "cus_id", "pay_date", "pay_quantity", "prod_id" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2024, 11, 1, 7, 15, 42, 85, DateTimeKind.Local).AddTicks(5254), 4, 1 },
                    { 5, 1, new DateTime(2024, 11, 1, 4, 35, 32, 167, DateTimeKind.Local).AddTicks(5773), 8, 9 },
                    { 6, 1, new DateTime(2024, 11, 1, 13, 56, 7, 916, DateTimeKind.Local).AddTicks(7150), 7, 6 },
                    { 8, 1, new DateTime(2024, 11, 1, 6, 32, 41, 551, DateTimeKind.Local).AddTicks(7852), 4, 6 },
                    { 3, 1, new DateTime(2024, 11, 1, 14, 34, 15, 145, DateTimeKind.Local).AddTicks(7071), 1, 3 },
                    { 2, 1, new DateTime(2024, 10, 31, 22, 48, 20, 346, DateTimeKind.Local).AddTicks(4974), 5, 8 },
                    { 4, 1, new DateTime(2024, 11, 1, 14, 35, 22, 502, DateTimeKind.Local).AddTicks(8163), 4, 3 },
                    { 1, 1, new DateTime(2024, 11, 1, 5, 1, 56, 107, DateTimeKind.Local).AddTicks(7463), 4, 10 },
                    { 9, 1, new DateTime(2024, 10, 31, 18, 44, 4, 444, DateTimeKind.Local).AddTicks(3406), 1, 1 },
                    { 10, 1, new DateTime(2024, 10, 31, 19, 36, 12, 852, DateTimeKind.Local).AddTicks(3191), 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "Examinations",
                columns: new[] { "exam_id", "course_id", "exam_question", "exam_title", "pt_id" },
                values: new object[,]
                {
                    { 1, 9, "Unde in veritatis vel quasi eaque qui praesentium ", "Licensed Rubber Pizza", 1 },
                    { 10, 7, "Nihil aut veritatis fuga id dolorem nobis accusant", "Awesome Cotton Gloves", 1 },
                    { 8, 2, "Debitis perspiciatis tenetur minima aut quo eos ne", "Intelligent Plastic Shirt", 1 },
                    { 7, 5, "Hic possimus maiores ut accusantium esse itaque ev", "Sleek Steel Car", 1 },
                    { 6, 5, "Non vitae occaecati non quo voluptates iste natus ", "Refined Frozen Gloves", 1 },
                    { 5, 6, "Molestias sunt et dignissimos omnis perspiciatis e", "Tasty Rubber Soap", 1 },
                    { 2, 8, "Placeat sed consequatur autem est deserunt magnam ", "Sleek Granite Chips", 1 },
                    { 9, 9, "Occaecati in ut quis quas sapiente inventore optio", "Handcrafted Steel Sausages", 1 },
                    { 3, 9, "Nihil adipisci architecto maiores rerum et consequ", "Generic Concrete Mouse", 1 },
                    { 4, 1, "Ea voluptas in cupiditate voluptatem est eos aliqu", "Gorgeous Soft Pants", 1 }
                });

            migrationBuilder.InsertData(
                table: "Lessions",
                columns: new[] { "lession_id", "course_id", "lession_context", "lesson_topic" },
                values: new object[,]
                {
                    { 1, 5, "Explicabo alias nesciunt. Quis facere non reprehen", "Aut natus inventore." },
                    { 10, 5, "Voluptatibus ex excepturi quia enim ut minima repe", "Neque harum quisquam." },
                    { 4, 7, "Optio velit sapiente odit eligendi exercitationem ", "Sit reprehenderit est." },
                    { 7, 10, "Hic esse qui itaque earum. Laborum ut quia quis qu", "Dolores ex nemo." },
                    { 2, 2, "Nihil possimus vel laborum optio voluptate nobis e", "Ad qui quam." },
                    { 6, 2, "Ipsum amet nobis molestiae dolorum repellat consec", "Dolores rem quis." },
                    { 8, 2, "Omnis est quis nulla ipsum reprehenderit ipsam und", "Quis aut ex." },
                    { 9, 2, "Sed qui esse molestiae. Tenetur vitae doloribus au", "Ipsum unde mollitia." },
                    { 3, 3, "Nesciunt harum perferendis eos nostrum est laborio", "Rerum ut rerum." },
                    { 5, 4, "Praesentium eos fugiat quo doloribus tempore asper", "Aperiam facilis maxime." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cart_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "cus_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "cus_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "cus_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "cus_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "exam_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessions",
                keyColumn: "lession_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "noti_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "pay_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PersonalTrainers",
                keyColumn: "pt_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonalTrainers",
                keyColumn: "pt_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonalTrainers",
                keyColumn: "pt_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PersonalTrainers",
                keyColumn: "pt_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "post_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SystemAdmins",
                keyColumn: "sysad_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "admin_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "course_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "prod_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cate_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkoutPlans",
                keyColumn: "workout_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "cus_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "exc_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PersonalTrainers",
                keyColumn: "pt_id",
                keyValue: 1);
        }
    }
}
