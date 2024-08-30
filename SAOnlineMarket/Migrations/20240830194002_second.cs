using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAOnlineMarket.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductImage",
                value: "https://media.newyorker.com/photos/630e85c820c2208e4152741d/master/pass/Cassidy-Biden-Month.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductImage",
                value: "https://i.redd.it/3z3f8y6u1fn81.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductImage",
                value: "https://www.dogly.co.uk/wp-content/uploads/dog-with-a-huge-tongue.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ProductImage",
                value: "https://media-cldnry.s-nbcnews.com/image/upload/t_focal-440x220,f_auto,q_auto:best/rockcms/2024-08/240826-donald-trump-pro-choice-republicans-wm-146p-6025d1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductImage",
                value: "https://i.pinimg.com/736x/0c/2f/50/0c2f50dd058a1409a390ae68de5dabdd.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductImage",
                value: "https://media.newyorker.com/photos/590971f6c14b3c606c108102/master/pass/Crouch-Understanding-Obama-Basketball.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductImage",
                value: "https://tenor.com/view/joe-biden-presidential-debate-huh-confused-gif-16704157274113773062");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductImage",
                value: "https://tenor.com/view/qurial-bleeeh-cat-meme-qvrial-gif-27229139");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductImage",
                value: "https://tenor.com/view/freaky-dog-im-fr-an-eater-qazira-dog-tongue-freaky-dog-tongue-gif-14576727459878736156");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ProductImage",
                value: "https://tenor.com/view/trump-dance-trump-party-gif-16998177");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductImage",
                value: "https://tenor.com/view/nicholas-cage-ghost-rider-sus-dead-funny-gif-27534726");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductImage",
                value: "https://tenor.com/view/obama-obama-cartwheel-goodbye-chat-goodbyechat-gif-11045688346184983142");
        }
    }
}
