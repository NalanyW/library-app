using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class BookProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Location", "Price", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", "Verdieping 1", 8.9900000000000002, "Harry Potter: 1", 1998 },
                    { 2, "J.K. Rowling", "Verdieping 2", 8.9900000000000002, "Harry Potter: 2", 1999 },
                    { 3, "J.K. Rowling", "Verdieping 3", 8.9900000000000002, "Harry Potter: 3", 2000 },
                    { 4, "J.K. Rowling", "Verdieping 4", 8.9900000000000002, "Harry Potter: 4", 2001 },
                    { 5, "J.K. Rowling", "Verdieping 5", 8.9900000000000002, "Harry Potter: 5", 2002 },
                    { 6, "J.K. Rowling", "Verdieping 6", 8.9900000000000002, "Harry Potter: 6", 2003 },
                    { 7, "J.K. Rowling", "Verdieping 7", 8.9900000000000002, "Harry Potter: 7", 2004 },
                    { 8, "J.K. Rowling", "Verdieping 8", 8.9900000000000002, "Harry Potter: 8", 2005 },
                    { 9, "J.K. Rowling", "Verdieping 9", 8.9900000000000002, "Harry Potter: 9", 2006 },
                    { 10, "J.K. Rowling", "Verdieping 10", 8.9900000000000002, "Harry Potter: 10", 2007 },
                    { 11, "J.K. Rowling", "Verdieping 11", 8.9900000000000002, "Harry Potter: 11", 2008 },
                    { 12, "J.K. Rowling", "Verdieping 12", 8.9900000000000002, "Harry Potter: 12", 2009 },
                    { 13, "J.K. Rowling", "Verdieping 13", 8.9900000000000002, "Harry Potter: 13", 2010 },
                    { 14, "J.K. Rowling", "Verdieping 14", 8.9900000000000002, "Harry Potter: 14", 2011 },
                    { 15, "J.K. Rowling", "Verdieping 15", 8.9900000000000002, "Harry Potter: 15", 2012 },
                    { 16, "J.K. Rowling", "Verdieping 16", 8.9900000000000002, "Harry Potter: 16", 2013 },
                    { 17, "J.K. Rowling", "Verdieping 17", 8.9900000000000002, "Harry Potter: 17", 2014 },
                    { 18, "J.K. Rowling", "Verdieping 18", 8.9900000000000002, "Harry Potter: 18", 2015 },
                    { 19, "J.K. Rowling", "Verdieping 19", 8.9900000000000002, "Harry Potter: 19", 2016 },
                    { 20, "J.K. Rowling", "Verdieping 20", 8.9900000000000002, "Harry Potter: 20", 2017 },
                    { 21, "J.K. Rowling", "Verdieping 21", 8.9900000000000002, "Harry Potter: 21", 2018 },
                    { 22, "J.K. Rowling", "Verdieping 22", 8.9900000000000002, "Harry Potter: 22", 2019 },
                    { 23, "J.K. Rowling", "Verdieping 23", 8.9900000000000002, "Harry Potter: 23", 2020 },
                    { 24, "J.K. Rowling", "Verdieping 24", 8.9900000000000002, "Harry Potter: 24", 2021 },
                    { 25, "J.K. Rowling", "Verdieping 25", 8.9900000000000002, "Harry Potter: 25", 2022 },
                    { 26, "J.K. Rowling", "Verdieping 26", 8.9900000000000002, "Harry Potter: 26", 2023 },
                    { 27, "J.K. Rowling", "Verdieping 27", 8.9900000000000002, "Harry Potter: 27", 2024 },
                    { 28, "J.K. Rowling", "Verdieping 28", 8.9900000000000002, "Harry Potter: 28", 2025 },
                    { 29, "J.K. Rowling", "Verdieping 29", 8.9900000000000002, "Harry Potter: 29", 2026 },
                    { 30, "J.K. Rowling", "Verdieping 30", 8.9900000000000002, "Harry Potter: 30", 2027 },
                    { 31, "J.K. Rowling", "Verdieping 31", 8.9900000000000002, "Harry Potter: 31", 2028 },
                    { 32, "J.K. Rowling", "Verdieping 32", 8.9900000000000002, "Harry Potter: 32", 2029 },
                    { 33, "J.K. Rowling", "Verdieping 33", 8.9900000000000002, "Harry Potter: 33", 2030 },
                    { 34, "J.K. Rowling", "Verdieping 34", 8.9900000000000002, "Harry Potter: 34", 2031 },
                    { 35, "J.K. Rowling", "Verdieping 35", 8.9900000000000002, "Harry Potter: 35", 2032 },
                    { 36, "J.K. Rowling", "Verdieping 36", 8.9900000000000002, "Harry Potter: 36", 2033 },
                    { 37, "J.K. Rowling", "Verdieping 37", 8.9900000000000002, "Harry Potter: 37", 2034 },
                    { 38, "J.K. Rowling", "Verdieping 38", 8.9900000000000002, "Harry Potter: 38", 2035 },
                    { 39, "J.K. Rowling", "Verdieping 39", 8.9900000000000002, "Harry Potter: 39", 2036 },
                    { 40, "J.K. Rowling", "Verdieping 40", 8.9900000000000002, "Harry Potter: 40", 2037 },
                    { 41, "J.K. Rowling", "Verdieping 41", 8.9900000000000002, "Harry Potter: 41", 2038 },
                    { 42, "J.K. Rowling", "Verdieping 42", 8.9900000000000002, "Harry Potter: 42", 2039 },
                    { 43, "J.K. Rowling", "Verdieping 43", 8.9900000000000002, "Harry Potter: 43", 2040 },
                    { 44, "J.K. Rowling", "Verdieping 44", 8.9900000000000002, "Harry Potter: 44", 2041 },
                    { 45, "J.K. Rowling", "Verdieping 45", 8.9900000000000002, "Harry Potter: 45", 2042 },
                    { 46, "J.K. Rowling", "Verdieping 46", 8.9900000000000002, "Harry Potter: 46", 2043 },
                    { 47, "J.K. Rowling", "Verdieping 47", 8.9900000000000002, "Harry Potter: 47", 2044 },
                    { 48, "J.K. Rowling", "Verdieping 48", 8.9900000000000002, "Harry Potter: 48", 2045 },
                    { 49, "J.K. Rowling", "Verdieping 49", 8.9900000000000002, "Harry Potter: 49", 2046 },
                    { 50, "J.K. Rowling", "Verdieping 50", 8.9900000000000002, "Harry Potter: 50", 2047 },
                    { 51, "J.K. Rowling", "Verdieping 51", 8.9900000000000002, "Harry Potter: 51", 2048 },
                    { 52, "J.K. Rowling", "Verdieping 52", 8.9900000000000002, "Harry Potter: 52", 2049 },
                    { 53, "J.K. Rowling", "Verdieping 53", 8.9900000000000002, "Harry Potter: 53", 2050 },
                    { 54, "J.K. Rowling", "Verdieping 54", 8.9900000000000002, "Harry Potter: 54", 2051 },
                    { 55, "J.K. Rowling", "Verdieping 55", 8.9900000000000002, "Harry Potter: 55", 2052 },
                    { 56, "J.K. Rowling", "Verdieping 56", 8.9900000000000002, "Harry Potter: 56", 2053 },
                    { 57, "J.K. Rowling", "Verdieping 57", 8.9900000000000002, "Harry Potter: 57", 2054 },
                    { 58, "J.K. Rowling", "Verdieping 58", 8.9900000000000002, "Harry Potter: 58", 2055 },
                    { 59, "J.K. Rowling", "Verdieping 59", 8.9900000000000002, "Harry Potter: 59", 2056 },
                    { 60, "J.K. Rowling", "Verdieping 60", 8.9900000000000002, "Harry Potter: 60", 2057 },
                    { 61, "J.K. Rowling", "Verdieping 61", 8.9900000000000002, "Harry Potter: 61", 2058 },
                    { 62, "J.K. Rowling", "Verdieping 62", 8.9900000000000002, "Harry Potter: 62", 2059 },
                    { 63, "J.K. Rowling", "Verdieping 63", 8.9900000000000002, "Harry Potter: 63", 2060 },
                    { 64, "J.K. Rowling", "Verdieping 64", 8.9900000000000002, "Harry Potter: 64", 2061 },
                    { 65, "J.K. Rowling", "Verdieping 65", 8.9900000000000002, "Harry Potter: 65", 2062 },
                    { 66, "J.K. Rowling", "Verdieping 66", 8.9900000000000002, "Harry Potter: 66", 2063 },
                    { 67, "J.K. Rowling", "Verdieping 67", 8.9900000000000002, "Harry Potter: 67", 2064 },
                    { 68, "J.K. Rowling", "Verdieping 68", 8.9900000000000002, "Harry Potter: 68", 2065 },
                    { 69, "J.K. Rowling", "Verdieping 69", 8.9900000000000002, "Harry Potter: 69", 2066 },
                    { 70, "J.K. Rowling", "Verdieping 70", 8.9900000000000002, "Harry Potter: 70", 2067 },
                    { 71, "J.K. Rowling", "Verdieping 71", 8.9900000000000002, "Harry Potter: 71", 2068 },
                    { 72, "J.K. Rowling", "Verdieping 72", 8.9900000000000002, "Harry Potter: 72", 2069 },
                    { 73, "J.K. Rowling", "Verdieping 73", 8.9900000000000002, "Harry Potter: 73", 2070 },
                    { 74, "J.K. Rowling", "Verdieping 74", 8.9900000000000002, "Harry Potter: 74", 2071 },
                    { 75, "J.K. Rowling", "Verdieping 75", 8.9900000000000002, "Harry Potter: 75", 2072 },
                    { 76, "J.K. Rowling", "Verdieping 76", 8.9900000000000002, "Harry Potter: 76", 2073 },
                    { 77, "J.K. Rowling", "Verdieping 77", 8.9900000000000002, "Harry Potter: 77", 2074 },
                    { 78, "J.K. Rowling", "Verdieping 78", 8.9900000000000002, "Harry Potter: 78", 2075 },
                    { 79, "J.K. Rowling", "Verdieping 79", 8.9900000000000002, "Harry Potter: 79", 2076 },
                    { 80, "J.K. Rowling", "Verdieping 80", 8.9900000000000002, "Harry Potter: 80", 2077 },
                    { 81, "J.K. Rowling", "Verdieping 81", 8.9900000000000002, "Harry Potter: 81", 2078 },
                    { 82, "J.K. Rowling", "Verdieping 82", 8.9900000000000002, "Harry Potter: 82", 2079 },
                    { 83, "J.K. Rowling", "Verdieping 83", 8.9900000000000002, "Harry Potter: 83", 2080 },
                    { 84, "J.K. Rowling", "Verdieping 84", 8.9900000000000002, "Harry Potter: 84", 2081 },
                    { 85, "J.K. Rowling", "Verdieping 85", 8.9900000000000002, "Harry Potter: 85", 2082 },
                    { 86, "J.K. Rowling", "Verdieping 86", 8.9900000000000002, "Harry Potter: 86", 2083 },
                    { 87, "J.K. Rowling", "Verdieping 87", 8.9900000000000002, "Harry Potter: 87", 2084 },
                    { 88, "J.K. Rowling", "Verdieping 88", 8.9900000000000002, "Harry Potter: 88", 2085 },
                    { 89, "J.K. Rowling", "Verdieping 89", 8.9900000000000002, "Harry Potter: 89", 2086 },
                    { 90, "J.K. Rowling", "Verdieping 90", 8.9900000000000002, "Harry Potter: 90", 2087 },
                    { 91, "J.K. Rowling", "Verdieping 91", 8.9900000000000002, "Harry Potter: 91", 2088 },
                    { 92, "J.K. Rowling", "Verdieping 92", 8.9900000000000002, "Harry Potter: 92", 2089 },
                    { 93, "J.K. Rowling", "Verdieping 93", 8.9900000000000002, "Harry Potter: 93", 2090 },
                    { 94, "J.K. Rowling", "Verdieping 94", 8.9900000000000002, "Harry Potter: 94", 2091 },
                    { 95, "J.K. Rowling", "Verdieping 95", 8.9900000000000002, "Harry Potter: 95", 2092 },
                    { 96, "J.K. Rowling", "Verdieping 96", 8.9900000000000002, "Harry Potter: 96", 2093 },
                    { 97, "J.K. Rowling", "Verdieping 97", 8.9900000000000002, "Harry Potter: 97", 2094 },
                    { 98, "J.K. Rowling", "Verdieping 98", 8.9900000000000002, "Harry Potter: 98", 2095 },
                    { 99, "J.K. Rowling", "Verdieping 99", 8.9900000000000002, "Harry Potter: 99", 2096 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
