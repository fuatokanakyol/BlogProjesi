using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DalExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50af10d0-f4cc-4f84-b435-bea11b9a843f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("516e4bed-5bd3-4067-aea2-13b9bdc58b89"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("18a04eff-4abb-45fa-9f7c-673299c46aa2"), new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"), "Visual Studio Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.", "Admin Test", new DateTime(2023, 12, 8, 19, 3, 9, 183, DateTimeKind.Local).AddTicks(7656), null, null, new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"), false, null, null, "Visual Studio Deneme Makale", 15 },
                    { new Guid("7c2742b0-0464-4a2c-921c-bdc2f519d89d"), new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"), "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.", "Admin Test", new DateTime(2023, 12, 8, 19, 3, 9, 183, DateTimeKind.Local).AddTicks(7650), null, null, new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"), false, null, null, "Asp.NetCore Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 8, 19, 3, 9, 183, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 8, 19, 3, 9, 183, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 8, 19, 3, 9, 183, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 8, 19, 3, 9, 183, DateTimeKind.Local).AddTicks(8011));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("18a04eff-4abb-45fa-9f7c-673299c46aa2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7c2742b0-0464-4a2c-921c-bdc2f519d89d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("50af10d0-f4cc-4f84-b435-bea11b9a843f"), new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"), "Visual Studio Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.", "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(768), null, null, new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"), false, null, null, "Visual Studio Deneme Makale", 15 },
                    { new Guid("516e4bed-5bd3-4067-aea2-13b9bdc58b89"), new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"), "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.", "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(761), null, null, new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"), false, null, null, "Asp.NetCore Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1149));
        }
    }
}
