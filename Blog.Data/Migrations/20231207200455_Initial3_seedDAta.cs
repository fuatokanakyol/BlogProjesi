using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class Initial3_seedDAta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"), "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1024), null, null, false, null, null, "Asp.Net Core" },
                    { new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"), "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1020), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"), "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1163), null, null, "images/testİmage", "png", false, null, null },
                    { new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"), "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(1149), null, null, "images/testİmage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("50af10d0-f4cc-4f84-b435-bea11b9a843f"), new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"), "Visual Studio Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.", "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(768), null, null, new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"), false, null, null, "Visual Studio Deneme Makale", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("516e4bed-5bd3-4067-aea2-13b9bdc58b89"), new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"), "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.", "Admin Test", new DateTime(2023, 12, 7, 23, 4, 55, 17, DateTimeKind.Local).AddTicks(761), null, null, new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"), false, null, null, "Asp.NetCore Deneme Makalesi", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50af10d0-f4cc-4f84-b435-bea11b9a843f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("516e4bed-5bd3-4067-aea2-13b9bdc58b89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20c58b99-ecc0-4076-aa4d-6f8cb23a8c40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb65ea37-814c-44a5-9804-83b10b452b2e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("574542ea-0be2-48bc-b1f2-b36574164e32"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fe54d4fa-05ee-4c8d-aabe-dcf2e19f3961"));
        }
    }
}
