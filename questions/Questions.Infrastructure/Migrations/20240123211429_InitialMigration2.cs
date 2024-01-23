using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Questions.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("06bea67c-e86d-4fc9-8857-a7b3797912b8"));

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("35ce72b1-f4b1-4aad-956a-14d2bc7510cf"));

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("9450bd81-6e0f-4a63-91c3-a86d6d03f438"));

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("fae479c3-d26b-403c-a8e3-6f364897a2b3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("007718f0-40be-444d-a9e2-9d04e2a7fe92"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("013d2c0a-4f8d-4a98-9a79-34b059f83724"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0299e449-de86-429a-a0b5-1d3a6c62c5b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("03b9c2eb-b458-49ff-bcf5-50eb2621be6e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("04bee438-d945-4d95-ad76-3bec668ec8bb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0552ec0e-7915-412a-8520-17697e24ef31"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("05665ebe-138f-41e4-8fdb-9ec4c72fd42a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("05939205-cb07-4f23-823f-4a7d1ce9dfd4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("09341edd-b7a5-48de-a0ce-59709a930c9a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("097359c4-3de3-4ee2-b4c1-907054f61ec7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("09eae68f-ebc0-4e68-9e5b-bf9b20321be5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0ac2c888-883f-4762-be9a-b51eca981d9c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0afbd27b-54a7-4776-b001-4019000142cc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b8382f0-f9b0-4161-a3ec-129dbfc5e339"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0c7a8e8a-a7df-47bc-b986-8d8c531812c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0cc31591-6e32-4d5b-b8b6-1ec82a90e62a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0cdc4bd9-3cfd-40f5-88c8-66dd225ddc12"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0ddfad65-2347-4296-962c-0e9acec991dd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0e297ce7-581d-4179-aa74-1363c976803a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0e7d9f54-b770-4975-a999-25cea53f68a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f9860c2-faf5-4cab-919b-740b32d4a129"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0fbd8d16-8598-4d58-b082-279d5f839cd4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("10b905f9-5777-4066-a994-fd3c007dd12e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("115af467-6e9e-4ea0-9504-9af872beb35f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("11a91519-8ce9-42aa-a576-ceae4d4b65a2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("12148a35-43f0-48fa-bbe1-453e2defa4f3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("146ebf9e-91ae-4c57-ae54-7316488b8788"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("158db28d-0725-490b-8b4b-ba467c9ed1cf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("15c458ca-92af-461b-846e-8d5e46e6e9d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1648969f-1326-45b9-ab5d-28921974e2ee"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("174bc5df-38af-4bd4-9d80-6e01912c6fec"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17bc41ef-c0fa-4077-b3ec-c68f4b1b8703"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1806c2ed-7a1b-437b-b73d-e8f557fb1714"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("182507a3-0cce-46a1-afe3-baf5d3139407"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("186a041b-fd45-4fd0-b0fe-da90b6cac0ad"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1924d0cf-0189-457b-9c88-49563b3096d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1a31ef6e-ad33-4344-9fd0-70aecde4a813"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1c0f6c6f-5199-4570-a6a2-3820a5526f98"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1c812c13-95ea-4020-9541-bf81b1f00107"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1d9c04cf-a3c4-463a-b917-d0a3bf871f68"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1f59ff15-8cfe-4bb7-a4df-5efcebe8848c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2078e934-8e47-4302-82e0-8c522a006513"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("207c2992-4842-4c6d-9e7c-0d072031a2a3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("20aaba49-ee68-4aab-bbb3-26f065643767"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("213d3fb8-1350-41cb-a9d8-35e04c7dea17"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2207d6ab-f76a-43b7-8ac8-b60f18438b27"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("237390e4-0f43-4152-8404-d9a2d78cd3c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2399d9bb-7dd7-46a0-a2c0-00da632e2fad"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("248eafb1-9d58-47a6-abc1-8991d9e83119"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("259a20f9-5b23-4b88-8612-df05a562c146"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2897a356-927a-4587-b226-12f8cc80889b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("29b12ce0-a9c6-4ba1-8b4e-af044eb98b48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2b520972-52e4-4412-a8ce-b9afb45655cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2bf41c4a-3b39-4205-a275-51642cc58557"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2c01a949-3167-490c-a7b8-433167acbd55"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2c2b8643-205d-4e9f-8dce-d5399cd68ec7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2c5b30fd-5443-42cf-b46a-7d53cb4d04dc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2cf2b57b-5910-4c80-a48d-8598e68f7387"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2d1b5ab8-9939-443d-9c6b-45244fd91595"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2d6e4801-7a44-439d-a4e8-213a265c425d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2d9ce677-50d0-4ddc-b454-1eba29d17d56"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2e0f83fe-df77-4b9b-9e45-183cefc49b9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ea00293-71b5-43aa-815b-d8ff1fe96165"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("305bbc41-cbf7-4955-a341-df243f0c77ef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("30e3f070-07b9-47c0-85d8-ec93de2f7ec1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("314013bd-2342-4335-a42e-327dda8653b4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3186437d-cb26-4145-9125-122ec18632d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("318ee0be-683c-4b67-bd25-510577871653"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("31d0746e-f87b-46fa-b520-3e476bf95bd6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("337e57a8-957e-4b37-aff2-8bc176ba1a56"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("33af1d21-3c3a-417b-8f2b-cc47102f72b2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("346f11a2-6557-41f1-aed9-67bb8f77df88"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("34c1687c-499d-4084-a38b-7beccf0e754c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("35c4f6b8-a66a-4cae-b066-0d0bd23b9864"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3643ad6f-a57d-43c4-b7ce-b807b8d665ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("364db4c3-e9be-42ce-a8c8-d35eb273631c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("367d07a2-959b-4c78-befa-77cb228bf8ef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37ff79da-c1b4-49aa-a3b1-74ca22ae32c4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3a974d09-e437-4fbb-89d7-b83108a2cceb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3abf7a60-65e0-438c-a495-a167ce27dda8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3aeca416-5927-484b-81ea-50df195d79c7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3c155466-b949-4172-a025-1023cc4e9bee"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3c2d266c-cf67-4c24-bb13-553f6cd04af5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3c523b1d-8d9a-4dc1-ae76-19a8e07a6a8e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d69e36c-bef4-4779-a870-a8baa8edbe66"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3dd559d2-4c73-46d9-8220-d7354338004a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3dff21db-2712-4340-990e-5d33595727d8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3e44dc90-6eb4-4874-8d32-1760224ebecf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3ee573db-553a-4e85-a5cf-a7487d9ffa51"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3ff998e0-ec73-44d0-8a0e-0078a6b5b042"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("404d2086-b347-471c-8756-8dfbebc3511a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("40d7bc10-f525-4750-9e9a-111cf5d1ae85"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4168f37f-3c8c-4ce1-a045-5653a2f0954d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("41a70d7b-f505-4b49-bd1b-ef6cd3f41fcb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("41b50262-c1ca-4cbd-95c3-d7d3e3521194"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4307b34b-e148-47bd-a81a-87e8575df420"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("430f7201-ba3a-424e-92e7-2830885d9701"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("433540d3-b97a-45fa-960d-c2644ae077e7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("433903af-4336-49ba-8d7a-67de707a6f3b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("442d1cca-29c4-4d44-853e-ead1097167d0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4437d0cc-a0f5-4066-8dee-3477227c579c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("44d41cc1-27f9-4659-894f-2f0a1896146a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("45270e0e-688c-46e9-8edd-b8c3600aa8b4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4743c868-0eb1-44e8-809c-6598b5ad55cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("47aaa904-e284-448c-bb55-69d2c1caabd1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("48c31777-9a40-4bd6-88db-d23ae6897ab5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("48cdeaa0-1fed-4be4-b989-9742465de9cc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("49291983-17d5-48b1-bf74-9d4b56a413d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4a72725f-3cae-4085-af29-5afe0b7acb16"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4ad36c6a-d74c-4a18-8f6f-c48ad31003f1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4b938a1f-93ec-4abd-bd09-b59f56775bf6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4be2401c-dc8c-4aa6-9403-e96013219979"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("53b3c307-8dd3-4b83-825e-a70b1abf4b10"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5403d181-8b89-49aa-8fb8-a7b7096610cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55405108-66c3-41d9-a3d4-ce62d5ad845f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55c2ebfc-285e-448f-ba55-dcce79e56c7d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55d23b0b-b094-42ec-907a-d2d04bb3458a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("560231d8-3a2c-4651-96b4-6c97bc619f8c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5859915d-25b8-45d7-9fc4-cb2b53e0e5aa"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("592a9c47-a644-42ec-ad67-e83268bf23ae"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("59759bf6-4aa5-4f7d-a340-49ea291e0c7b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5983e297-a046-4232-92b2-2bf3187010ee"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5bbe788e-bf68-473e-882a-228d2ef71d04"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5c85af2c-f974-47ea-8c10-85be37e0e1e5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5c997fc9-dd5b-4e63-8927-662b072f650e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d020957-824a-47d5-9f12-320b56ff3e63"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d071ae9-05ea-402d-ae56-d4c500ed514f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d378bb2-9947-446c-a8a1-4d5207224041"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5db44531-87bf-4269-bbf4-798fb5b6dbe8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5de46d67-b3aa-4a68-af74-3c0dc35b42ce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5e24eb92-26ce-4aec-b2ed-fcddc7cf168c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5ef462f3-3936-452c-aa5e-f68af6324efc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f105ddf-f424-4631-981f-a48742d99fb6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f69914d-bb55-41c3-8b62-471cdd280a99"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f9627b1-2a82-414b-8e07-cbc021219e68"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5fa4d351-2703-4fc1-8dde-738bd51d06d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5feb3754-668e-4ff3-a9f6-c46a8a7c1b14"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("604ec319-a460-442d-ba27-7741842dade7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("60edfda2-69be-4b44-b8e3-305eb10cd615"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("60fed0c3-a32f-40ea-bd60-a756eeb7c1ea"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6114c4ee-4c65-40ad-b13e-4c6c576164b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("61aaa70d-029e-4594-95bc-add8c699d9a2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("633e3c2e-765a-4d1f-8ce7-b1a8fba9bb59"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("648a30b0-97c2-418b-8e3e-714134c8ec1d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6522db72-fd94-4f5b-bb41-186c80ae9dcb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6566775b-33e5-4954-a2c0-54827016fbf6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("672e19ba-72b0-4611-b885-4741b52e9519"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("679fa0c1-0f21-47d8-a462-2a9ada12ab67"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("68e71812-8302-4c94-9cc2-c375be072ba5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6b409bc3-da6a-46f4-b9b1-2301fb6bd102"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6bbcbdfc-1867-4f9b-941e-c6788c1282fa"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d12fd4b-6a65-4e24-b798-0197a5451616"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d8269e2-9de1-4b69-8c1e-03fd9b87cf5c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6dc1357e-574b-440d-8537-3e552dc8c1bd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6e59b520-627d-44c3-8dc6-280e3709779a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6ed835ce-110e-4a6a-8409-73277d922312"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6eeb1318-aed6-4b2c-a927-a8cef9f98c6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("704a6a7f-12ba-4929-9e0c-dc68d4ceb994"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7068302e-3499-477b-8515-f1f7b1f43533"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("708520ca-03a9-4844-bb58-90031257b7e4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("729af3ce-4fc0-4260-9426-5c6c023f3eb0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7327efc3-3826-42d7-927c-ce125c97abbc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("74428fd3-1f53-43b8-9bb2-a4c43d50a783"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("749e5713-9d13-497b-abfd-341cd57aeb74"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("764acd9c-7031-4bfa-92d6-6ccaf9cf37cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("77068fd9-d70b-48c3-bebd-53b0e20eb269"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("79040263-0780-4461-b259-00176b85d529"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("79f96530-c8ff-48ec-9be4-1db31e5b651a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a9e8fec-9ade-46e4-8b59-e4ee3651f8cb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7b1e5364-ac8a-4732-9d12-9d7aef9650ef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7d1308da-891a-4920-a83b-44d38ccfced7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7db47fd9-c845-478a-a2e6-2ad1d4e942d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7f3c2198-ff46-46a7-886e-5ed0828951d8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7faafd3a-6415-4320-8d80-ddb07399268b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("802a3d0e-5da9-48c6-9ed5-3bdb50101410"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("80382859-1c77-4350-9c5f-511fbb17d635"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("805fae0f-9679-43ae-b747-2070c3a11130"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("808e2405-cb14-45b3-9114-1bf85559fc32"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("80f388c3-5146-4b9f-a160-da7e7ccb867a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("82a09ab2-9679-4f7a-b244-c06db43320b2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("82a22f5e-56d5-4351-b2a2-19ee5b423bfe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83acdfbe-2540-4447-8625-76e473854b2b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("841ae5d0-b8a0-4057-b6f3-d35bf341f1bd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("843b379e-b44c-4a09-b2de-b72577a0b332"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("845eef3f-0df2-42dd-ae92-808d741f14ba"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("84882f44-c503-4191-9829-b781e2d47a8b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("84f7cb4c-ba49-4f00-b03e-608acfd2f2c0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("85a70afe-e611-4688-a887-a22dba7d4aaa"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("86c12a51-8449-4f4d-a609-d5dcddbdbc6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("86f734c0-c4d4-4075-8926-9622ad9cf2d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("876d8ece-1e78-47f0-afe0-542b0a183dc4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8932cf5c-9f9b-4fba-876e-053ec97aa163"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("89ab9f11-f02d-41ab-9cb5-5d06c6a11af7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8be22394-fcf2-41e7-9bc5-43bb067b4f57"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8c10a44f-cf06-4d99-ad84-1759dbcab488"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8c1f7407-8d8f-4cc2-a875-ba84eb73092b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8c6c398f-9183-404a-b05e-651e99da7739"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8ca8e34f-1ef9-47d8-ad78-4d565c0097c6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8da21848-8e63-49c7-b323-687f0ee6e7f4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8daa35dc-c849-4d10-b233-c34eb9f20443"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8de81b72-505a-428f-95b2-9b62f81d1ac6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8e95f636-5817-42cc-8207-eb2e96edf32c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8ff5c4bb-5276-4f80-8598-b79e5d0d6d68"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("90782a9e-4cd4-4433-8f99-08cfe4601022"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("91e12f35-8bb0-47d9-b34a-3e1ef08ee66e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("945afb5d-36a1-4c06-bf0a-dd652d7d50a4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9572285c-8f8c-4ac4-a682-04615dbc6c44"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("96f7297f-e2de-487b-9102-9296db6e6fcd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9794c693-efb6-4b38-947b-40f114589b24"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9862edc8-f021-4660-862b-1fa713441504"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9a72de24-b563-4398-bd5d-dd951d82921f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b29f16b-867d-4443-bb52-1cc824ff0ab4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9bdade91-f3c9-4e63-9974-efa30dcaf09c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9bed6341-8ce0-4aee-8169-1950f6c36fe6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9d28c57f-9ff0-4dfc-911a-7f75b0113067"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9e0caaad-5f3f-4362-bc8b-2bb4ac5c987d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9e117a59-6945-428b-b65d-87c909bad6b8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8fc8-acdc-4c33-8792-580f5cdf411c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9f6b16f1-e118-46f4-8ab2-d90ba948b30a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a027b933-e0af-464b-b109-d7e27f420d2d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a085e3d4-528e-4158-8366-e7946125199f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a0a4b7e6-e325-41bd-afeb-99531433d133"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a32505af-b2ab-4230-b3d8-55f780602079"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a3344607-44c5-4122-a7d6-702b07474410"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a352201a-f3a0-4275-92ea-00d4f846cda0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a431fa67-7545-4e1e-9832-04c0bd352d23"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a5b8e0ed-9baf-419f-bf3a-0d9dbe733fbf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a6e8bec6-2458-4850-ab3b-1542f87a9166"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a7abcdf9-ae26-4f78-bb5d-49be46ed05b2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a838dca0-963a-4840-8628-6d3255dc4560"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a92735e2-b549-4fcd-984a-deb70bfd7fcd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a9e794c7-03f6-4551-a763-ec27b6d864e0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aa230a49-deae-46f3-ad5a-40a86918327a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aacd0c82-83ea-45e8-93f6-4fe0219c42bf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ac4deeac-6e1d-4ab5-bba2-56f4d1964910"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aeceabee-fe28-4175-99c4-d1f5c830e498"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("afd35c8f-7025-4d25-b43a-07eba2f7cdf4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b03017c2-914a-419a-bc4a-02c305de02de"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b05cd680-2977-43b6-bc81-e6eeb0c605fe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b1a1bed2-0a53-42fb-bf8b-a933b288f35d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b2ab1127-66f8-4cd9-9bbc-34af57aab8c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b3a42cee-187c-48e2-a8ab-77b07b27d342"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b61ac910-17ee-4e37-8b4f-c674b3ef40f9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6a7a0ee-704f-4914-9b50-2e2190db9279"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b7e2da22-8515-4625-92a1-385dedb47dd0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b8f4ed3b-9698-4e7d-9e75-d2f54bca041a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b9a6d2e8-3327-4166-b350-70f8b8f21364"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ba5f856d-e26d-4924-866b-636ede4cc52c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc1100bf-8b65-43d5-a829-5c8a9a32768a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bca42b84-ca8b-49df-8d09-d80d6aa51ac0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bcb13382-d95c-4a7f-b2ba-3f0f2260ea21"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bcdaa429-14af-438d-afae-0522505c635f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bd9ff497-b192-45aa-86b4-7d636d4bada9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bdaa7603-c9ca-4fda-9cca-c725777f8f9c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("be3daf71-bb8e-4ffc-a7e1-8a24279a471b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bf3155c1-4be1-4bf9-987f-95422c1d8f9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c0b063ef-e246-488f-913c-d0bfcf295c6f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c0b4e543-6b1b-4f30-8f43-90e1d1b349b6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1b0ce7f-08d2-447d-9caf-8e31ed0fc9ca"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c2d9a9ba-7b8e-417d-b874-6020e781de2b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c2f86d95-9446-4b8a-8404-79824a3dd17b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c38bdcc5-0ca9-4441-8ee7-a04d98f4f828"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c3f27c2b-0ee9-4b73-b67b-962e39cc7c69"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c48baecb-0d7c-422c-af56-85c8a4c6cc13"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c4ef9e35-865d-4718-80e1-feb624f446e5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c5a4f435-6c1f-4f17-8ec2-9ffdf788ced1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c6fb0c15-8c4e-4545-97fd-f75ad6adef00"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c9de1474-050c-425d-935c-2b7576f6bb75"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ca680cf2-2712-4af2-aeb3-ab04785cd935"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cbbffbb9-1e36-4e1f-9d76-f1bcb3e412a1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cbf845e1-954e-4d28-b3a6-062eecf4eef3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cc3e1eca-872a-422a-ac07-f32ed8a23a18"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cc426c82-c9d0-408e-94fa-88cf3e79b716"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ccc74988-fc31-4a31-9034-d6e5c72bb873"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ccede387-041c-4eac-8e05-0954e282f22a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cd5c8b37-ad27-40a3-856e-e42bf631b2df"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cdd715ad-d51e-4cc1-8b4c-edb387b24459"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ce19594d-c92a-4fac-b9e0-8bbe28ee0fb3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cece41e9-051b-4a60-adb8-d6eb65278f0e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf0ce8b2-7fe9-4251-a2be-33d60ac3556e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d018f074-580b-448e-9bec-345abfdd57fd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d060c85f-2193-4f24-b2d1-f5b5d7180741"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d0768130-5b2e-44f5-8435-93bc3b03a3a6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d0fd5fb0-c212-4a8f-9cce-b5819af3f2bc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d1c585fd-716f-4aa4-ac03-39b342183cc5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d3d01fca-588d-4dbd-a382-1e3107ecb8b2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d4ec3e69-d853-487b-94b1-9a42ace64cba"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d6397ee7-e58f-4134-9229-13b02dd31864"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d64ed4e9-4298-4339-a996-f470802a034b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d6e9f2f7-a200-45bd-a35f-63be206311c9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d79f488e-9317-47ea-ac22-14db90026d99"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d84fb9bc-c151-40b4-a335-da8ba80afe47"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d88fd90b-f7cc-4a59-8a0e-bef4952d5196"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d8fd4550-f931-4507-b50b-9dd7393285bb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("da9b78b9-6fc8-4350-9491-16adcde686ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de2b1dc1-8722-4381-9ba9-f721654438f7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de2dc78a-9798-4a2f-863b-55d39519ddb7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de6f0010-8295-41f1-ad54-dda974b6e6d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfab3ce2-a84e-4255-accf-aa63cd524a77"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfd6fcd8-ed2f-4ed8-bcee-09a1d3244365"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfda3900-88cc-4aac-831d-ff811b80eb0b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e03232d0-f9bb-4e03-98e1-6e46e706f608"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e08ee273-4656-4dd8-94b3-a59b55e6d52f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e1cd1a86-a539-433c-b7e4-5bb06d7cbb89"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e26f06bf-09b0-419e-9f2e-47b03232715e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e3ab2ab5-35d6-4f7c-9f35-0ac0374b82ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e67a4785-d489-4bf6-ae52-3bffd974e5d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e760f4b0-1146-4be5-b2b2-f5a441d837b4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e763f1a6-d69a-4c9b-8c18-c2f35c931d07"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e78a7da4-6035-448b-be67-7cf16a8a419d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e80fc973-5c5a-4ea5-9fe3-d6e6c7141755"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e815d722-c3de-4e40-9ccd-2ab01ba08133"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e83ae900-ec35-423c-9024-86e69cf8d54d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea19c238-d031-42eb-91ac-d8e60ab5875b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eb5d0a8b-86e3-42cd-a3b7-921f85a94e51"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eba6a724-e090-49e5-bb88-7d715e9061f8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebd2cc8a-3eec-4148-8ed7-c481ae486f86"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebdf6b15-8b4d-45b8-bd97-13ee13e04e91"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ec443e21-a941-4e03-9a73-eacea2ad874e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ecac88dd-346f-4a2e-a2e2-b0c814141ebf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ee74a619-3a1f-48b8-b3f3-2218268eccf4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eee23c93-9731-40e3-ab0a-10ddc6b9da36"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ef0f7f7d-3fa8-4802-9d4b-9c793cffb2f2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("efc94f91-497a-4448-acc8-2ecb61673440"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f00e7a91-f278-4d44-83d2-a9aae6aeff92"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f073ef07-995f-482b-be84-c9d97a515867"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b61803-6518-4005-be9e-0c7c6d185672"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f185c979-3eb5-4729-87e4-926a927ad0ab"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f2164efa-4534-40d5-82b7-cf9a1140688f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f24e596f-97de-4afa-b809-c003479ee208"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f25791fb-0fd7-4f4d-a276-b36478a2afad"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f309aa27-f32d-4f28-863c-c2cb11a868fe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f37b3915-930d-4be3-bcd2-fe7cec2767d6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f398662b-ec56-45f4-bc2f-841eb14d59fe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f422c044-71d8-42cd-8563-7bd4e620cefa"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f42a32c9-fdc3-484e-97e5-57e72194239a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f470bd3a-c5ea-4c0f-893e-78e3140bc505"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f62f1885-a2a1-4c54-9a00-a5d4e91e9160"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f6f9b4aa-3c74-4506-86bc-498d35bf65f6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f83673da-30eb-4fa7-9c02-b72568543bd0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f857a862-3ca2-41b9-86b9-7145afc379d7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f8627a70-7388-4103-b799-835bd195638b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f9b90328-6a78-4d8d-8e56-c8ed94e0d944"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa8d8cd4-48dd-4444-b5fe-36cd797c2c7d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fb0298f8-c191-4070-bfbf-a5888525f050"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fb66d499-81f2-4c55-97d7-adbc0829d718"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe177917-13ee-4288-9f5e-0d4f75ec5362"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe21ffaa-704c-4087-ad80-f58afbb204d0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe8783ac-8a92-4853-9e16-96e1150ea482"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fef6407a-0c06-4003-8273-30527904b537"));

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Offers",
                newName: "Company");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Offers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("0051ca25-42ea-40af-b7d2-abecaaa6b1c4"), new Guid("0ed03359-a7dc-4eb4-a616-044557143b43"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2162), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Po co stosowana jest dokumentacja ?" },
                    { new Guid("01c45d24-c099-4830-9da1-e080327f27e1"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2197), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie problemy mogą pojawić się po refaktoryzacji ? Jak im zapobiec ?" },
                    { new Guid("01cc04aa-f339-4da0-b6dd-ce1fb2e5457b"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda obsługa zapytania i odpowiedzi w przypadku REST ? Opisz poszczególne operacje." },
                    { new Guid("01e4e571-20e3-4ddb-b9b9-9857174989d1"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2931), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się wywołanie synchroniczne od asynchronicznego ?" },
                    { new Guid("01f8f3c5-78d3-4e28-9bf2-a210185c34db"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mają wywołanie w pętli obiektu uruchamiającego lazy loading, jak to zmienić aby było wykonane pojedynczym zapytaniem ?" },
                    { new Guid("022de402-b693-4ba2-884f-eb7e6bf65312"), new Guid("b74d05ea-7d83-4989-b1c5-a28d0a0af4d3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3501), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się DataTables, DataViews, DataSets ?" },
                    { new Guid("02675f57-fa84-4513-8a79-be090412eeef"), new Guid("b74d05ea-7d83-4989-b1c5-a28d0a0af4d3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie rodzaje kolekcji występują w ADO.Net ?" },
                    { new Guid("0293e2f0-7b12-4ee7-8ac7-1212f89fa8ac"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3530), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest domyślna konfiguracja w Entity Framework ?" },
                    { new Guid("02cc8a4d-fb9b-4e9f-924e-651a6d25610a"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z czym związane są słowa async i await ?" },
                    { new Guid("03c70d90-0aac-4de2-bc1c-2435c02ca5a4"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym w budowie różni się partial od widoku i jak to się ma do layoutu ?" },
                    { new Guid("0491b354-3620-4faf-882a-890ef0859c1d"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3877), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działają serwisy w Angularze ?" },
                    { new Guid("057cb58b-dc82-41ba-9e33-b2c810785f12"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dekorator" },
                    { new Guid("05befb07-31a2-4ef1-9401-c2f69f1fa5be"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2538), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy wykorzystywałeś CI / CD w projekcie ? Jakich technologii użyłeś ?" },
                    { new Guid("06aa7204-e12b-497d-91f7-e0d2f6bfb877"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest kolejność wywoływania bloków catch w obsłudze wyjątków ? Zwrócić uwagę na dziedziczenie wyjątków." },
                    { new Guid("06e9241b-707c-4090-bbb4-29545191d051"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest podejście BDD i SpecFlow ?" },
                    { new Guid("08d2200e-5f0d-4d74-a666-2fb71894f430"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3763), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy indeks nie zadziała ?" },
                    { new Guid("0a9dbdcd-518c-48e5-bcb3-bb8e094511e1"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3246), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa BackgroundWorker ?" },
                    { new Guid("0c100b72-8b10-4c2c-a133-943880653cb9"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są klucz główny i klucz obcy ?" },
                    { new Guid("0c5d5d5e-712b-4f80-846c-b0c1ce6648c3"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3581), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest problem n+1 i czy dotyczy to Lazy Loadingu ?" },
                    { new Guid("0cdf6947-75aa-4ac7-a313-9d863f55c758"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica w wywołaniu \"throw e\" od \"throw\" ? Który standard jest lepszy ?" },
                    { new Guid("0dc7e8f4-8f56-4688-9e8c-b17d4369c0b8"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jaki sposób dbasz o jakość kodu ? Jakie znasz standardy i drogi do uzyskania wysokiej jakości kodu ?" },
                    { new Guid("0e8ec9a9-c05f-4c57-b433-03496d8dc4c8"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między fetch a pull ?" },
                    { new Guid("0f3d67e8-c6b7-49de-9b8f-ec521d2d70ec"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3354), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Porównaj dwa wybrane kontenery DI np. Autofac, Unity, Ninject." },
                    { new Guid("0f5b5d4e-1006-4258-9640-bcbb44ed6a43"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest token ? Co zawiera i na co pozwala ?" },
                    { new Guid("0f824f1d-ec09-44d8-82cc-abec8cd9b611"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3897), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień i opisz modyfikatory w serwisach Angularowych np. Inject ?" },
                    { new Guid("0f8e0628-82d3-4d6d-b721-f7116907c13e"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3064), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie i po co stosuje się słowo kluczowe sealed ?" },
                    { new Guid("0fcef0bd-c1f0-4a80-a2df-400a51f43759"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2348), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DTO" },
                    { new Guid("114a0000-b9fa-41d1-9a8f-0e18512ec52b"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2775), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w REST można wpływać na domyślny parser JSONa ?" },
                    { new Guid("11560d63-ede0-4f29-bf57-9c6fcca5cd72"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień dwa wielowątkowe typy w .NET." },
                    { new Guid("1408052e-e59f-4504-af0b-845d465eac7a"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można podać wartości domyślne dla metod ?" },
                    { new Guid("1438204e-6b9a-43b9-8ae5-92da38f8d0b6"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie ryzyko związane jest z lazy loadingiem ?" },
                    { new Guid("15a1533c-05d7-4ce7-930e-cc833ae7f41f"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz metody HTTP ? Opisz." },
                    { new Guid("16145d6d-eb99-49ec-abd1-5727ddd88f9d"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3839), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Promise ?" },
                    { new Guid("162fd488-a13c-477f-ae8a-98af80eac07b"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest interfejs ?" },
                    { new Guid("16a4c894-cf61-4dcc-9a43-b8259aac9dbd"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3362), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie poczynić kroki aby wyzbyć sie circular dependencies ?" },
                    { new Guid("16beb49b-9a4a-4601-a306-0ab6660d66e6"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest struct ? Czy jest typem prostym czy złożonym ?" },
                    { new Guid("17262015-2bf4-4294-8cc3-c6d38c0962b5"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Której generacji językiem jest C# ?" },
                    { new Guid("174300af-f168-4535-bc0b-9ba00be67ba8"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3429), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Napisz przykładowy kontroler WebAPI." },
                    { new Guid("174b888b-70c1-4d08-8911-a880b073dd87"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak przekazywany jest token ? Jak to związane jest z zawartością ramki HTTP ?" },
                    { new Guid("1bd68d06-302d-4dd7-b621-f6418d98485b"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest deklaracja vs definicja vs inicjalizacja ?" },
                    { new Guid("1bf3d4a7-d225-40db-a30d-71573f394758"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3175), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki jest porządek wywoływania kolejnych bloków catch ? Jak to wygląda przy wyjątkach dziedziczonych ?" },
                    { new Guid("1bfc913a-5677-4095-97ae-e75f30e67131"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś kiedyś z kontenerów Docker'owych ? Jak działają ?" },
                    { new Guid("1c25426c-03ba-4cb3-94de-5b391092c74f"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest boxing i unboxing ?" },
                    { new Guid("1ca0973b-1782-4836-8581-5ac674ffe9bf"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można wywołać metodę prywatną za pomocą refleksji ?" },
                    { new Guid("1e83d60b-d913-4239-8976-fce83cf3764e"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co zrobić żeby zapewnić unikatowość danych w kolumnie ?" },
                    { new Guid("1e9b296d-2ae9-45ff-bace-53c1cbae6fb5"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się testy jednostkowe od integracyjnych ?" },
                    { new Guid("1f5159b8-c3d5-4e3c-b085-899836683266"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Mutex ?" },
                    { new Guid("1fdce86b-1e52-46ed-83ce-459da8837acc"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa pipeline wywołania dla REST?" },
                    { new Guid("1ffbbc50-709d-4b12-84b0-e2c581fe2b80"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj rozszerzoną wersję klasy implementującej IDisposable." },
                    { new Guid("210260f4-b6d4-4b67-9920-31198ce4a4b6"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są testy integracyjne ? Czy pisałeś ? Z jakich technologii korzystałeś ?" },
                    { new Guid("2198f479-343e-4bac-96e8-d1036e01aabd"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DAO" },
                    { new Guid("23337652-61c3-4bae-a009-cff1447db68e"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3349), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz realizacje kontenerów DI w .NET ?" },
                    { new Guid("23ac7efa-b559-4b40-b753-23126bf07a20"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2386), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoC ? W jaki sposób jest powiązane z DI ?" },
                    { new Guid("244fa13d-f0bd-4246-88e1-4831ff74fdcd"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się Promise od Observable ? Co jest wydajniejsze ?" },
                    { new Guid("248cd669-00dd-44af-bb69-2e108b83b3b9"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3741), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są ideksy i jak działają ?" },
                    { new Guid("249ec25b-f63c-47d3-b4eb-9f33a478be10"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz języki SQL ? Z jakimi rozwiązaniami miałeś do czynienia ?" },
                    { new Guid("24b49006-1ab7-4907-9fd8-ed4822938041"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blokowanie optymistyczne." },
                    { new Guid("24da753f-f2e6-4df5-af7e-b1090f8af2de"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są podejścia do definiowania struktur danych w EF (3 może 5, jak w poniższych pytaniach)?" },
                    { new Guid("25305eaa-f4dd-478f-b583-b0a1e108d016"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest podejście DDD ?" },
                    { new Guid("25dc08bf-d396-464a-af6a-16795214380f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Proxy" },
                    { new Guid("267a9612-4924-4363-ad7e-cb02c3520d91"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak osiągnąć uwierzytelnianie na poziomie Angulara ?" },
                    { new Guid("26a5e8c7-24f8-448b-bd36-dd3e709ca576"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." },
                    { new Guid("26cec6d2-1d84-4011-bbcf-cdb0160e7b9f"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2555), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś kiedyś z narzędzi telemetrycznych ?" },
                    { new Guid("27197b63-987a-464c-94f0-d0c5c7a7ef04"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3336), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IIS ?" },
                    { new Guid("29299587-35e5-499e-ae04-f13bc3bb5c74"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa wykonywanie operacji Ling na IEnumerable ? Czy wykonywana jest operacja yield ? Na co to wpływa ?" },
                    { new Guid("2932ec3c-826f-4db3-830e-4c959155cc32"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można zaimplementować skalowalną architekturę ? Co jest kluczowe w API ?" },
                    { new Guid("2ace9f6f-0fd3-436c-99f2-c8f50baa2c5f"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest refaktoryzacja ?" },
                    { new Guid("2ade53cf-08b4-45f2-b8cd-337ebf4478d3"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy GC wywołuje metodę Dispose ? A może Finalize() ? Jaka jest różnica między Disposable a Finalize." },
                    { new Guid("2ce1bc7e-1143-4dfa-bd90-3bfbc8a44a8a"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest autentykacja ?" },
                    { new Guid("2d7bd076-0aa2-4c98-9c02-4db7a4f07a90"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co się stanie, gdy jeden routing naprowadza na dwie różne akcje ?" },
                    { new Guid("2dadd0e5-abb1-4279-a7b8-ca0c24042c99"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2382), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Inversion i jak się ma do Dependency Injection ?" },
                    { new Guid("2f5a0b07-a861-46dc-a05f-9eef8f1e8bc4"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3768), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się var / let / const ?" },
                    { new Guid("2fd1cbc0-a5b5-4231-bb32-8dd3a07794c3"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między listą a hashsetem ?" },
                    { new Guid("310afa4c-1239-4c5f-95c0-016516e966c8"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2732), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda state management w .NET ?" },
                    { new Guid("31f39ec8-95d2-4a81-a787-8883c6f95b94"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Builder" },
                    { new Guid("32aa2267-cbdc-4903-840f-446198d77091"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak globalnie dla usług ustawić mechanizm pobierania odpowiedniego zasobu języka, czyli .resx w danym języku ?" },
                    { new Guid("33f43113-b983-4409-98ef-8419bfa4be0f"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz rodzaje indeksów ?" },
                    { new Guid("342ce447-b67a-43b7-bd98-25e63e333628"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się instrukcja przyrównania == od === ?" },
                    { new Guid("345fcd52-9371-4003-ae1c-262eb755c526"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy StringBuilder jest realizacją wzorca Builder ?" },
                    { new Guid("3664b1ea-d596-4218-aa94-889411b5961f"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co robi atrybut UIHint ?" },
                    { new Guid("37736a95-ca68-419a-b62d-71d05e4a8ad3"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2420), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła SoC ?" },
                    { new Guid("3783869a-551b-4c12-86cc-77043dd424ac"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zastosujesz EF Projects ?" },
                    { new Guid("37bb3141-03a9-48d5-964a-2f7699b7dd64"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest TDD ? Czy kiedykolwiek używałeś ? Jakie miało znaczenie ?" },
                    { new Guid("37ee4dbe-0dbe-47cd-9aa4-3f1ff6959f0c"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie wykorzystywany jest GetHashCode ? Czy w HashMapie dodanie dwóch różnych elementów z tym samym hashCodem nadpisze je ?" },
                    { new Guid("384ddd0c-ebef-4a1f-b14d-6462e86c26cf"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Podaj różnice między EntityFramework i NHibernate ?" },
                    { new Guid("393ea3e9-7493-4a4a-ae16-1eb064b56c1d"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się Entity od Value Object ?" },
                    { new Guid("3a1b65d3-4677-4b02-96de-8583717f8ece"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która konfiguracja jest brana pod uwagę jako nadrzędna ?" },
                    { new Guid("3a727677-9c73-409c-a014-ed081291c77c"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3412), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co się stanie po wywołaniu np. query.ToArray().Skip(20) w przypadku IEnumerable i IQueryable ?" },
                    { new Guid("3a96b1ac-cb5d-412e-86ef-5254580b38c5"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3258), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest refleksja ?" },
                    { new Guid("3d4a267e-3593-49d3-b523-4459428810ac"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2138), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie role są w Scrum'ie ?" },
                    { new Guid("3ec1e4dc-bcb0-4f03-a56d-37088a86c714"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy string jest typem wartości czy referencyjnym ?" },
                    { new Guid("3ef2058b-0e4b-4bf5-8eb1-290163c5c180"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są plusy stosowania DI i IoC? W jaki sposób stosowanie DI / IoC wspomaga testowanie jednostkowe?" },
                    { new Guid("3fd7681f-095a-447a-816c-382aa0778131"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się wartość null / undefined / undeclared ?" },
                    { new Guid("407f6147-2162-46e8-8e7c-0a110917e806"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3315), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest CLI ?" },
                    { new Guid("41e0f6c3-1fe5-4ea1-8dd4-57b1cddf34ef"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda definiowanie tabel w .edmx ?" },
                    { new Guid("423454eb-0e08-4c78-9e86-4fc218c148a5"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2215), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz wzorce projektowe i architektoniczne ? Z których i jak korzystałeś ? Najważniejsze wzorce z GOF Gang of Four." },
                    { new Guid("42538fc4-661d-4bbb-8977-f5ecccbb689a"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Podejście wywołania GET w rezultacie wywolania PUT. Dlaczego jest tak ważne ?" },
                    { new Guid("43d9ee8d-00b9-4bee-bb77-3ad8a839e053"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz narzędzia do wersjonowania kodu źródłowego ? Czym jest CVS, SVN, GIT, TFVC ?" },
                    { new Guid("44970d6a-0b3d-4b5c-b307-2576b6326b40"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2984), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jeśli uderzasz requestami do serwisu bankowego i on przestanie działać - jak temu zapobiec ?" },
                    { new Guid("44a03c5b-6903-4753-81b3-9587b103e309"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3183), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co jeśli w bloku finally pojawi się wyjątek ?" },
                    { new Guid("44d19d35-e514-4e02-a8e1-c284aebe1d20"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega database-first ?" },
                    { new Guid("454ce22f-1b0b-4a31-bc15-b0fb46b0fe8f"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak implementuje się HAVING w EF/LINQ ?" },
                    { new Guid("45fac73d-f42e-426d-bc6b-74ba6f4fe289"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2332), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVP" },
                    { new Guid("46144920-956a-4cf8-9213-6c0ea92418d3"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3510), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są zalety i wady generycznych repozytoriów ? Jak można zaradzić wadom ?" },
                    { new Guid("481cc80a-e1c4-473e-b55d-62655822a5ac"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest complex type w EF?" },
                    { new Guid("4832a094-8101-4da1-b112-4f056549f1f6"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3772), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Do czego odwołuje się instrukcja this ?" },
                    { new Guid("48911cad-8fd8-42b4-8ad1-a66577a4c021"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień kody błędów HTTP ew. grupy kodów  ?" },
                    { new Guid("4979cc36-b80c-4b5a-a102-c5f7e1bf924e"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa abstrakcyjna ?" },
                    { new Guid("49e381da-a36a-4afb-8f83-76e5468ac495"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3056), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między interfejsem a klasą abstrakcyjną ?" },
                    { new Guid("4a3d0002-934a-489b-9340-ad70d94443f8"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2791), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz podejście mikroserwisowe. Jakie mają zalety ?" },
                    { new Guid("4b786655-2a24-42a0-9ac0-2707fe896a48"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest cherry pick ?" },
                    { new Guid("4b9e179c-caac-43a2-8ee7-f14451d4d16a"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się od siebie IEnumerable od IQueryable ?" },
                    { new Guid("4ba88c0b-c526-40fc-a090-969aa9f1d7a8"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak merguje się branche ?" },
                    { new Guid("4bfd469f-7b45-4951-b67e-41eb93f45f46"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda multicatch ?" },
                    { new Guid("4c50d469-b711-482b-83e0-adb7c5606540"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3625), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mamy kawałek kodu. Kolekcja \"lista\" zawiera duplikaty. Co wyświetli operacja ?" },
                    { new Guid("4ca6abf4-a8fb-45d0-9bc3-ac139f2bb2c6"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2950), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Monitor ?" },
                    { new Guid("4cc928b5-30f7-478f-9d3c-bf33d9a239af"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3218), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się typ Thread od Task ?" },
                    { new Guid("4cd66fb8-f249-4e25-b853-d6ab5f0d47fb"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3031), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można wywoływać extension method na obiektach null ?" },
                    { new Guid("4ce8bf54-2f2e-44ae-8446-278af90e0b72"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy warto korzystać z async-ów ?" },
                    { new Guid("4d723cca-bf08-4c37-bb10-dee10e1abb6c"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3783), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest DOM ?" },
                    { new Guid("4d86560d-d59e-4883-a6e3-324bc3821c7c"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaką funkcję wywołujesz jeśli chcesz przefiltrować dane ? Którą z nich : pipe, filter, search itp. ?" },
                    { new Guid("4d9d7bd6-8fb7-47cb-841e-6b2c804632e8"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2285), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Facade pattern (bardzo ważny wzorzec)" },
                    { new Guid("50a777c0-e359-4cad-a0c5-5f7a98b650fd"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Ilu wątkowy jest JS ?" },
                    { new Guid("50f39c12-32e9-4e3c-ae6b-c53e2988de00"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są generyki ? Na co pozwalają ?" },
                    { new Guid("5174867f-5d36-4b5e-99d0-8c92eddb24c8"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2206), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Clean Code ? Jakie znasz przykładowe zasady ?" },
                    { new Guid("52c5de44-0263-4677-a01d-626afeb417a7"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2268), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Fabryka abstrakcyjna" },
                    { new Guid("53b27347-f2ad-4a15-a155-b3eaab77cec5"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3859), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się setValue od patchValue ?" },
                    { new Guid("53f48520-aa9a-4694-b4eb-0a70bab4bef2"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2366), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Retry" },
                    { new Guid("551ccbea-0d36-4fc1-a04e-6f8c46b41982"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz instrukcję Having." },
                    { new Guid("558613fe-2483-4b05-8f2c-b186dbecdd76"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2409), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła DRY ?" },
                    { new Guid("55c7d4c7-74a8-4c05-a914-6eaa1366cc92"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2970), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są wątki foreground i background ?" },
                    { new Guid("56e951cb-37e9-4068-8da2-d51511efb79a"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2817), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z jakimi problemami możemy spotkać się w przypadku RESTa ? Czy to zastosowanie nadaje się np. dla banków ?" },
                    { new Guid("570ccfe6-bcb4-4b47-b2e9-f38d8a29dc6f"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła KISS ?" },
                    { new Guid("5743f0b8-27db-4cb2-bebc-f058b0fa1a61"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3609), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się First od Single ?" },
                    { new Guid("5a11497c-323c-49b8-9ac4-7140a6cc37a0"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy jeśli zmienisz struct przesyłany w parametrze metody to zmiana będzie widoczna poza tą metodą ? Jak na to wpłynąć ?" },
                    { new Guid("5a1911ee-8d20-4e68-ac58-afd3e96e03c5"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3721), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się INNER JOIN od OUTER JOIN ?" },
                    { new Guid("5ba11e65-2873-40d4-91a4-4495473e6d44"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3204), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co musi posiadać metoda opisana słowem kluczowym async?" },
                    { new Guid("5bcf9025-063f-4530-b039-b3dd990049d4"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są filtry w WebAPI i MVC." },
                    { new Guid("5ccaa497-6fb2-40f0-94a3-8ed96be5b3ea"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3476), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co posiada typowy kontroler MVC ? Jakie można nadać atrybuty? Jakie posiada akcje i co one zwracają ?" },
                    { new Guid("5d34a193-28f7-4d54-803c-54cd863011c7"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3927), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest flexbox ?" },
                    { new Guid("5e17f76c-efea-4fcd-b1ba-f48c9813dcaf"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się metoda Parse od TryParse ? Jak zwracane są typy i błędy ?" },
                    { new Guid("5eb36e61-15b8-449c-9815-de01be7191af"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2875), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień i opisz różne typy tokenów w tym czas ich życia." },
                    { new Guid("5fc976a5-42e7-49a3-a80f-3a759463b6d9"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest transakcja ?" },
                    { new Guid("5fd50bd0-b78c-4ee3-b09f-62e14d97d3a2"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3544), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest eager loading ?" },
                    { new Guid("63554ff9-a0a3-490a-b2eb-fa486c26e081"), new Guid("347e971f-8443-4dfd-aadd-36a06c4d5bf2"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3935), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wylistować w linuxie : pliki, foldery, procesy ?" },
                    { new Guid("63aa099a-6902-4fa8-a1bd-2ffbbfef78a5"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa oAuth 2 ?" },
                    { new Guid("645344da-30ca-498d-8c9a-4a5b379c8316"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2256), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj singleton z bezpiecznym dostępem wielowątkowym (pamiętać o synchronizacji / double checking pattern / ew. SingletonHolder z bezpiecznym dostępem bez konieczności synchronizacji)." },
                    { new Guid("6464064f-6df5-4ce5-9354-c247729c8196"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy warto wykorzystać technologie .Net Core ?" },
                    { new Guid("6503dd81-2141-424d-a060-213da7a8998b"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "AOP" },
                    { new Guid("651181c3-e0f1-4db4-b91b-61346637bdd5"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3873), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa routing w Angularze ?" },
                    { new Guid("65e39fb2-dc80-4ff7-a399-d47424de339f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Repository" },
                    { new Guid("67327df3-d9b2-484c-9a5e-b8d1629e6a4e"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2651), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zrealizować relacje agregacji i kompozycji w bazie ?" },
                    { new Guid("682a68eb-ae5d-45cd-9fe6-b8801fe44863"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3674), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są bazy noSQL ? Jak działają ? Z jakich rozwiązań korzystałeś ?" },
                    { new Guid("6941e1f9-0999-4f64-bf00-2a4069b9395b"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3788), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest AJAX ? Jakie technologie wchodzą w jego skład ?" },
                    { new Guid("6964f254-40f9-4b46-9974-22447275f019"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się lock od monitora ?" },
                    { new Guid("6973a80a-d776-47e5-834c-fefd6d622166"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakiego typu znakowego użyłbyś do tekstu z różnymi międzynarodowymi znakami ?" },
                    { new Guid("6a695729-b491-4f3d-b28d-39c728b78451"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoT ?" },
                    { new Guid("6b222e1b-5d44-4316-86de-9568444bc705"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jakich sytuacjach wykorzystujemy słowo kluczowe using ?" },
                    { new Guid("6b9aaa7a-2688-4fd5-9023-ead8ed826744"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka sytuacja może pojawić się, gdy na dwóch branch'ach zmieniany jest kod ?" },
                    { new Guid("6d21727e-8237-44a2-8483-f22d4a0eb97a"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2926), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jakich sytuacjach warto zastosować wielowątkowość a w jakich nie ? Z jakimi problemami wiąże się takie podejście ?" },
                    { new Guid("6d9a5f8f-aaaf-4846-940d-3bd5b489660e"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2945), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa lock ?" },
                    { new Guid("6dbb6c6b-8e85-4fbe-9186-bd7e13f57bbf"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz rodzaje testów ?" },
                    { new Guid("6e06238d-2dae-4acd-9707-e4351aeabe69"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2914), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest mutual TLS ?" },
                    { new Guid("6f8df0d0-2db5-439a-a057-8dde0548fcc1"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zbudowane są poszczególne indeksy ?" },
                    { new Guid("709974d5-5c87-45c5-935a-b0df1ca3c5e2"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest pula w IIS ?" },
                    { new Guid("70d786d2-8c2e-4b8a-a20e-5a4804cd11f4"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2993), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to znaczy, że coś jest thread safe ?" },
                    { new Guid("70f4f6c4-e916-40a5-930a-2ead1b800132"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2638), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zaimplementować dziedziczenie w bazie danych ?" },
                    { new Guid("71783630-f072-42c1-98d3-712df5d8d1e7"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak dodać sprawdzenie do kolumny np. wstawiana wartość ma być mniejsza od 1000 (check albo trigger)?" },
                    { new Guid("74bf38a6-4ba0-42cd-ae2d-d0a973111619"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3195), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś z mechanizmów wielowątkowych w .NET ? Jeśli tak to z jakich ?" },
                    { new Guid("74fd7ed4-58ce-44d5-810c-bd659e149bff"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest lazy loading?" },
                    { new Guid("75285bb7-bcae-40e1-8f2e-b2ad1a0a11c9"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3913), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są zapytania o media CSS i do czego się je wykorzystuje ?" },
                    { new Guid("752c0a5f-bef4-4132-8bd0-b1b0bec56455"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są i czym się różnią UNION od UNION ALL ?" },
                    { new Guid("75fae71d-b6e8-4762-80a1-6395c2da53ac"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2856), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest autoryzacja ?" },
                    { new Guid("769f13a3-710f-4bc5-a7b8-b523f9cda1f2"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Injection ? Jak to wygląda niskopoziomowo w C# ?" },
                    { new Guid("76b3f92d-a7be-4696-a8e6-4fca8579e508"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa partial i po co się ją stosuje ?" },
                    { new Guid("78701a5e-4f43-427f-9d43-b58e32271eed"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2433), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest polimorfizm dynaczminy i statyczny ?" },
                    { new Guid("7962827a-446f-440e-86c1-bd7fa6f98a09"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest sekwencja np. w PL/SQL ?" },
                    { new Guid("79bc658f-4e20-4d87-9436-ebd5384b09c9"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3157), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działają operatory \"is\", nameof i typeof ?" },
                    { new Guid("79e88085-fd6e-43c0-b16b-fff068aeef32"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest HTTP ?" },
                    { new Guid("7b5b3853-4abf-4fef-9e92-d58dfc32e588"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest wielowątkowość ?" },
                    { new Guid("7b95534a-9b53-42c7-bbcd-59914ce20ebe"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy miałeś do czynienia z Elastic Search i Kibaną ?" },
                    { new Guid("7d7f08e3-d003-4a54-ba6f-bf688cd218d4"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2752), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co zawiera ramka HTTP ?" },
                    { new Guid("7e503961-c74f-49f8-a950-9a18181d7aa1"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można zbadać problemy wydajnościowe z EF ?" },
                    { new Guid("7fb40f57-6dde-447b-beaf-a55decd22260"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2676), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega code-first ?" },
                    { new Guid("7ffe5055-1d74-4f5d-a895-1f9ed51e07ba"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2655), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z jakich technologii ORM korzystałeś ? Podaj wady i zalety poszczególnych." },
                    { new Guid("830768a9-bf14-4440-876e-b873cfe0aa85"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Stworzyć repozytorium z kontekstem. Przprowadzić operacje pobrania i zapisania danych." },
                    { new Guid("83320b70-e235-4b6f-bf45-08d40b2ac7c9"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz rodzaje JOINów ?" },
                    { new Guid("858fae3d-5c08-489c-9f84-467362508751"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się szyfrowania symetryczne od asymetrycznych ? Podaj przykłady algorytmów i protokołów, które są na nich oparte." },
                    { new Guid("85cc0a21-abf0-4e28-8a05-ed67902d8fbb"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są trzy sposoby na realizację dziedziczenia encji ?" },
                    { new Guid("860ba42c-cf5c-46c2-8a3d-525e874ecd72"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Scrum ?" },
                    { new Guid("8669efd2-fb86-49b5-9728-b0e151dc49b5"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Agile ?" },
                    { new Guid("866b6fa5-3838-4333-b3b5-d7741e6214d2"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są Claimsy ? Coś o ich przesyłaniu ?" },
                    { new Guid("86be3b0c-7593-461e-92d3-0d1ceecf133e"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3779), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest bubbling eventów ?" },
                    { new Guid("86e61fe8-8ddb-44fd-86ff-231b661a1175"), new Guid("a483b653-422d-41bb-a2ba-c8793bf1cd6d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3487), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest WCF ?" },
                    { new Guid("86f252cf-8ebe-4977-9539-87ae9406a243"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest .Net Framework ?" },
                    { new Guid("87b18f85-fd25-4713-9f79-593643a24e13"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się pole const od static readonly ?" },
                    { new Guid("8945be47-30c2-4d13-a4c2-e57dfefe67a9"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Continous Integration ?" },
                    { new Guid("8b5cb507-1eba-4063-a2d1-58633f5845fb"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy każdy wątek ma swój oddzielny stos ? Ile stosów mamy w aplikacji ?" },
                    { new Guid("8b67bc9d-795b-4d9d-b762-f6c1598462b3"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy w REST wywoływana jest autoryzacja ?" },
                    { new Guid("8bec399d-03bf-43f1-bbee-7b914f3c144b"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest .Net Core ?" },
                    { new Guid("8d551968-e7f9-4db3-a899-691814a39d45"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest CLR ?" },
                    { new Guid("90127e7c-4e73-41c8-8cea-83a90edcaaac"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni rzutowanie bezpośrednie od wykorzystania \"as\" ?" },
                    { new Guid("90a389a0-c39f-4662-90f6-a065d77a2021"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2513), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy kiedykolwiek używałeś DDD ? Podaj przykład z życia. Jak korzystałeś z tego w projekcie ?" },
                    { new Guid("911494fb-291c-4ae1-bcb9-24fe8c81d6ca"), new Guid("a483b653-422d-41bb-a2ba-c8793bf1cd6d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3492), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to jest WCF ABC ?" },
                    { new Guid("92c6a6e3-4077-4b60-bb86-4ae2dd873a6a"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest OOP ? Jakie są 4 główne zasady programowania obiektowego ?" },
                    { new Guid("9335716f-3247-4cda-8777-3b2f6ce2ee9d"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są interfejsy IEnumerable oraz IQueryable ?" },
                    { new Guid("93e6312a-5b90-4364-9a46-74ddbfafa82e"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3358), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w DI można obsłużyć interfejsy generyczne ?" },
                    { new Guid("96a8df6c-5fb4-4802-9736-4d7ca9860c39"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jak dużym zespole pracowałeś ? Jakie były role ?" },
                    { new Guid("97fbe909-a91a-4e5d-a0aa-dc772a0dda93"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są kolejne działania przy bindowaniu w REST ?" },
                    { new Guid("988f61f2-df8c-4add-9ecd-19c16b8d5d5e"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest tzw. mokowanie ?" },
                    { new Guid("99668908-826e-4dbc-897e-5549c859db67"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki typ zwraca GetHashCode() ? Czy jest możliwe, że zwróci tę samą wartość dla dwóch różnych obiektów ?" },
                    { new Guid("9b9bd6e5-5235-4d02-a749-266d16d81c43"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2997), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest C# ? Jakie są jego zalety i najważniejsze cechy ?" },
                    { new Guid("9caeed11-eef1-4c14-8b7d-07d49ec63f8d"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Singleton (dlaczego to czasem antypatern)" },
                    { new Guid("9f15a8b2-144e-404b-9817-d1b1b5d2d9d1"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2694), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Load Balancing ?" },
                    { new Guid("9f6a1f9e-f75c-4a1d-ade7-76fd668aab90"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między rebase a merge ?" },
                    { new Guid("a070c9ef-8b44-4f52-bea1-e4259f7b5a2d"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy tworzyłeś kiedyś diagramy UML np. przepływów, use cases itp ?" },
                    { new Guid("a18bfe32-374d-40fb-842d-e3cdbb46b929"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2779), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa parsowanie ?" },
                    { new Guid("a1ca4424-2447-4166-8ce8-ab8c6c38303e"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2414), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła YAGNI ?" },
                    { new Guid("a31a2709-b3b3-463e-9091-4df77db66df4"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni GIT od TFVC ?" },
                    { new Guid("a5da390c-217b-48ba-b3b6-c621ec3b3a5f"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie rodzaje autoryzacji znasz ? Jakie implementowałeś ?" },
                    { new Guid("a77e3528-123f-4dca-ac0c-da729c007907"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3017), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między var a dynamic ?" },
                    { new Guid("a7abd5a7-828d-4288-b609-2757e36c790c"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między JS a TS ?" },
                    { new Guid("a7d222e1-55f0-40d7-9274-3c8d646b8fca"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień i opisz kolekcje występujące w technologii .Net." },
                    { new Guid("aad5a1fa-756f-47da-a2dc-cf0017c40fc8"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Observable ?" },
                    { new Guid("ab944c82-e1a1-4ac7-8288-da5bdb58f800"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Chmura ? Jakie znasz rozwiązania ? Czy masz z tym doświadczenie ?" },
                    { new Guid("ac85330f-2e3f-4279-895f-fdeb136a9c2a"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2837), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest bindowanie ?" },
                    { new Guid("ad22ef2a-dc48-4c02-970d-e53ae765cda8"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2847), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie zasady spełnia dobrze zaprojektowane URI ?" },
                    { new Guid("ad6dd982-4c38-4954-84c7-8d44d99b36be"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni POST / GET / PUT ? Jak przekazywane są atrybuty do tych metod ?" },
                    { new Guid("adacbcca-34e4-4099-9665-f438bf125499"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3826), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wywołujemy zapytania asynchroniczne po stronie klienta ?" },
                    { new Guid("ae8e3085-58a1-4a90-acd0-cdffdc24f7eb"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która konfiguracja jest domyślna eager czy lazy ?" },
                    { new Guid("af31cda2-ec65-44a5-a295-f92f0aee8ce6"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2488), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy według ciebie pisanie testów jest ważne ? Jakie mają zalety ?" },
                    { new Guid("b0cffa66-9645-449b-8264-64bfe68d9989"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w twojej pracy wyglądało wykorzystanie Scruma ?" },
                    { new Guid("b0f19424-806e-4b56-b0eb-0c8a0e48abf1"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Unit Of Work" },
                    { new Guid("b127ede9-9bda-42cc-b8d0-d4998c853246"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można zadeklarować Task zwracający void ? Czy jest to preferowane podejście ?" },
                    { new Guid("b1368602-abd5-4258-8cb1-438c53ef563c"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz poszczególne operacje systemu kontroli wersji GIT takie jak np. push, rebase" },
                    { new Guid("b16154e3-4424-4744-b16e-fc02b0628900"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się bazy SQL od noSQL ?" },
                    { new Guid("b1fe23d5-587c-44bf-b603-f7e6d6fe9d8f"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3022), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest delegat ?" },
                    { new Guid("b27a1eef-4fa0-4c3d-bfd5-830bc4ab8f6b"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda analiza w standardzie DDD i jak ma się ona do kodu ?" },
                    { new Guid("b3feae13-cf1a-4685-a7d1-3a3240f875cb"), new Guid("4f6935de-3749-4151-a94f-172f9cd2b582"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda full scan i index scan tabeli ?" },
                    { new Guid("b512be30-bb65-47e9-9113-8f4facc893eb"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak ustawić CultureInfo dla głównego wątku ?" },
                    { new Guid("b8e541bb-6aa3-4bd3-84ef-6b8489ca168b"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2323), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVC" },
                    { new Guid("b92c79f7-0ae8-48ea-a4c3-5d5ba329421f"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy przeprowadzałeś Code Review ? Jak to wyglądało ?" },
                    { new Guid("ba4549d1-2ee3-43a0-acc7-8e15cf202b84"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2424), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła TDA ?" },
                    { new Guid("ba848a7d-986e-42eb-ad4e-bc361b4727d3"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co nowego wprowadza technologia .Net Core w porównaniu do .Net Framework ?" },
                    { new Guid("babaf16e-d9bb-476e-87a3-778c858ffe32"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2272), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różną się wzorce fabryki abstrakcyjnej i metody fabryki ?" },
                    { new Guid("baef6fb2-10d2-4cb3-be3b-3f25d08f88a7"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak uzyskać relację wiele do wielu w relacyjnej bazie danych ?" },
                    { new Guid("bb461e1f-796b-4685-8343-d4c440e022b0"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3682), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni WHERE od HAVING ?" },
                    { new Guid("bbe1d296-9c26-4bb4-8e5f-6cba0694d58e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2294), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Strategia" },
                    { new Guid("bc4dc63a-76b2-4c97-879a-5eb31787fa2f"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOA ?" },
                    { new Guid("bda4fd83-c466-4c62-92e3-29ffea482124"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica pomiędzy ref i out ?" },
                    { new Guid("be6e1536-9afc-4a8c-9ef9-c0645a50b026"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między REST a SOAP ?" },
                    { new Guid("be7270af-4522-4a30-87b9-79115e0cbbc1"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3797), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak osiąga się responsywność w bootstrapie ?" },
                    { new Guid("bf592399-668a-49e5-9e2d-dd7a71414fa1"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest extension i w jakim celu się stosuje ?" },
                    { new Guid("c1bcdc52-35f2-4b31-94fc-1ba3b7f880ea"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak realizuje się wersjonowanie w EF ?" },
                    { new Guid("c1c4a25a-693b-4dae-86e3-7ce3d78f49dc"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest branch ?" },
                    { new Guid("c2eef656-1eec-447b-a5e8-749198681708"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest REST ?" },
                    { new Guid("c361d714-8e2f-4a3b-ba64-6143182461eb"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2542), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień poszczególne kroki CD ? Jak wyglądał Pipeline ?" },
                    { new Guid("c3ebcc54-5673-4c39-ba0b-344daaabe56e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2361), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Circuit Braker" },
                    { new Guid("c40a9c60-8dd6-4069-8873-b5784d8e0f0c"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blokowanie pesymistyczne." },
                    { new Guid("c447f2b6-5325-4229-b1bf-211c4a9f74d3"), new Guid("0ed03359-a7dc-4eb4-a616-044557143b43"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Preferujesz dokumentowanie bezpośrednio w kodzie czy obok ?" },
                    { new Guid("c48b3efc-1318-44dc-8a75-884d47abd2be"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy za pomocą refleksji można dodać nowy typ ?" },
                    { new Guid("c520d554-472c-4741-8b72-1827502afa78"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2281), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Obserwator" },
                    { new Guid("c764af9c-6174-4359-a33f-7c0f9dcaaa0a"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w SOLID można złamać regułę L ?" },
                    { new Guid("c7a4b37e-82a9-47a2-aba2-bda4a3ae8be3"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy DbContext jest thread safe ?" },
                    { new Guid("c81aa398-64ba-4a9d-839c-57c3a487759e"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak testować zapytania EF ?" },
                    { new Guid("c878ba22-ffaa-48bf-800e-6f3804e098ac"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Przedstaw ideę dziedziczenia na przykładzie z życia." },
                    { new Guid("c98dbd0a-dbab-4b61-850e-36b2d8c9ae49"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są profilery ? Jak działają ? Z jakich korzystałeś ?" },
                    { new Guid("c9b26f8e-8d20-4269-ae75-25235d3d0b58"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się proces od wątku ? Jak to się je z dostępem do zasobów ?" },
                    { new Guid("c9ca539f-dfc5-461d-b26e-6d04514ce717"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak bada się pokrycie testów jednostkowych i integracyjnych ?" },
                    { new Guid("ca48972e-ee90-4161-94b5-ebd1e370f7e1"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są rodzaje konfiguracji w Entity Framework ?" },
                    { new Guid("cb089a77-19f7-42c4-9177-dd414f39d971"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się procedury SQL od funkcji ?" },
                    { new Guid("cc1d9686-75ee-442a-a6b1-b622bc889b48"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są Scrum'owe rytuały ?" },
                    { new Guid("cd40378d-297d-43ae-84a1-a8cd57b1c17e"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2685), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się code-first od database-first ? Które z rozwiązań wykorzystywałeś ? Które preferujesz i dlaczego ?" },
                    { new Guid("ce6cdbc4-a061-4a69-bc8e-f0a561ee734f"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są generacje w GC ?" },
                    { new Guid("ce6f8d29-e920-4166-8118-d4bf9acbfe79"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3296), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dlaczego korzystając z .NET Core można tworzyć aplikacje na serwery Linuxowe ?" },
                    { new Guid("cf720951-b8aa-45ab-8094-0ffb4f0ad343"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2833), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda flow zapytanie-odpowiedź dla REST ? Kiedy i jak odbywa się autoryzacja ? Jak działa parsowanie ? Jak można wpływać na domyślny parser jsona ?" },
                    { new Guid("d01ade4f-11dd-4000-99d5-2b20a8effc1b"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3367), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa GC ? Kiedy wywoływany jest GC ?" },
                    { new Guid("d0a4f1a4-5ee3-4081-8a9e-c42d779d0953"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jaki sposób można rzutować wartości na inne typy ?" },
                    { new Guid("d0dcbdb7-4286-4dd8-8360-7d8245df1182"), new Guid("4f6935de-3749-4151-a94f-172f9cd2b582"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3648), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest zasada ACID ?" },
                    { new Guid("d1cbd8f8-5dcb-449f-bc18-1fbe809ded0a"), new Guid("0ed03359-a7dc-4eb4-a616-044557143b43"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2171), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie rodzaje dokumentacji stosuje się dla logiki biznesowej ?" },
                    { new Guid("d2322259-53ab-49ad-8a33-4275ed80db1e"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2442), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która zasada OOP według ciebie jest najważniejsza ?" },
                    { new Guid("d30e38c0-20b5-4cf3-af03-fbbdd0bb2821"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2157), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak podchodzisz do rozpoczęcia historyjek analitycznych ?" },
                    { new Guid("d47e5c51-c3cb-4108-a853-6ea745d90bb4"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest .Net Standard ?" },
                    { new Guid("d607c451-2fcb-40c3-9541-2240ef47e961"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Ile języków funkcjonuje na platformie .Net ?" },
                    { new Guid("d7d4fe90-a008-4ded-a780-6cf1c74e3ae5"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3443), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są middleware ?" },
                    { new Guid("d8841a6f-5c61-4a46-9488-eafe428de042"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest parsowanie ?" },
                    { new Guid("d8e85871-8d55-44d4-84cc-ba45494b6bf1"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2290), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Adapter" },
                    { new Guid("d976bef2-9896-4070-829f-c4095829bd83"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(1964), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz narzędzia pracy zespołowej ? Korzystałeś z Jiry, Confluence ?" },
                    { new Guid("d9d341da-7bc9-4b2b-ab4b-26150fefeb56"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2795), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między SOA a mikroserwisami ?" },
                    { new Guid("d9f01ee0-84c0-41d7-a2e1-1d541045c910"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa SelectMany ?" },
                    { new Guid("da514d02-403d-4aef-be09-e87f0fd86b07"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak dostać się do kodu źródłowego biblioteki ? Czy korzystałeś z dekompilatorów ? Jakich ?" },
                    { new Guid("dbc2bd16-b2dc-4799-a51a-28bedf3025c3"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy tworzyłeś kiedyś customowy atrybut ? Jaki?" },
                    { new Guid("dc34abd4-08f6-4392-a05f-cc3a609d4441"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2880), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to jest reference token ?" },
                    { new Guid("dce0bc0d-bf25-4ab4-9127-2f89127c5039"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak na poziomie infrastruktury poprawić działanie wolno działającego serwisu ?" },
                    { new Guid("dcf5fcef-a997-4553-8e5d-12df24b774e3"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2975), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest deadlock ?" },
                    { new Guid("dd87782f-98c0-46ae-bb41-3dde64eb6b97"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Media Query ?" },
                    { new Guid("de412ca4-4ba9-403f-96c8-d0b51f536857"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest tracking w EF ? Jak działa ?" },
                    { new Guid("de7e6071-32b7-40f1-8549-0c639f4424e5"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3855), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co wykona się pierwsze: konstruktor czy metoda OnInit ?" },
                    { new Guid("df2f97df-bc1f-46fc-adb4-d35c69a75304"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3107), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można zastąpić IDisposable poprzez try/catch/finally ? Dlaczego się z tego w takim razie korzysta?" },
                    { new Guid("dfffec75-eaf3-48be-87cc-e6d5484b05c0"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2314), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mediator" },
                    { new Guid("e000c8b2-3dcb-4e75-886b-c726601763e3"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3272), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy za pomocą refleksji można dodać property do istniejącego typu ?" },
                    { new Guid("e09b587c-592f-400a-9c3f-fa784f0727e3"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2395), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOLID? Opisz wszystkie zasady. Podaj przykłady." },
                    { new Guid("e1ab612a-d804-4b78-8697-565049d3696b"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie w mechanizmie wywoływana jest metoda Dispose() ?" },
                    { new Guid("e1d26477-fadf-486a-9c59-70359fe6a289"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOAP ?" },
                    { new Guid("e3c313de-fdce-48ac-98be-6ffe06d76160"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3046), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Pytanie typu, co zwróci wyrażenie `var zmienna = new Abc<x, y, z>((a, b) => a == b)` jeśli nieznane typy to object" },
                    { new Guid("e4e43f06-e9f8-44c3-b9df-d6c2fe12eed1"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie usługi dostarcza AzureS i Azure DevOps ?" },
                    { new Guid("e541943c-040d-4337-a86c-7d1a09f82c30"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są submoduły w GIT ?" },
                    { new Guid("e599c38c-7ee6-4f03-9a6f-b67c4a2e7a10"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3908), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są trzy metody dodania CCS-a do strony ? Opisz wady i zalety każdej z nich." },
                    { new Guid("e67ac04b-124c-4eef-84a6-8d904d3b4f05"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy REST realizowany jest tylko z pomocą protokołu HTTP ?" },
                    { new Guid("e7603769-d10f-467d-8bb6-30757502d550"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz mechanizmy synchronizacji wątków i z jakich korzystałeś ?" },
                    { new Guid("e84fd973-6ae1-493c-b30e-3c742a33ce4b"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2741), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Które z podanych to metody HTTP (get, post, put, patch, insert, update, input, delete) ?" },
                    { new Guid("e852c39f-b7b1-4f45-ba75-dbbb99b447cf"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3374), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można manualnie wywołać GC ? Jak ? Jeśli można wywołać manualnie GC to czy czyszczenie wykona się od razu ?" },
                    { new Guid("e8a237f8-1bc6-4c1d-bd84-b8188b9127b3"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadanie, w którym robiony jest Replace() na stringu ale nigdzie nie jest przypisywany rezultat i co zwróci zmienna ? Łatwo się złapać." },
                    { new Guid("e8ce897f-64c4-4ee7-9bbf-4a48ff73c18a"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy różni się argument od parametru ?" },
                    { new Guid("e9bea540-58cc-420b-ba07-759182c60059"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co przyspieszają indeksy a co spowalniają ?" },
                    { new Guid("e9dd18fd-4ca6-4a6b-acb7-a23c0c1e72b7"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3310), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są różnice między Javą a .NET ? Który język wydaje ci się fajniejszy ?" },
                    { new Guid("ea88a793-93b8-4999-a229-88f715c485cd"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2728), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zasymulować stanowość HTTP ?" },
                    { new Guid("eb5b2bde-b791-4fa0-b1a6-da58ea74c1ef"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3848), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można przechować zmienną w Angularze ?" },
                    { new Guid("eb6503bb-42fb-4d90-984e-ab319b51c1d3"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3387), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy GC dotyka typów value podczas czyszczenia ?" },
                    { new Guid("ebdbc4b5-6296-4739-95ef-5227c48739d9"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3161), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między typami string i String ?" },
                    { new Guid("ebe272b6-b111-42b4-b54b-43a6e5fbdf3e"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co robi atrybut FromUri ?" },
                    { new Guid("ebededed-7acd-484b-9d40-0db6ca8538b5"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2299), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Template method" },
                    { new Guid("ec7cc642-506b-4eaf-b7f5-555807cf65a9"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Metoda fabryki" },
                    { new Guid("ec8b6469-8ea9-49b9-b948-f055b4ddfb9c"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2479), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są testy jednostkowe ? Czy pisałeś ? Z jakich technologii korzystałeś ?" },
                    { new Guid("ed6e565a-8aba-448f-9067-b6cc48df261b"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest CSS preprocessor ? Korzystałeś kiedyś z tego ?" },
                    { new Guid("edf4f4ca-3cb7-4215-a8c3-8e3b9c97dca1"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki jest cykl życia obiektów zarejestrowanych jako singleton, scoped i transient ?" },
                    { new Guid("ee6f4eeb-5c79-4253-bc89-83e3356c23ca"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3319), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest  CLS ?" },
                    { new Guid("ee8c4bdb-c7f6-4985-bbea-356c9a5c4ff3"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Auth Guard  ? Jak działa ? Z czego się składa ?" },
                    { new Guid("f03a2bfe-c46e-48ec-934c-514d6c672e62"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3806), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień wszystkie możliwości zapisu document.ready ." },
                    { new Guid("f104e4ca-6404-4ddc-ac3b-fa649f7979f5"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa routing w .Net MVC ?" },
                    { new Guid("f1787c4d-51e4-42cd-83f9-973b114252dc"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy HTTP jest stanowy ?" },
                    { new Guid("f1dd8908-73bc-47a7-a069-095d6a8cf208"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Continous Delivery / Deployment ?" },
                    { new Guid("f3ba0740-3f44-48c5-91fd-11349ff6632e"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co wyświetli for(var i in lista) console.log() (zwrócić uwagę na znaki nowej linii) ?" },
                    { new Guid("f691b410-9ee7-4d01-af5c-826f2e903e2a"), new Guid("4f6935de-3749-4151-a94f-172f9cd2b582"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są 4 poziomy izolacji transakcji ?" },
                    { new Guid("f8b130d7-2590-4d98-9225-33c772122cd4"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3922), new TimeSpan(0, 1, 0, 0, 0)), "https://www.upwork.com/hire/css-developers/interview-questions/", new Guid("00000000-0000-0000-0000-000000000000"), "Zbiór Upwork" },
                    { new Guid("f8ee0e58-7539-4118-8e2d-827f8beedfc4"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest JIT ? Kiedy się wykonuje ?" },
                    { new Guid("f8f09a40-5c88-4638-8576-a8af29a0cb68"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3166), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blok try/catch/finally ? Co kiedy jest wywoływane ?" },
                    { new Guid("f9621ad4-4fe6-4f53-aded-9f4ac49e59d2"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest atrybut ?" },
                    { new Guid("f9e4200a-2fa2-4696-9dd9-b81b7fc38ffe"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3425), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest WebAPI ?" },
                    { new Guid("fb03ee2f-13e3-4a45-bcd7-495b3630b94f"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz zasady 3A i GWT." },
                    { new Guid("fbfb4011-39dd-4d2a-9491-bf6750f20ad2"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Event Bus ? Jakie znasz rodzaje ESB ?" },
                    { new Guid("fc4a8b6f-6e0c-4672-b47a-c5f10e3c5b06"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3042), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Pytania o to, która definicja metody jest poprawna." },
                    { new Guid("fcdec7bf-daa7-4f2b-9022-89f62dce8325"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVVM" },
                    { new Guid("fd11855a-a334-4310-8a62-e84c843b69f8"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się indeks klastrowy od nieklastrowego ?" },
                    { new Guid("fd1f6b99-fbd1-42ee-a234-c8d5357fb216"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie mamy typy zmiennych w C# ? Jak są przechowywane w pamięci ?" },
                    { new Guid("fde9841c-19fc-4103-b2cc-17eda05c3117"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Semafor" },
                    { new Guid("fe613131-9a0e-4820-b964-708d7bbd378f"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Do czego służy WebHostBuilder ?" },
                    { new Guid("ff303bf6-e99c-4e99-80c9-527a973b87de"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym charakteryzują się klasa abstrakcyjna i metoda abstrakcyjna ?" },
                    { new Guid("ff9800e5-f64a-405e-b8df-a165aa4291d0"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(2319), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega wzorzec CQS i CQRS (command, action)?" },
                    { new Guid("ffb9b1ed-d994-4be9-898f-74df03b53f82"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 22, 14, 29, 148, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można optymalizować DOM w przypadkach responsywnych ?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0051ca25-42ea-40af-b7d2-abecaaa6b1c4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("01c45d24-c099-4830-9da1-e080327f27e1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("01cc04aa-f339-4da0-b6dd-ce1fb2e5457b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("01e4e571-20e3-4ddb-b9b9-9857174989d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("01f8f3c5-78d3-4e28-9bf2-a210185c34db"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("022de402-b693-4ba2-884f-eb7e6bf65312"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("02675f57-fa84-4513-8a79-be090412eeef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0293e2f0-7b12-4ee7-8ac7-1212f89fa8ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("02cc8a4d-fb9b-4e9f-924e-651a6d25610a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("03c70d90-0aac-4de2-bc1c-2435c02ca5a4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0491b354-3620-4faf-882a-890ef0859c1d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("057cb58b-dc82-41ba-9e33-b2c810785f12"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("05befb07-31a2-4ef1-9401-c2f69f1fa5be"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("06aa7204-e12b-497d-91f7-e0d2f6bfb877"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("06e9241b-707c-4090-bbb4-29545191d051"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("08d2200e-5f0d-4d74-a666-2fb71894f430"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0a9dbdcd-518c-48e5-bcb3-bb8e094511e1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0c100b72-8b10-4c2c-a133-943880653cb9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0c5d5d5e-712b-4f80-846c-b0c1ce6648c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0cdf6947-75aa-4ac7-a313-9d863f55c758"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0dc7e8f4-8f56-4688-9e8c-b17d4369c0b8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0e8ec9a9-c05f-4c57-b433-03496d8dc4c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f3d67e8-c6b7-49de-9b8f-ec521d2d70ec"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f5b5d4e-1006-4258-9640-bcbb44ed6a43"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f824f1d-ec09-44d8-82cc-abec8cd9b611"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f8e0628-82d3-4d6d-b721-f7116907c13e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0fcef0bd-c1f0-4a80-a2df-400a51f43759"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("114a0000-b9fa-41d1-9a8f-0e18512ec52b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("11560d63-ede0-4f29-bf57-9c6fcca5cd72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1408052e-e59f-4504-af0b-845d465eac7a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1438204e-6b9a-43b9-8ae5-92da38f8d0b6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("15a1533c-05d7-4ce7-930e-cc833ae7f41f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("16145d6d-eb99-49ec-abd1-5727ddd88f9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("162fd488-a13c-477f-ae8a-98af80eac07b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("16a4c894-cf61-4dcc-9a43-b8259aac9dbd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("16beb49b-9a4a-4601-a306-0ab6660d66e6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17262015-2bf4-4294-8cc3-c6d38c0962b5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("174300af-f168-4535-bc0b-9ba00be67ba8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("174b888b-70c1-4d08-8911-a880b073dd87"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1bd68d06-302d-4dd7-b621-f6418d98485b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1bf3d4a7-d225-40db-a30d-71573f394758"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1bfc913a-5677-4095-97ae-e75f30e67131"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1c25426c-03ba-4cb3-94de-5b391092c74f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1ca0973b-1782-4836-8581-5ac674ffe9bf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e83d60b-d913-4239-8976-fce83cf3764e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e9b296d-2ae9-45ff-bace-53c1cbae6fb5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1f5159b8-c3d5-4e3c-b085-899836683266"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1fdce86b-1e52-46ed-83ce-459da8837acc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1ffbbc50-709d-4b12-84b0-e2c581fe2b80"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("210260f4-b6d4-4b67-9920-31198ce4a4b6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2198f479-343e-4bac-96e8-d1036e01aabd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("23337652-61c3-4bae-a009-cff1447db68e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("23ac7efa-b559-4b40-b753-23126bf07a20"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("244fa13d-f0bd-4246-88e1-4831ff74fdcd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("248cd669-00dd-44af-bb69-2e108b83b3b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("249ec25b-f63c-47d3-b4eb-9f33a478be10"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("24b49006-1ab7-4907-9fd8-ed4822938041"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("24da753f-f2e6-4df5-af7e-b1090f8af2de"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("25305eaa-f4dd-478f-b583-b0a1e108d016"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("25dc08bf-d396-464a-af6a-16795214380f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("267a9612-4924-4363-ad7e-cb02c3520d91"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26a5e8c7-24f8-448b-bd36-dd3e709ca576"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26cec6d2-1d84-4011-bbcf-cdb0160e7b9f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("27197b63-987a-464c-94f0-d0c5c7a7ef04"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("29299587-35e5-499e-ae04-f13bc3bb5c74"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2932ec3c-826f-4db3-830e-4c959155cc32"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ace9f6f-0fd3-436c-99f2-c8f50baa2c5f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ade53cf-08b4-45f2-b8cd-337ebf4478d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ce1bc7e-1143-4dfa-bd90-3bfbc8a44a8a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2d7bd076-0aa2-4c98-9c02-4db7a4f07a90"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2dadd0e5-abb1-4279-a7b8-ca0c24042c99"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2f5a0b07-a861-46dc-a05f-9eef8f1e8bc4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2fd1cbc0-a5b5-4231-bb32-8dd3a07794c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("310afa4c-1239-4c5f-95c0-016516e966c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("31f39ec8-95d2-4a81-a787-8883c6f95b94"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("32aa2267-cbdc-4903-840f-446198d77091"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("33f43113-b983-4409-98ef-8419bfa4be0f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("342ce447-b67a-43b7-bd98-25e63e333628"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("345fcd52-9371-4003-ae1c-262eb755c526"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3664b1ea-d596-4218-aa94-889411b5961f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37736a95-ca68-419a-b62d-71d05e4a8ad3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3783869a-551b-4c12-86cc-77043dd424ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37bb3141-03a9-48d5-964a-2f7699b7dd64"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37ee4dbe-0dbe-47cd-9aa4-3f1ff6959f0c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("384ddd0c-ebef-4a1f-b14d-6462e86c26cf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("393ea3e9-7493-4a4a-ae16-1eb064b56c1d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3a1b65d3-4677-4b02-96de-8583717f8ece"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3a727677-9c73-409c-a014-ed081291c77c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3a96b1ac-cb5d-412e-86ef-5254580b38c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d4a267e-3593-49d3-b523-4459428810ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3ec1e4dc-bcb0-4f03-a56d-37088a86c714"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3ef2058b-0e4b-4bf5-8eb1-290163c5c180"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3fd7681f-095a-447a-816c-382aa0778131"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("407f6147-2162-46e8-8e7c-0a110917e806"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("41e0f6c3-1fe5-4ea1-8dd4-57b1cddf34ef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("423454eb-0e08-4c78-9e86-4fc218c148a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("42538fc4-661d-4bbb-8977-f5ecccbb689a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("43d9ee8d-00b9-4bee-bb77-3ad8a839e053"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("44970d6a-0b3d-4b5c-b307-2576b6326b40"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("44a03c5b-6903-4753-81b3-9587b103e309"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("44d19d35-e514-4e02-a8e1-c284aebe1d20"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("454ce22f-1b0b-4a31-bc15-b0fb46b0fe8f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("45fac73d-f42e-426d-bc6b-74ba6f4fe289"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("46144920-956a-4cf8-9213-6c0ea92418d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("481cc80a-e1c4-473e-b55d-62655822a5ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4832a094-8101-4da1-b112-4f056549f1f6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("48911cad-8fd8-42b4-8ad1-a66577a4c021"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4979cc36-b80c-4b5a-a102-c5f7e1bf924e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("49e381da-a36a-4afb-8f83-76e5468ac495"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4a3d0002-934a-489b-9340-ad70d94443f8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4b786655-2a24-42a0-9ac0-2707fe896a48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4b9e179c-caac-43a2-8ee7-f14451d4d16a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4ba88c0b-c526-40fc-a090-969aa9f1d7a8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4bfd469f-7b45-4951-b67e-41eb93f45f46"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4c50d469-b711-482b-83e0-adb7c5606540"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4ca6abf4-a8fb-45d0-9bc3-ac139f2bb2c6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4cc928b5-30f7-478f-9d3c-bf33d9a239af"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4cd66fb8-f249-4e25-b853-d6ab5f0d47fb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4ce8bf54-2f2e-44ae-8446-278af90e0b72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4d723cca-bf08-4c37-bb10-dee10e1abb6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4d86560d-d59e-4883-a6e3-324bc3821c7c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4d9d7bd6-8fb7-47cb-841e-6b2c804632e8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("50a777c0-e359-4cad-a0c5-5f7a98b650fd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("50f39c12-32e9-4e3c-ae6b-c53e2988de00"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5174867f-5d36-4b5e-99d0-8c92eddb24c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("52c5de44-0263-4677-a01d-626afeb417a7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("53b27347-f2ad-4a15-a155-b3eaab77cec5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("53f48520-aa9a-4694-b4eb-0a70bab4bef2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("551ccbea-0d36-4fc1-a04e-6f8c46b41982"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("558613fe-2483-4b05-8f2c-b186dbecdd76"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55c7d4c7-74a8-4c05-a914-6eaa1366cc92"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("56e951cb-37e9-4068-8da2-d51511efb79a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("570ccfe6-bcb4-4b47-b2e9-f38d8a29dc6f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5743f0b8-27db-4cb2-bebc-f058b0fa1a61"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5a11497c-323c-49b8-9ac4-7140a6cc37a0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5a1911ee-8d20-4e68-ac58-afd3e96e03c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5ba11e65-2873-40d4-91a4-4495473e6d44"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5bcf9025-063f-4530-b039-b3dd990049d4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5ccaa497-6fb2-40f0-94a3-8ed96be5b3ea"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d34a193-28f7-4d54-803c-54cd863011c7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5e17f76c-efea-4fcd-b1ba-f48c9813dcaf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5eb36e61-15b8-449c-9815-de01be7191af"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5fc976a5-42e7-49a3-a80f-3a759463b6d9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5fd50bd0-b78c-4ee3-b09f-62e14d97d3a2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("63554ff9-a0a3-490a-b2eb-fa486c26e081"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("63aa099a-6902-4fa8-a1bd-2ffbbfef78a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("645344da-30ca-498d-8c9a-4a5b379c8316"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6464064f-6df5-4ce5-9354-c247729c8196"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6503dd81-2141-424d-a060-213da7a8998b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("651181c3-e0f1-4db4-b91b-61346637bdd5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65e39fb2-dc80-4ff7-a399-d47424de339f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("67327df3-d9b2-484c-9a5e-b8d1629e6a4e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("682a68eb-ae5d-45cd-9fe6-b8801fe44863"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6941e1f9-0999-4f64-bf00-2a4069b9395b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6964f254-40f9-4b46-9974-22447275f019"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6973a80a-d776-47e5-834c-fefd6d622166"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6a695729-b491-4f3d-b28d-39c728b78451"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6b222e1b-5d44-4316-86de-9568444bc705"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6b9aaa7a-2688-4fd5-9023-ead8ed826744"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d21727e-8237-44a2-8483-f22d4a0eb97a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d9a5f8f-aaaf-4846-940d-3bd5b489660e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6dbb6c6b-8e85-4fbe-9186-bd7e13f57bbf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6e06238d-2dae-4acd-9707-e4351aeabe69"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6f8df0d0-2db5-439a-a057-8dde0548fcc1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("709974d5-5c87-45c5-935a-b0df1ca3c5e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("70d786d2-8c2e-4b8a-a20e-5a4804cd11f4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("70f4f6c4-e916-40a5-930a-2ead1b800132"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("71783630-f072-42c1-98d3-712df5d8d1e7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("74bf38a6-4ba0-42cd-ae2d-d0a973111619"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("74fd7ed4-58ce-44d5-810c-bd659e149bff"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("75285bb7-bcae-40e1-8f2e-b2ad1a0a11c9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("752c0a5f-bef4-4132-8bd0-b1b0bec56455"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("75fae71d-b6e8-4762-80a1-6395c2da53ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("769f13a3-710f-4bc5-a7b8-b523f9cda1f2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("76b3f92d-a7be-4696-a8e6-4fca8579e508"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("78701a5e-4f43-427f-9d43-b58e32271eed"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7962827a-446f-440e-86c1-bd7fa6f98a09"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("79bc658f-4e20-4d87-9436-ebd5384b09c9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("79e88085-fd6e-43c0-b16b-fff068aeef32"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7b5b3853-4abf-4fef-9e92-d58dfc32e588"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7b95534a-9b53-42c7-bbcd-59914ce20ebe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7d7f08e3-d003-4a54-ba6f-bf688cd218d4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7e503961-c74f-49f8-a950-9a18181d7aa1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7fb40f57-6dde-447b-beaf-a55decd22260"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7ffe5055-1d74-4f5d-a895-1f9ed51e07ba"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("830768a9-bf14-4440-876e-b873cfe0aa85"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83320b70-e235-4b6f-bf45-08d40b2ac7c9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("858fae3d-5c08-489c-9f84-467362508751"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("85cc0a21-abf0-4e28-8a05-ed67902d8fbb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("860ba42c-cf5c-46c2-8a3d-525e874ecd72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8669efd2-fb86-49b5-9728-b0e151dc49b5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("866b6fa5-3838-4333-b3b5-d7741e6214d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("86be3b0c-7593-461e-92d3-0d1ceecf133e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("86e61fe8-8ddb-44fd-86ff-231b661a1175"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("86f252cf-8ebe-4977-9539-87ae9406a243"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("87b18f85-fd25-4713-9f79-593643a24e13"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8945be47-30c2-4d13-a4c2-e57dfefe67a9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8b5cb507-1eba-4063-a2d1-58633f5845fb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8b67bc9d-795b-4d9d-b762-f6c1598462b3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8bec399d-03bf-43f1-bbee-7b914f3c144b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8d551968-e7f9-4db3-a899-691814a39d45"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("90127e7c-4e73-41c8-8cea-83a90edcaaac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("90a389a0-c39f-4662-90f6-a065d77a2021"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("911494fb-291c-4ae1-bcb9-24fe8c81d6ca"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92c6a6e3-4077-4b60-bb86-4ae2dd873a6a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9335716f-3247-4cda-8777-3b2f6ce2ee9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("93e6312a-5b90-4364-9a46-74ddbfafa82e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("96a8df6c-5fb4-4802-9736-4d7ca9860c39"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("97fbe909-a91a-4e5d-a0aa-dc772a0dda93"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("988f61f2-df8c-4add-9ecd-19c16b8d5d5e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("99668908-826e-4dbc-897e-5549c859db67"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b9bd6e5-5235-4d02-a749-266d16d81c43"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9caeed11-eef1-4c14-8b7d-07d49ec63f8d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9f15a8b2-144e-404b-9817-d1b1b5d2d9d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9f6a1f9e-f75c-4a1d-ade7-76fd668aab90"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a070c9ef-8b44-4f52-bea1-e4259f7b5a2d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a18bfe32-374d-40fb-842d-e3cdbb46b929"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a1ca4424-2447-4166-8ce8-ab8c6c38303e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a31a2709-b3b3-463e-9091-4df77db66df4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a5da390c-217b-48ba-b3b6-c621ec3b3a5f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a77e3528-123f-4dca-ac0c-da729c007907"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a7abd5a7-828d-4288-b609-2757e36c790c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a7d222e1-55f0-40d7-9274-3c8d646b8fca"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aad5a1fa-756f-47da-a2dc-cf0017c40fc8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ab944c82-e1a1-4ac7-8288-da5bdb58f800"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ac85330f-2e3f-4279-895f-fdeb136a9c2a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ad22ef2a-dc48-4c02-970d-e53ae765cda8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ad6dd982-4c38-4954-84c7-8d44d99b36be"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("adacbcca-34e4-4099-9665-f438bf125499"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ae8e3085-58a1-4a90-acd0-cdffdc24f7eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("af31cda2-ec65-44a5-a295-f92f0aee8ce6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b0cffa66-9645-449b-8264-64bfe68d9989"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b0f19424-806e-4b56-b0eb-0c8a0e48abf1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b127ede9-9bda-42cc-b8d0-d4998c853246"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b1368602-abd5-4258-8cb1-438c53ef563c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b16154e3-4424-4744-b16e-fc02b0628900"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b1fe23d5-587c-44bf-b603-f7e6d6fe9d8f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b27a1eef-4fa0-4c3d-bfd5-830bc4ab8f6b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b3feae13-cf1a-4685-a7d1-3a3240f875cb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b512be30-bb65-47e9-9113-8f4facc893eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b8e541bb-6aa3-4bd3-84ef-6b8489ca168b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b92c79f7-0ae8-48ea-a4c3-5d5ba329421f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ba4549d1-2ee3-43a0-acc7-8e15cf202b84"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ba848a7d-986e-42eb-ad4e-bc361b4727d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("babaf16e-d9bb-476e-87a3-778c858ffe32"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("baef6fb2-10d2-4cb3-be3b-3f25d08f88a7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bb461e1f-796b-4685-8343-d4c440e022b0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bbe1d296-9c26-4bb4-8e5f-6cba0694d58e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc4dc63a-76b2-4c97-879a-5eb31787fa2f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bda4fd83-c466-4c62-92e3-29ffea482124"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("be6e1536-9afc-4a8c-9ef9-c0645a50b026"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("be7270af-4522-4a30-87b9-79115e0cbbc1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bf592399-668a-49e5-9e2d-dd7a71414fa1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1bcdc52-35f2-4b31-94fc-1ba3b7f880ea"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1c4a25a-693b-4dae-86e3-7ce3d78f49dc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c2eef656-1eec-447b-a5e8-749198681708"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c361d714-8e2f-4a3b-ba64-6143182461eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c3ebcc54-5673-4c39-ba0b-344daaabe56e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c40a9c60-8dd6-4069-8873-b5784d8e0f0c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c447f2b6-5325-4229-b1bf-211c4a9f74d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c48b3efc-1318-44dc-8a75-884d47abd2be"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c520d554-472c-4741-8b72-1827502afa78"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c764af9c-6174-4359-a33f-7c0f9dcaaa0a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c7a4b37e-82a9-47a2-aba2-bda4a3ae8be3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c81aa398-64ba-4a9d-839c-57c3a487759e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c878ba22-ffaa-48bf-800e-6f3804e098ac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c98dbd0a-dbab-4b61-850e-36b2d8c9ae49"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c9b26f8e-8d20-4269-ae75-25235d3d0b58"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c9ca539f-dfc5-461d-b26e-6d04514ce717"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ca48972e-ee90-4161-94b5-ebd1e370f7e1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cb089a77-19f7-42c4-9177-dd414f39d971"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cc1d9686-75ee-442a-a6b1-b622bc889b48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cd40378d-297d-43ae-84a1-a8cd57b1c17e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ce6cdbc4-a061-4a69-bc8e-f0a561ee734f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ce6f8d29-e920-4166-8118-d4bf9acbfe79"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf720951-b8aa-45ab-8094-0ffb4f0ad343"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d01ade4f-11dd-4000-99d5-2b20a8effc1b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d0a4f1a4-5ee3-4081-8a9e-c42d779d0953"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d0dcbdb7-4286-4dd8-8360-7d8245df1182"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d1cbd8f8-5dcb-449f-bc18-1fbe809ded0a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d2322259-53ab-49ad-8a33-4275ed80db1e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d30e38c0-20b5-4cf3-af03-fbbdd0bb2821"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d47e5c51-c3cb-4108-a853-6ea745d90bb4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d607c451-2fcb-40c3-9541-2240ef47e961"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d7d4fe90-a008-4ded-a780-6cf1c74e3ae5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d8841a6f-5c61-4a46-9488-eafe428de042"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d8e85871-8d55-44d4-84cc-ba45494b6bf1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d976bef2-9896-4070-829f-c4095829bd83"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d9d341da-7bc9-4b2b-ab4b-26150fefeb56"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d9f01ee0-84c0-41d7-a2e1-1d541045c910"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("da514d02-403d-4aef-be09-e87f0fd86b07"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dbc2bd16-b2dc-4799-a51a-28bedf3025c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dc34abd4-08f6-4392-a05f-cc3a609d4441"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dce0bc0d-bf25-4ab4-9127-2f89127c5039"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dcf5fcef-a997-4553-8e5d-12df24b774e3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dd87782f-98c0-46ae-bb41-3dde64eb6b97"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de412ca4-4ba9-403f-96c8-d0b51f536857"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de7e6071-32b7-40f1-8549-0c639f4424e5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("df2f97df-bc1f-46fc-adb4-d35c69a75304"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfffec75-eaf3-48be-87cc-e6d5484b05c0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e000c8b2-3dcb-4e75-886b-c726601763e3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e09b587c-592f-400a-9c3f-fa784f0727e3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e1ab612a-d804-4b78-8697-565049d3696b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e1d26477-fadf-486a-9c59-70359fe6a289"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e3c313de-fdce-48ac-98be-6ffe06d76160"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e4e43f06-e9f8-44c3-b9df-d6c2fe12eed1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e541943c-040d-4337-a86c-7d1a09f82c30"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e599c38c-7ee6-4f03-9a6f-b67c4a2e7a10"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e67ac04b-124c-4eef-84a6-8d904d3b4f05"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e7603769-d10f-467d-8bb6-30757502d550"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e84fd973-6ae1-493c-b30e-3c742a33ce4b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e852c39f-b7b1-4f45-ba75-dbbb99b447cf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e8a237f8-1bc6-4c1d-bd84-b8188b9127b3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e8ce897f-64c4-4ee7-9bbf-4a48ff73c18a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e9bea540-58cc-420b-ba07-759182c60059"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e9dd18fd-4ca6-4a6b-acb7-a23c0c1e72b7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea88a793-93b8-4999-a229-88f715c485cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eb5b2bde-b791-4fa0-b1a6-da58ea74c1ef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eb6503bb-42fb-4d90-984e-ab319b51c1d3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebdbc4b5-6296-4739-95ef-5227c48739d9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebe272b6-b111-42b4-b54b-43a6e5fbdf3e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebededed-7acd-484b-9d40-0db6ca8538b5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ec7cc642-506b-4eaf-b7f5-555807cf65a9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ec8b6469-8ea9-49b9-b948-f055b4ddfb9c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ed6e565a-8aba-448f-9067-b6cc48df261b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("edf4f4ca-3cb7-4215-a8c3-8e3b9c97dca1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ee6f4eeb-5c79-4253-bc89-83e3356c23ca"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ee8c4bdb-c7f6-4985-bbea-356c9a5c4ff3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f03a2bfe-c46e-48ec-934c-514d6c672e62"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f104e4ca-6404-4ddc-ac3b-fa649f7979f5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f1787c4d-51e4-42cd-83f9-973b114252dc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f1dd8908-73bc-47a7-a069-095d6a8cf208"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f3ba0740-3f44-48c5-91fd-11349ff6632e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f691b410-9ee7-4d01-af5c-826f2e903e2a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f8b130d7-2590-4d98-9225-33c772122cd4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f8ee0e58-7539-4118-8e2d-827f8beedfc4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f8f09a40-5c88-4638-8576-a8af29a0cb68"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f9621ad4-4fe6-4f53-aded-9f4ac49e59d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f9e4200a-2fa2-4696-9dd9-b81b7fc38ffe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fb03ee2f-13e3-4a45-bcd7-495b3630b94f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fbfb4011-39dd-4d2a-9491-bf6750f20ad2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fc4a8b6f-6e0c-4672-b47a-c5f10e3c5b06"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fcdec7bf-daa7-4f2b-9022-89f62dce8325"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fd11855a-a334-4310-8a62-e84c843b69f8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fd1f6b99-fbd1-42ee-a234-c8d5357fb216"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fde9841c-19fc-4103-b2cc-17eda05c3117"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe613131-9a0e-4820-b964-708d7bbd378f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ff303bf6-e99c-4e99-80c9-527a973b87de"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ff9800e5-f64a-405e-b8df-a165aa4291d0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ffb9b1ed-d994-4be9-898f-74df03b53f82"));

            migrationBuilder.DropColumn(
                name: "City",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "Offers",
                newName: "CompanyName");

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CompanyName", "CreatedBy", "CreatedOn", "Description", "Link", "ModifiedBy", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("06bea67c-e86d-4fc9-8857-a7b3797912b8"), "Objectivity", new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 1, 0, 0, 0)), "Nowa", "https://justjoin.it/offers/objectivity-technical-architect-azure-and-net-warszawa", new Guid("00000000-0000-0000-0000-000000000000"), "Technical Architect", "New" },
                    { new Guid("35ce72b1-f4b1-4aad-956a-14d2bc7510cf"), "Sea", new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2491), new TimeSpan(0, 1, 0, 0, 0)), "Pozycja", "https://justjoin.it/offers/sea-engineering-manager-warszawa", new Guid("00000000-0000-0000-0000-000000000000"), "Engineering Manager", "Rejected" },
                    { new Guid("9450bd81-6e0f-4a63-91c3-a86d6d03f438"), "Octavawe", new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 1, 0, 0, 0)), "Wygląda ciekawie", "https://justjoin.it/offers/oktawave-software-engineer", new Guid("00000000-0000-0000-0000-000000000000"), "Software Engineer", "Accepted" },
                    { new Guid("fae479c3-d26b-403c-a8e3-6f364897a2b3"), "appsgarden", new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 1, 0, 0, 0)), "Ciekawa", "https://justjoin.it/offers/appsgarden-net-developer-warszawa", new Guid("00000000-0000-0000-0000-000000000000"), ".NET Developer", "Sent" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("007718f0-40be-444d-a9e2-9d04e2a7fe92"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest refleksja ?" },
                    { new Guid("013d2c0a-4f8d-4a98-9a79-34b059f83724"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(452), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jak dużym zespole pracowałeś ? Jakie były role ?" },
                    { new Guid("0299e449-de86-429a-a0b5-1d3a6c62c5b9"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(575), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Singleton (dlaczego to czasem antypatern)" },
                    { new Guid("03b9c2eb-b458-49ff-bcf5-50eb2621be6e"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w DI można obsłużyć interfejsy generyczne ?" },
                    { new Guid("04bee438-d945-4d95-ad76-3bec668ec8bb"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1513), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działają operatory \"is\", nameof i typeof ?" },
                    { new Guid("0552ec0e-7915-412a-8520-17697e24ef31"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak testować zapytania EF ?" },
                    { new Guid("05665ebe-138f-41e4-8fdb-9ec4c72fd42a"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1336), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są wątki foreground i background ?" },
                    { new Guid("05939205-cb07-4f23-823f-4a7d1ce9dfd4"), new Guid("a483b653-422d-41bb-a2ba-c8793bf1cd6d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1829), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to jest WCF ABC ?" },
                    { new Guid("09341edd-b7a5-48de-a0ce-59709a930c9a"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1164), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz podejście mikroserwisowe. Jakie mają zalety ?" },
                    { new Guid("097359c4-3de3-4ee2-b4c1-907054f61ec7"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega database-first ?" },
                    { new Guid("09eae68f-ebc0-4e68-9e5b-bf9b20321be5"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa lock ?" },
                    { new Guid("0ac2c888-883f-4762-be9a-b51eca981d9c"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co zrobić żeby zapewnić unikatowość danych w kolumnie ?" },
                    { new Guid("0afbd27b-54a7-4776-b001-4019000142cc"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co się stanie po wywołaniu np. query.ToArray().Skip(20) w przypadku IEnumerable i IQueryable ?" },
                    { new Guid("0b8382f0-f9b0-4161-a3ec-129dbfc5e339"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1368), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy string jest typem wartości czy referencyjnym ?" },
                    { new Guid("0c7a8e8a-a7df-47bc-b986-8d8c531812c8"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są generyki ? Na co pozwalają ?" },
                    { new Guid("0cc31591-6e32-4d5b-b8b6-1ec82a90e62a"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można zadeklarować Task zwracający void ? Czy jest to preferowane podejście ?" },
                    { new Guid("0cdc4bd9-3cfd-40f5-88c8-66dd225ddc12"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest lazy loading?" },
                    { new Guid("0ddfad65-2347-4296-962c-0e9acec991dd"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1549), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś z mechanizmów wielowątkowych w .NET ? Jeśli tak to z jakich ?" },
                    { new Guid("0e297ce7-581d-4179-aa74-1363c976803a"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która konfiguracja jest brana pod uwagę jako nadrzędna ?" },
                    { new Guid("0e7d9f54-b770-4975-a999-25cea53f68a5"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1705), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie poczynić kroki aby wyzbyć sie circular dependencies ?" },
                    { new Guid("0f9860c2-faf5-4cab-919b-740b32d4a129"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(787), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest tzw. mokowanie ?" },
                    { new Guid("0fbd8d16-8598-4d58-b082-279d5f839cd4"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(570), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz wzorce projektowe i architektoniczne ? Z których i jak korzystałeś ? Najważniejsze wzorce z GOF Gang of Four." },
                    { new Guid("10b905f9-5777-4066-a994-fd3c007dd12e"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między interfejsem a klasą abstrakcyjną ?" },
                    { new Guid("115af467-6e9e-4ea0-9504-9af872beb35f"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Do czego odwołuje się instrukcja this ?" },
                    { new Guid("11a91519-8ce9-42aa-a576-ceae4d4b65a2"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest boxing i unboxing ?" },
                    { new Guid("12148a35-43f0-48fa-bbe1-453e2defa4f3"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w SOLID można złamać regułę L ?" },
                    { new Guid("146ebf9e-91ae-4c57-ae54-7316488b8788"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1321), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Semafor" },
                    { new Guid("158db28d-0725-490b-8b4b-ba467c9ed1cf"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są bazy noSQL ? Jak działają ? Z jakich rozwiązań korzystałeś ?" },
                    { new Guid("15c458ca-92af-461b-846e-8d5e46e6e9d3"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Do czego służy WebHostBuilder ?" },
                    { new Guid("1648969f-1326-45b9-ab5d-28921974e2ee"), new Guid("347e971f-8443-4dfd-aadd-36a06c4d5bf2"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wylistować w linuxie : pliki, foldery, procesy ?" },
                    { new Guid("174bc5df-38af-4bd4-9d80-6e01912c6fec"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dlaczego korzystając z .NET Core można tworzyć aplikacje na serwery Linuxowe ?" },
                    { new Guid("17bc41ef-c0fa-4077-b3ec-c68f4b1b8703"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Strategia" },
                    { new Guid("1806c2ed-7a1b-437b-b73d-e8f557fb1714"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Fabryka abstrakcyjna" },
                    { new Guid("182507a3-0cce-46a1-afe3-baf5d3139407"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest polimorfizm dynaczminy i statyczny ?" },
                    { new Guid("186a041b-fd45-4fd0-b0fe-da90b6cac0ad"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to jest reference token ?" },
                    { new Guid("1924d0cf-0189-457b-9c88-49563b3096d2"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1246), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień i opisz różne typy tokenów w tym czas ich życia." },
                    { new Guid("1a31ef6e-ad33-4344-9fd0-70aecde4a813"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1434), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest struct ? Czy jest typem prostym czy złożonym ?" },
                    { new Guid("1c0f6c6f-5199-4570-a6a2-3820a5526f98"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Template method" },
                    { new Guid("1c812c13-95ea-4020-9541-bf81b1f00107"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1946), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa SelectMany ?" },
                    { new Guid("1d9c04cf-a3c4-463a-b917-d0a3bf871f68"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2149), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wywołujemy zapytania asynchroniczne po stronie klienta ?" },
                    { new Guid("1f59ff15-8cfe-4bb7-a4df-5efcebe8848c"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega code-first ?" },
                    { new Guid("2078e934-8e47-4302-82e0-8c522a006513"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy miałeś do czynienia z Elastic Search i Kibaną ?" },
                    { new Guid("207c2992-4842-4c6d-9e7c-0d072031a2a3"), new Guid("b74d05ea-7d83-4989-b1c5-a28d0a0af4d3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1833), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie rodzaje kolekcji występują w ADO.Net ?" },
                    { new Guid("20aaba49-ee68-4aab-bbb3-26f065643767"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1818), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym w budowie różni się partial od widoku i jak to się ma do layoutu ?" },
                    { new Guid("213d3fb8-1350-41cb-a9d8-35e04c7dea17"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest TDD ? Czy kiedykolwiek używałeś ? Jakie miało znaczenie ?" },
                    { new Guid("2207d6ab-f76a-43b7-8ac8-b60f18438b27"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest  CLS ?" },
                    { new Guid("237390e4-0f43-4152-8404-d9a2d78cd3c5"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która zasada OOP według ciebie jest najważniejsza ?" },
                    { new Guid("2399d9bb-7dd7-46a0-a2c0-00da632e2fad"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1684), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest pula w IIS ?" },
                    { new Guid("248eafb1-9d58-47a6-abc1-8991d9e83119"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(862), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są testy jednostkowe ? Czy pisałeś ? Z jakich technologii korzystałeś ?" },
                    { new Guid("259a20f9-5b23-4b88-8612-df05a562c146"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest parsowanie ?" },
                    { new Guid("2897a356-927a-4587-b226-12f8cc80889b"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1213), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są kolejne działania przy bindowaniu w REST ?" },
                    { new Guid("29b12ce0-a9c6-4ba1-8b4e-af044eb98b48"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1993), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są profilery ? Jak działają ? Z jakich korzystałeś ?" },
                    { new Guid("2b520972-52e4-4412-a8ce-b9afb45655cd"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1398), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica pomiędzy ref i out ?" },
                    { new Guid("2bf41c4a-3b39-4205-a275-51642cc58557"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DTO" },
                    { new Guid("2c01a949-3167-490c-a7b8-433167acbd55"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1430), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa partial i po co się ją stosuje ?" },
                    { new Guid("2c2b8643-205d-4e9f-8dce-d5399cd68ec7"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blok try/catch/finally ? Co kiedy jest wywoływane ?" },
                    { new Guid("2c5b30fd-5443-42cf-b46a-7d53cb4d04dc"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Observable ?" },
                    { new Guid("2cf2b57b-5910-4c80-a48d-8598e68f7387"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zaimplementować dziedziczenie w bazie danych ?" },
                    { new Guid("2d1b5ab8-9939-443d-9c6b-45244fd91595"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest wielowątkowość ?" },
                    { new Guid("2d6e4801-7a44-439d-a4e8-213a265c425d"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się instrukcja przyrównania == od === ?" },
                    { new Guid("2d9ce677-50d0-4ddc-b454-1eba29d17d56"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak osiągnąć uwierzytelnianie na poziomie Angulara ?" },
                    { new Guid("2e0f83fe-df77-4b9b-9e45-183cefc49b9d"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2227), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaką funkcję wywołujesz jeśli chcesz przefiltrować dane ? Którą z nich : pipe, filter, search itp. ?" },
                    { new Guid("2ea00293-71b5-43aa-815b-d8ff1fe96165"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(986), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka sytuacja może pojawić się, gdy na dwóch branch'ach zmieniany jest kod ?" },
                    { new Guid("305bbc41-cbf7-4955-a341-df243f0c77ef"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz poszczególne operacje systemu kontroli wersji GIT takie jak np. push, rebase" },
                    { new Guid("30e3f070-07b9-47c0-85d8-ec93de2f7ec1"), new Guid("0ed03359-a7dc-4eb4-a616-044557143b43"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(485), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Po co stosowana jest dokumentacja ?" },
                    { new Guid("314013bd-2342-4335-a42e-327dda8653b4"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(528), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Clean Code ? Jakie znasz przykładowe zasady ?" },
                    { new Guid("3186437d-cb26-4145-9125-122ec18632d1"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1299), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się wywołanie synchroniczne od asynchronicznego ?" },
                    { new Guid("318ee0be-683c-4b67-bd25-510577871653"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1064), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś kiedyś z kontenerów Docker'owych ? Jak działają ?" },
                    { new Guid("31d0746e-f87b-46fa-b520-3e476bf95bd6"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Event Bus ? Jakie znasz rodzaje ESB ?" },
                    { new Guid("337e57a8-957e-4b37-aff2-8bc176ba1a56"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1031), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z jakich technologii ORM korzystałeś ? Podaj wady i zalety poszczególnych." },
                    { new Guid("33af1d21-3c3a-417b-8f2b-cc47102f72b2"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1307), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz mechanizmy synchronizacji wątków i z jakich korzystałeś ?" },
                    { new Guid("346f11a2-6557-41f1-aed9-67bb8f77df88"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(612), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Adapter" },
                    { new Guid("34c1687c-499d-4084-a38b-7beccf0e754c"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2177), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co wykona się pierwsze: konstruktor czy metoda OnInit ?" },
                    { new Guid("35c4f6b8-a66a-4cae-b066-0d0bd23b9864"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są Claimsy ? Coś o ich przesyłaniu ?" },
                    { new Guid("3643ad6f-a57d-43c4-b7ce-b807b8d665ac"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1294), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jakich sytuacjach warto zastosować wielowątkowość a w jakich nie ? Z jakimi problemami wiąże się takie podejście ?" },
                    { new Guid("364db4c3-e9be-42ce-a8c8-d35eb273631c"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1003), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest cherry pick ?" },
                    { new Guid("367d07a2-959b-4c78-befa-77cb228bf8ef"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1325), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Mutex ?" },
                    { new Guid("37ff79da-c1b4-49aa-a3b1-74ca22ae32c4"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa BackgroundWorker ?" },
                    { new Guid("3a974d09-e437-4fbb-89d7-b83108a2cceb"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz rodzaje JOINów ?" },
                    { new Guid("3abf7a60-65e0-438c-a495-a167ce27dda8"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz narzędzia do wersjonowania kodu źródłowego ? Czym jest CVS, SVN, GIT, TFVC ?" },
                    { new Guid("3aeca416-5927-484b-81ea-50df195d79c7"), new Guid("4f6935de-3749-4151-a94f-172f9cd2b582"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są 4 poziomy izolacji transakcji ?" },
                    { new Guid("3c155466-b949-4172-a025-1023cc4e9bee"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni WHERE od HAVING ?" },
                    { new Guid("3c2d266c-cf67-4c24-bb13-553f6cd04af5"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się od siebie IEnumerable od IQueryable ?" },
                    { new Guid("3c523b1d-8d9a-4dc1-ae76-19a8e07a6a8e"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym charakteryzują się klasa abstrakcyjna i metoda abstrakcyjna ?" },
                    { new Guid("3d69e36c-bef4-4779-a870-a8baa8edbe66"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(519), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie problemy mogą pojawić się po refaktoryzacji ? Jak im zapobiec ?" },
                    { new Guid("3dd559d2-4c73-46d9-8220-d7354338004a"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2153), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się Promise od Observable ? Co jest wydajniejsze ?" },
                    { new Guid("3dff21db-2712-4340-990e-5d33595727d8"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1068), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Load Balancing ?" },
                    { new Guid("3e44dc90-6eb4-4874-8d32-1760224ebecf"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest extension i w jakim celu się stosuje ?" },
                    { new Guid("3ee573db-553a-4e85-a5cf-a7487d9ffa51"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1558), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co musi posiadać metoda opisana słowem kluczowym async?" },
                    { new Guid("3ff998e0-ec73-44d0-8a0e-0078a6b5b042"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1854), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Stworzyć repozytorium z kontekstem. Przprowadzić operacje pobrania i zapisania danych." },
                    { new Guid("404d2086-b347-471c-8756-8dfbebc3511a"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2144), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się wartość null / undefined / undeclared ?" },
                    { new Guid("40d7bc10-f525-4750-9e9a-111cf5d1ae85"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(443), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Agile ?" },
                    { new Guid("4168f37f-3c8c-4ce1-a045-5653a2f0954d"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(882), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak bada się pokrycie testów jednostkowych i integracyjnych ?" },
                    { new Guid("41a70d7b-f505-4b49-bd1b-ef6cd3f41fcb"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co jeśli w bloku finally pojawi się wyjątek ?" },
                    { new Guid("41b50262-c1ca-4cbd-95c3-d7d3e3521194"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1517), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między typami string i String ?" },
                    { new Guid("4307b34b-e148-47bd-a81a-87e8575df420"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między SOA a mikroserwisami ?" },
                    { new Guid("430f7201-ba3a-424e-92e7-2830885d9701"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to znaczy, że coś jest thread safe ?" },
                    { new Guid("433540d3-b97a-45fa-960d-c2644ae077e7"), new Guid("0ed03359-a7dc-4eb4-a616-044557143b43"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie rodzaje dokumentacji stosuje się dla logiki biznesowej ?" },
                    { new Guid("433903af-4336-49ba-8d7a-67de707a6f3b"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest delegat ?" },
                    { new Guid("442d1cca-29c4-4d44-853e-ead1097167d0"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są middleware ?" },
                    { new Guid("4437d0cc-a0f5-4066-8dee-3477227c579c"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak uzyskać relację wiele do wielu w relacyjnej bazie danych ?" },
                    { new Guid("44d41cc1-27f9-4659-894f-2f0a1896146a"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(731), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła YAGNI ?" },
                    { new Guid("45270e0e-688c-46e9-8edd-b8c3600aa8b4"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(657), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "AOP" },
                    { new Guid("4743c868-0eb1-44e8-809c-6598b5ad55cd"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się metoda Parse od TryParse ? Jak zwracane są typy i błędy ?" },
                    { new Guid("47aaa904-e284-448c-bb55-69d2c1caabd1"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak dostać się do kodu źródłowego biblioteki ? Czy korzystałeś z dekompilatorów ? Jakich ?" },
                    { new Guid("48c31777-9a40-4bd6-88db-d23ae6897ab5"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się var / let / const ?" },
                    { new Guid("48cdeaa0-1fed-4be4-b989-9742465de9cc"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są interfejsy IEnumerable oraz IQueryable ?" },
                    { new Guid("49291983-17d5-48b1-bf74-9d4b56a413d2"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się First od Single ?" },
                    { new Guid("4a72725f-3cae-4085-af29-5afe0b7acb16"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1209), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest bindowanie ?" },
                    { new Guid("4ad36c6a-d74c-4a18-8f6f-c48ad31003f1"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1656), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są różnice między Javą a .NET ? Który język wydaje ci się fajniejszy ?" },
                    { new Guid("4b938a1f-93ec-4abd-bd09-b59f56775bf6"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blokowanie optymistyczne." },
                    { new Guid("4be2401c-dc8c-4aa6-9403-e96013219979"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1756), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa wykonywanie operacji Ling na IEnumerable ? Czy wykonywana jest operacja yield ? Na co to wpływa ?" },
                    { new Guid("53b3c307-8dd3-4b83-825e-a70b1abf4b10"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOLID? Opisz wszystkie zasady. Podaj przykłady." },
                    { new Guid("5403d181-8b89-49aa-8fb8-a7b7096610cd"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1929), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są podejścia do definiowania struktur danych w EF (3 może 5, jak w poniższych pytaniach)?" },
                    { new Guid("55405108-66c3-41d9-a3d4-ce62d5ad845f"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1846), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są zalety i wady generycznych repozytoriów ? Jak można zaradzić wadom ?" },
                    { new Guid("55c2ebfc-285e-448f-ba55-dcce79e56c7d"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1361), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest C# ? Jakie są jego zalety i najważniejsze cechy ?" },
                    { new Guid("55d23b0b-b094-42ec-907a-d2d04bb3458a"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy według ciebie pisanie testów jest ważne ? Jakie mają zalety ?" },
                    { new Guid("560231d8-3a2c-4651-96b4-6c97bc619f8c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(649), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVVM" },
                    { new Guid("5859915d-25b8-45d7-9fc4-cb2b53e0e5aa"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2162), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Promise ?" },
                    { new Guid("592a9c47-a644-42ec-ad67-e83268bf23ae"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się INNER JOIN od OUTER JOIN ?" },
                    { new Guid("59759bf6-4aa5-4f7d-a340-49ea291e0c7b"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda multicatch ?" },
                    { new Guid("5983e297-a046-4232-92b2-2bf3187010ee"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1462), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jakich sytuacjach wykorzystujemy słowo kluczowe using ?" },
                    { new Guid("5bbe788e-bf68-473e-882a-228d2ef71d04"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(532), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy przeprowadzałeś Code Review ? Jak to wyglądało ?" },
                    { new Guid("5c85af2c-f974-47ea-8c10-85be37e0e1e5"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy kiedykolwiek używałeś DDD ? Podaj przykład z życia. Jak korzystałeś z tego w projekcie ?" },
                    { new Guid("5c997fc9-dd5b-4e63-8927-662b072f650e"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1112), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz metody HTTP ? Opisz." },
                    { new Guid("5d020957-824a-47d5-9f12-320b56ff3e63"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można wywołać metodę prywatną za pomocą refleksji ?" },
                    { new Guid("5d071ae9-05ea-402d-ae56-d4c500ed514f"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś kiedyś z narzędzi telemetrycznych ?" },
                    { new Guid("5d378bb2-9947-446c-a8a1-4d5207224041"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest tracking w EF ? Jak działa ?" },
                    { new Guid("5db44531-87bf-4269-bbf4-798fb5b6dbe8"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w twojej pracy wyglądało wykorzystanie Scruma ?" },
                    { new Guid("5de46d67-b3aa-4a68-af74-3c0dc35b42ce"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2005), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się bazy SQL od noSQL ?" },
                    { new Guid("5e24eb92-26ce-4aec-b2ed-fcddc7cf168c"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można zbadać problemy wydajnościowe z EF ?" },
                    { new Guid("5ef462f3-3936-452c-aa5e-f68af6324efc"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest podejście BDD i SpecFlow ?" },
                    { new Guid("5f105ddf-f424-4631-981f-a48742d99fb6"), new Guid("b74d05ea-7d83-4989-b1c5-a28d0a0af4d3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1838), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się DataTables, DataViews, DataSets ?" },
                    { new Guid("5f69914d-bb55-41c3-8b62-471cdd280a99"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła TDA ?" },
                    { new Guid("5f9627b1-2a82-414b-8e07-cbc021219e68"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1697), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Porównaj dwa wybrane kontenery DI np. Autofac, Unity, Ninject." },
                    { new Guid("5fa4d351-2703-4fc1-8dde-738bd51d06d3"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1131), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Podejście wywołania GET w rezultacie wywolania PUT. Dlaczego jest tak ważne ?" },
                    { new Guid("5feb3754-668e-4ff3-a9f6-c46a8a7c1b14"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest domyślna konfiguracja w Entity Framework ?" },
                    { new Guid("604ec319-a460-442d-ba27-7741842dade7"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1805), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co robi atrybut UIHint ?" },
                    { new Guid("60edfda2-69be-4b44-b8e3-305eb10cd615"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zrealizować relacje agregacji i kompozycji w bazie ?" },
                    { new Guid("60fed0c3-a32f-40ea-bd60-a756eeb7c1ea"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(875), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz zasady 3A i GWT." },
                    { new Guid("6114c4ee-4c65-40ad-b13e-4c6c576164b9"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w REST można wpływać na domyślny parser JSONa ?" },
                    { new Guid("61aaa70d-029e-4594-95bc-add8c699d9a2"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak dodać sprawdzenie do kolumny np. wstawiana wartość ma być mniejsza od 1000 (check albo trigger)?" },
                    { new Guid("633e3c2e-765a-4d1f-8ce7-b1a8fba9bb59"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(995), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między fetch a pull ?" },
                    { new Guid("648a30b0-97c2-418b-8e3e-714134c8ec1d"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Scrum ?" },
                    { new Guid("6522db72-fd94-4f5b-bb41-186c80ae9dcb"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2116), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można optymalizować DOM w przypadkach responsywnych ?" },
                    { new Guid("6566775b-33e5-4954-a2c0-54827016fbf6"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2089), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy indeks nie zadziała ?" },
                    { new Guid("672e19ba-72b0-4611-b885-4741b52e9519"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1688), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki jest cykl życia obiektów zarejestrowanych jako singleton, scoped i transient ?" },
                    { new Guid("679fa0c1-0f21-47d8-a462-2a9ada12ab67"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można wywoływać extension method na obiektach null ?" },
                    { new Guid("68e71812-8302-4c94-9cc2-c375be072ba5"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2254), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Media Query ?" },
                    { new Guid("6b409bc3-da6a-46f4-b9b1-2301fb6bd102"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest eager loading ?" },
                    { new Guid("6bbcbdfc-1867-4f9b-941e-c6788c1282fa"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy różni się argument od parametru ?" },
                    { new Guid("6d12fd4b-6a65-4e24-b798-0197a5451616"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień wszystkie możliwości zapisu document.ready ." },
                    { new Guid("6d8269e2-9de1-4b69-8c1e-03fd9b87cf5c"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1615), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy za pomocą refleksji można dodać nowy typ ?" },
                    { new Guid("6dc1357e-574b-440d-8537-3e552dc8c1bd"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1729), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy GC dotyka typów value podczas czyszczenia ?" },
                    { new Guid("6e59b520-627d-44c3-8dc6-280e3709779a"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1092), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest HTTP ?" },
                    { new Guid("6ed835ce-110e-4a6a-8409-73277d922312"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień poszczególne kroki CD ? Jak wyglądał Pipeline ?" },
                    { new Guid("6eeb1318-aed6-4b2c-a927-a8cef9f98c6c"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2080), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zbudowane są poszczególne indeksy ?" },
                    { new Guid("704a6a7f-12ba-4929-9e0c-dc68d4ceb994"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są Scrum'owe rytuały ?" },
                    { new Guid("7068302e-3499-477b-8515-f1f7b1f43533"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Które z podanych to metody HTTP (get, post, put, patch, insert, update, input, delete) ?" },
                    { new Guid("708520ca-03a9-4844-bb58-90031257b7e4"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Ile języków funkcjonuje na platformie .Net ?" },
                    { new Guid("729af3ce-4fc0-4260-9426-5c6c023f3eb0"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie usługi dostarcza AzureS i Azure DevOps ?" },
                    { new Guid("7327efc3-3826-42d7-927c-ce125c97abbc"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(999), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między rebase a merge ?" },
                    { new Guid("74428fd3-1f53-43b8-9bb2-a4c43d50a783"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1185), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy REST realizowany jest tylko z pomocą protokołu HTTP ?" },
                    { new Guid("749e5713-9d13-497b-abfd-341cd57aeb74"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest deadlock ?" },
                    { new Guid("764acd9c-7031-4bfa-92d6-6ccaf9cf37cd"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1218), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie zasady spełnia dobrze zaprojektowane URI ?" },
                    { new Guid("77068fd9-d70b-48c3-bebd-53b0e20eb269"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa abstrakcyjna ?" },
                    { new Guid("79040263-0780-4461-b259-00176b85d529"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1792), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak ustawić CultureInfo dla głównego wątku ?" },
                    { new Guid("79f96530-c8ff-48ec-9be4-1db31e5b651a"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2238), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są zapytania o media CSS i do czego się je wykorzystuje ?" },
                    { new Guid("7a9e8fec-9ade-46e4-8b59-e4ee3651f8cb"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1205), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda flow zapytanie-odpowiedź dla REST ? Kiedy i jak odbywa się autoryzacja ? Jak działa parsowanie ? Jak można wpływać na domyślny parser jsona ?" },
                    { new Guid("7b1e5364-ac8a-4732-9d12-9d7aef9650ef"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można zaimplementować skalowalną architekturę ? Co jest kluczowe w API ?" },
                    { new Guid("7d1308da-891a-4920-a83b-44d38ccfced7"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda obsługa zapytania i odpowiedzi w przypadku REST ? Opisz poszczególne operacje." },
                    { new Guid("7db47fd9-c845-478a-a2e6-2ad1d4e942d2"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się lock od monitora ?" },
                    { new Guid("7f3c2198-ff46-46a7-886e-5ed0828951d8"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między JS a TS ?" },
                    { new Guid("7faafd3a-6415-4320-8d80-ddb07399268b"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak na poziomie infrastruktury poprawić działanie wolno działającego serwisu ?" },
                    { new Guid("802a3d0e-5da9-48c6-9ed5-3bdb50101410"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak implementuje się HAVING w EF/LINQ ?" },
                    { new Guid("80382859-1c77-4350-9c5f-511fbb17d635"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1801), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co się stanie, gdy jeden routing naprowadza na dwie różne akcje ?" },
                    { new Guid("805fae0f-9679-43ae-b747-2070c3a11130"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1381), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między var a dynamic ?" },
                    { new Guid("808e2405-cb14-45b3-9114-1bf85559fc32"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która konfiguracja jest domyślna eager czy lazy ?" },
                    { new Guid("80f388c3-5146-4b9f-a160-da7e7ccb867a"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(886), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest podejście DDD ?" },
                    { new Guid("82a09ab2-9679-4f7a-b244-c06db43320b2"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Obserwator" },
                    { new Guid("82a22f5e-56d5-4351-b2a2-19ee5b423bfe"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak merguje się branche ?" },
                    { new Guid("83acdfbe-2540-4447-8625-76e473854b2b"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1974), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy DbContext jest thread safe ?" },
                    { new Guid("841ae5d0-b8a0-4057-b6f3-d35bf341f1bd"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Której generacji językiem jest C# ?" },
                    { new Guid("843b379e-b44c-4a09-b2de-b72577a0b332"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Injection ? Jak to wygląda niskopoziomowo w C# ?" },
                    { new Guid("845eef3f-0df2-42dd-ae92-808d741f14ba"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się procedury SQL od funkcji ?" },
                    { new Guid("84882f44-c503-4191-9829-b781e2d47a8b"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można przechować zmienną w Angularze ?" },
                    { new Guid("84f7cb4c-ba49-4f00-b03e-608acfd2f2c0"), new Guid("0ed03359-a7dc-4eb4-a616-044557143b43"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Preferujesz dokumentowanie bezpośrednio w kodzie czy obok ?" },
                    { new Guid("85a70afe-e611-4688-a887-a22dba7d4aaa"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(903), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się Entity od Value Object ?" },
                    { new Guid("86c12a51-8449-4f4d-a609-d5dcddbdbc6c"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie ryzyko związane jest z lazy loadingiem ?" },
                    { new Guid("86f734c0-c4d4-4075-8926-9622ad9cf2d3"), new Guid("93f38474-2faa-4cc6-962e-1a91bd41ed1b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz języki SQL ? Z jakimi rozwiązaniami miałeś do czynienia ?" },
                    { new Guid("876d8ece-1e78-47f0-afe0-542b0a183dc4"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są generacje w GC ?" },
                    { new Guid("8932cf5c-9f9b-4fba-876e-053ec97aa163"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Przedstaw ideę dziedziczenia na przykładzie z życia." },
                    { new Guid("89ab9f11-f02d-41ab-9cb5-5d06c6a11af7"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1692), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz realizacje kontenerów DI w .NET ?" },
                    { new Guid("8be22394-fcf2-41e7-9bc5-43bb067b4f57"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1660), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest CLI ?" },
                    { new Guid("8c10a44f-cf06-4d99-ad84-1759dbcab488"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2112), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest AJAX ? Jakie technologie wchodzą w jego skład ?" },
                    { new Guid("8c1f7407-8d8f-4cc2-a875-ba84eb73092b"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(978), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest branch ?" },
                    { new Guid("8c6c398f-9183-404a-b05e-651e99da7739"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Auth Guard  ? Jak działa ? Z czego się składa ?" },
                    { new Guid("8ca8e34f-1ef9-47d8-ad78-4d565c0097c6"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak realizuje się wersjonowanie w EF ?" },
                    { new Guid("8da21848-8e63-49c7-b323-687f0ee6e7f4"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1562), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy warto korzystać z async-ów ?" },
                    { new Guid("8daa35dc-c849-4d10-b233-c34eb9f20443"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj rozszerzoną wersję klasy implementującej IDisposable." },
                    { new Guid("8de81b72-505a-428f-95b2-9b62f81d1ac6"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2104), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest bubbling eventów ?" },
                    { new Guid("8e95f636-5817-42cc-8207-eb2e96edf32c"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się code-first od database-first ? Które z rozwiązań wykorzystywałeś ? Które preferujesz i dlaczego ?" },
                    { new Guid("8ff5c4bb-5276-4f80-8598-b79e5d0d6d68"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(774), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz rodzaje testów ?" },
                    { new Guid("90782a9e-4cd4-4433-8f99-08cfe4601022"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1481), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest atrybut ?" },
                    { new Guid("91e12f35-8bb0-47d9-b34a-3e1ef08ee66e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(664), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DAO" },
                    { new Guid("945afb5d-36a1-4c06-bf0a-dd652d7d50a4"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1018), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są trzy sposoby na realizację dziedziczenia encji ?" },
                    { new Guid("9572285c-8f8c-4ac4-a682-04615dbc6c44"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak globalnie dla usług ustawić mechanizm pobierania odpowiedniego zasobu języka, czyli .resx w danym języku ?" },
                    { new Guid("96f7297f-e2de-487b-9102-9296db6e6fcd"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni POST / GET / PUT ? Jak przekazywane są atrybuty do tych metod ?" },
                    { new Guid("9794c693-efb6-4b38-947b-40f114589b24"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(511), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest refaktoryzacja ?" },
                    { new Guid("9862edc8-f021-4660-862b-1fa713441504"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(673), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Repository" },
                    { new Guid("9a72de24-b563-4398-bd5d-dd951d82921f"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2056), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest sekwencja np. w PL/SQL ?" },
                    { new Guid("9b29f16b-867d-4443-bb52-1cc824ff0ab4"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1153), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa parsowanie ?" },
                    { new Guid("9bdade91-f3c9-4e63-9974-efa30dcaf09c"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz rodzaje indeksów ?" },
                    { new Guid("9bed6341-8ce0-4aee-8169-1950f6c36fe6"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z jakimi problemami możemy spotkać się w przypadku RESTa ? Czy to zastosowanie nadaje się np. dla banków ?" },
                    { new Guid("9d28c57f-9ff0-4dfc-911a-7f75b0113067"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1103), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zasymulować stanowość HTTP ?" },
                    { new Guid("9e0caaad-5f3f-4362-bc8b-2bb4ac5c987d"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2067), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są ideksy i jak działają ?" },
                    { new Guid("9e117a59-6945-428b-b65d-87c909bad6b8"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1761), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są filtry w WebAPI i MVC." },
                    { new Guid("9e4d8fc8-acdc-4c33-8792-580f5cdf411c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(686), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Retry" },
                    { new Guid("9f6b16f1-e118-46f4-8ab2-d90ba948b30a"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się testy jednostkowe od integracyjnych ?" },
                    { new Guid("a027b933-e0af-464b-b109-d7e27f420d2d"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy GC wywołuje metodę Dispose ? A może Finalize() ? Jaka jest różnica między Disposable a Finalize." },
                    { new Guid("a085e3d4-528e-4158-8366-e7946125199f"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Continous Delivery / Deployment ?" },
                    { new Guid("a0a4b7e6-e325-41bd-afeb-99531433d133"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy w REST wywoływana jest autoryzacja ?" },
                    { new Guid("a32505af-b2ab-4230-b3d8-55f780602079"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie mamy typy zmiennych w C# ? Jak są przechowywane w pamięci ?" },
                    { new Guid("a3344607-44c5-4122-a7d6-702b07474410"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działają serwisy w Angularze ?" },
                    { new Guid("a352201a-f3a0-4275-92ea-00d4f846cda0"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się pole const od static readonly ?" },
                    { new Guid("a431fa67-7545-4e1e-9832-04c0bd352d23"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Circuit Braker" },
                    { new Guid("a5b8e0ed-9baf-419f-bf3a-0d9dbe733fbf"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Pytanie typu, co zwróci wyrażenie `var zmienna = new Abc<x, y, z>((a, b) => a == b)` jeśli nieznane typy to object" },
                    { new Guid("a6e8bec6-2458-4850-ab3b-1542f87a9166"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak zastosujesz EF Projects ?" },
                    { new Guid("a7abcdf9-ae26-4f78-bb5d-49be46ed05b2"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2038), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są i czym się różnią UNION od UNION ALL ?" },
                    { new Guid("a838dca0-963a-4840-8628-6d3255dc4560"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie role są w Scrum'ie ?" },
                    { new Guid("a92735e2-b549-4fcd-984a-deb70bfd7fcd"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie w mechanizmie wywoływana jest metoda Dispose() ?" },
                    { new Guid("a9e794c7-03f6-4551-a763-ec27b6d864e0"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1647), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy warto wykorzystać technologie .Net Core ?" },
                    { new Guid("aa230a49-deae-46f3-ad5a-40a86918327a"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest kolejność wywoływania bloków catch w obsłudze wyjątków ? Zwrócić uwagę na dziedziczenie wyjątków." },
                    { new Guid("aacd0c82-83ea-45e8-93f6-4fe0219c42bf"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mediator" },
                    { new Guid("ac4deeac-6e1d-4ab5-bba2-56f4d1964910"), new Guid("638331a1-9858-4f2c-86a3-5f27d757f2fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(523), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jaki sposób dbasz o jakość kodu ? Jakie znasz standardy i drogi do uzyskania wysokiej jakości kodu ?" },
                    { new Guid("aeceabee-fe28-4175-99c4-d1f5c830e498"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1673), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest JIT ? Kiedy się wykonuje ?" },
                    { new Guid("afd35c8f-7025-4d25-b43a-07eba2f7cdf4"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1543), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica w wywołaniu \"throw e\" od \"throw\" ? Który standard jest lepszy ?" },
                    { new Guid("b03017c2-914a-419a-bc4a-02c305de02de"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Podaj różnice między EntityFramework i NHibernate ?" },
                    { new Guid("b05cd680-2977-43b6-bc81-e6eeb0c605fe"), new Guid("a5f70f89-5b51-408f-b336-90ff049a1b59"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blokowanie pesymistyczne." },
                    { new Guid("b1a1bed2-0a53-42fb-bf8b-a933b288f35d"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1716), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można manualnie wywołać GC ? Jak ? Jeśli można wywołać manualnie GC to czy czyszczenie wykona się od razu ?" },
                    { new Guid("b2ab1127-66f8-4cd9-9bbc-34af57aab8c3"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1135), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień kody błędów HTTP ew. grupy kodów  ?" },
                    { new Guid("b3a42cee-187c-48e2-a8ab-77b07b27d342"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1591), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się typ Thread od Task ?" },
                    { new Guid("b61ac910-17ee-4e37-8b4f-c674b3ef40f9"), new Guid("cd173f96-0533-4be8-bdfc-d58cdb9579d0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2166), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Ilu wątkowy jest JS ?" },
                    { new Guid("b6a7a0ee-704f-4914-9b50-2e2190db9279"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(971), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni GIT od TFVC ?" },
                    { new Guid("b7e2da22-8515-4625-92a1-385dedb47dd0"), new Guid("2a736d5a-1c48-4515-bdcb-f93bbad77db3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa GC ? Kiedy wywoływany jest GC ?" },
                    { new Guid("b8f4ed3b-9698-4e7d-9e75-d2f54bca041a"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa oAuth 2 ?" },
                    { new Guid("b9a6d2e8-3327-4166-b350-70f8b8f21364"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest REST ?" },
                    { new Guid("ba5f856d-e26d-4924-866b-636ede4cc52c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVP" },
                    { new Guid("bc1100bf-8b65-43d5-a829-5c8a9a32768a"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2223), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień i opisz modyfikatory w serwisach Angularowych np. Inject ?" },
                    { new Guid("bca42b84-ca8b-49df-8d09-d80d6aa51ac0"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(502), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest deklaracja vs definicja vs inicjalizacja ?" },
                    { new Guid("bcb13382-d95c-4a7f-b2ba-3f0f2260ea21"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1157), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOA ?" },
                    { new Guid("bcdaa429-14af-438d-afae-0522505c635f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Proxy" },
                    { new Guid("bd9ff497-b192-45aa-86b4-7d636d4bada9"), new Guid("4f6935de-3749-4151-a94f-172f9cd2b582"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1986), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda full scan i index scan tabeli ?" },
                    { new Guid("bdaa7603-c9ca-4fda-9cca-c725777f8f9c"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1088), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoT ?" },
                    { new Guid("be3daf71-bb8e-4ffc-a7e1-8a24279a471b"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest CSS preprocessor ? Korzystałeś kiedyś z tego ?" },
                    { new Guid("bf3155c1-4be1-4bf9-987f-95422c1d8f9d"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2214), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa routing w Angularze ?" },
                    { new Guid("c0b063ef-e246-488f-913c-d0bfcf295c6f"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2076), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się indeks klastrowy od nieklastrowego ?" },
                    { new Guid("c0b4e543-6b1b-4f30-8f43-90e1d1b349b6"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1454), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni rzutowanie bezpośrednie od wykorzystania \"as\" ?" },
                    { new Guid("c1b0ce7f-08d2-447d-9caf-8e31ed0fc9ca"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(702), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Inversion i jak się ma do Dependency Injection ?" },
                    { new Guid("c2d9a9ba-7b8e-417d-b874-6020e781de2b"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2250), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest flexbox ?" },
                    { new Guid("c2f86d95-9446-4b8a-8404-79824a3dd17b"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy HTTP jest stanowy ?" },
                    { new Guid("c38bdcc5-0ca9-4441-8ee7-a04d98f4f828"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(706), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoC ? W jaki sposób jest powiązane z DI ?" },
                    { new Guid("c3f27c2b-0ee9-4b73-b67b-962e39cc7c69"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różnią się szyfrowania symetryczne od asymetrycznych ? Podaj przykłady algorytmów i protokołów, które są na nich oparte." },
                    { new Guid("c48baecb-0d7c-422c-af56-85c8a4c6cc13"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Pytania o to, która definicja metody jest poprawna." },
                    { new Guid("c4ef9e35-865d-4718-80e1-feb624f446e5"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1737), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między listą a hashsetem ?" },
                    { new Guid("c5a4f435-6c1f-4f17-8ec2-9ffdf788ced1"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1628), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest .Net Core ?" },
                    { new Guid("c6fb0c15-8c4e-4545-97fd-f75ad6adef00"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co zawiera ramka HTTP ?" },
                    { new Guid("c9de1474-050c-425d-935c-2b7576f6bb75"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1441), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy jeśli zmienisz struct przesyłany w parametrze metody to zmiana będzie widoczna poza tą metodą ? Jak na to wpłynąć ?" },
                    { new Guid("ca680cf2-2712-4af2-aeb3-ab04785cd935"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1467), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można zastąpić IDisposable poprzez try/catch/finally ? Dlaczego się z tego w takim razie korzysta?" },
                    { new Guid("cbbffbb9-1e36-4e1f-9d76-f1bcb3e412a1"), new Guid("caa6e3b0-8e5a-4bd2-b36d-3114201e7be1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1733), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień i opisz kolekcje występujące w technologii .Net." },
                    { new Guid("cbf845e1-954e-4d28-b3a6-062eecf4eef3"), new Guid("b4b43c3d-7373-4799-89ff-f79f6c213f98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się setValue od patchValue ?" },
                    { new Guid("cc3e1eca-872a-422a-ac07-f32ed8a23a18"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVC" },
                    { new Guid("cc426c82-c9d0-408e-94fa-88cf3e79b716"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Continous Integration ?" },
                    { new Guid("ccc74988-fc31-4a31-9034-d6e5c72bb873"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest complex type w EF?" },
                    { new Guid("ccede387-041c-4eac-8e05-0954e282f22a"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co posiada typowy kontroler MVC ? Jakie można nadać atrybuty? Jakie posiada akcje i co one zwracają ?" },
                    { new Guid("cd5c8b37-ad27-40a3-856e-e42bf631b2df"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1181), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między REST a SOAP ?" },
                    { new Guid("cdd715ad-d51e-4cc1-8b4c-edb387b24459"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2108), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest DOM ?" },
                    { new Guid("ce19594d-c92a-4fac-b9e0-8bbe28ee0fb3"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2234), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są trzy metody dodania CCS-a do strony ? Opisz wady i zalety każdej z nich." },
                    { new Guid("cece41e9-051b-4a60-adb8-d6eb65278f0e"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1316), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Monitor ?" },
                    { new Guid("cf0ce8b2-7fe9-4251-a2be-33d60ac3556e"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest autoryzacja ?" },
                    { new Guid("d018f074-580b-448e-9bec-345abfdd57fd"), new Guid("77540274-e44d-47a5-94d3-86ccdacedb0c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki jest porządek wywoływania kolejnych bloków catch ? Jak to wygląda przy wyjątkach dziedziczonych ?" },
                    { new Guid("d060c85f-2193-4f24-b2d1-f5b5d7180741"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1413), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest interfejs ?" },
                    { new Guid("d0768130-5b2e-44f5-8435-93bc3b03a3a6"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie wykorzystywany jest GetHashCode ? Czy w HashMapie dodanie dwóch różnych elementów z tym samym hashCodem nadpisze je ?" },
                    { new Guid("d0fd5fb0-c212-4a8f-9cce-b5819af3f2bc"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1809), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co robi atrybut FromUri ?" },
                    { new Guid("d1c585fd-716f-4aa4-ac03-39b342183cc5"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1969), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak można podać wartości domyślne dla metod ?" },
                    { new Guid("d3d01fca-588d-4dbd-a382-1e3107ecb8b2"), new Guid("273643d2-b005-4a1f-83ff-9ce823c4b418"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda state management w .NET ?" },
                    { new Guid("d4ec3e69-d853-487b-94b1-9a42ace64cba"), new Guid("8c0ad679-b40d-4db3-8c2b-ef59204005ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy za pomocą refleksji można dodać property do istniejącego typu ?" },
                    { new Guid("d6397ee7-e58f-4134-9229-13b02dd31864"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadanie, w którym robiony jest Replace() na stringu ale nigdzie nie jest przypisywany rezultat i co zwróci zmienna ? Łatwo się złapać." },
                    { new Guid("d64ed4e9-4298-4339-a996-f470802a034b"), new Guid("209537e5-fdc0-4a4c-8c4b-851021855c53"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa routing w .Net MVC ?" },
                    { new Guid("d6e9f2f7-a200-45bd-a35f-63be206311c9"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(379), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz narzędzia pracy zespołowej ? Korzystałeś z Jiry, Confluence ?" },
                    { new Guid("d79f488e-9317-47ea-ac22-14db90026d99"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj singleton z bezpiecznym dostępem wielowątkowym (pamiętać o synchronizacji / double checking pattern / ew. SingletonHolder z bezpiecznym dostępem bez konieczności synchronizacji)." },
                    { new Guid("d84fb9bc-c151-40b4-a335-da8ba80afe47"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są plusy stosowania DI i IoC? W jaki sposób stosowanie DI / IoC wspomaga testowanie jednostkowe?" },
                    { new Guid("d88fd90b-f7cc-4a59-8a0e-bef4952d5196"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2018), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakiego typu znakowego użyłbyś do tekstu z różnymi międzynarodowymi znakami ?" },
                    { new Guid("d8fd4550-f931-4507-b50b-9dd7393285bb"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1222), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest autentykacja ?" },
                    { new Guid("da9b78b9-6fc8-4350-9491-16adcde686ac"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1913), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest problem n+1 i czy dotyczy to Lazy Loadingu ?" },
                    { new Guid("de2b1dc1-8722-4381-9ba9-f721654438f7"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1861), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są rodzaje konfiguracji w Entity Framework ?" },
                    { new Guid("de2dc78a-9798-4a2f-863b-55d39519ddb7"), new Guid("0795a628-69e2-411b-bbc9-eb805f9fe72d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 1, 0, 0, 0)), "https://www.upwork.com/hire/css-developers/interview-questions/", new Guid("00000000-0000-0000-0000-000000000000"), "Zbiór Upwork" },
                    { new Guid("de6f0010-8295-41f1-ad54-dda974b6e6d3"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(962), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy tworzyłeś kiedyś diagramy UML np. przepływów, use cases itp ?" },
                    { new Guid("dfab3ce2-a84e-4255-accf-aa63cd524a77"), new Guid("e28039da-8c48-4fcf-ab57-09196b612864"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1680), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IIS ?" },
                    { new Guid("dfd6fcd8-ed2f-4ed8-bcee-09a1d3244365"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Metoda fabryki" },
                    { new Guid("dfda3900-88cc-4aac-831d-ff811b80eb0b"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są klucz główny i klucz obcy ?" },
                    { new Guid("e03232d0-f9bb-4e03-98e1-6e46e706f608"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy tworzyłeś kiedyś customowy atrybut ? Jaki?" },
                    { new Guid("e08ee273-4656-4dd8-94b3-a59b55e6d52f"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOAP ?" },
                    { new Guid("e1cd1a86-a539-433c-b7e4-5bb06d7cbb89"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda definiowanie tabel w .edmx ?" },
                    { new Guid("e26f06bf-09b0-419e-9f2e-47b03232715e"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest transakcja ?" },
                    { new Guid("e3ab2ab5-35d6-4f7c-9f35-0ac0374b82ac"), new Guid("e86eb402-5cb4-4428-b77c-eddc031ca81f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(866), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są testy integracyjne ? Czy pisałeś ? Z jakich technologii korzystałeś ?" },
                    { new Guid("e67a4785-d489-4bf6-ae52-3bffd974e5d3"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(768), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." },
                    { new Guid("e760f4b0-1146-4be5-b2b2-f5a441d837b4"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1956), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mamy kawałek kodu. Kolekcja \"lista\" zawiera duplikaty. Co wyświetli operacja ?" },
                    { new Guid("e763f1a6-d69a-4c9b-8c18-c2f35c931d07"), new Guid("7dad0a17-08f5-4396-a4dc-784c427f9320"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest CLR ?" },
                    { new Guid("e78a7da4-6035-448b-be67-7cf16a8a419d"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co nowego wprowadza technologia .Net Core w porównaniu do .Net Framework ?" },
                    { new Guid("e80fc973-5c5a-4ea5-9fe3-d6e6c7141755"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1769), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Napisz przykładowy kontroler WebAPI." },
                    { new Guid("e815d722-c3de-4e40-9ccd-2ab01ba08133"), new Guid("97208387-3936-4b0a-bfc6-cf8fdaa9b772"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2085), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co przyspieszają indeksy a co spowalniają ?" },
                    { new Guid("e83ae900-ec35-423c-9024-86e69cf8d54d"), new Guid("24d19d8a-a8c4-4fa1-96b1-e386d33cbf98"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(899), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda analiza w standardzie DDD i jak ma się ona do kodu ?" },
                    { new Guid("ea19c238-d031-42eb-91ac-d8e60ab5875b"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak osiąga się responsywność w bootstrapie ?" },
                    { new Guid("eb5d0a8b-86e3-42cd-a3b7-921f85a94e51"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak przekazywany jest token ? Jak to związane jest z zawartością ramki HTTP ?" },
                    { new Guid("eba6a724-e090-49e5-bb88-7d715e9061f8"), new Guid("4f6935de-3749-4151-a94f-172f9cd2b582"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest zasada ACID ?" },
                    { new Guid("ebd2cc8a-3eec-4148-8ed7-c481ae486f86"), new Guid("e04edc71-f477-4ca6-9482-2a019bd8d5e9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa pipeline wywołania dla REST?" },
                    { new Guid("ebdf6b15-8b4d-45b8-bd97-13ee13e04e91"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Builder" },
                    { new Guid("ec443e21-a941-4e03-9a73-eacea2ad874e"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest .Net Standard ?" },
                    { new Guid("ecac88dd-346f-4a2e-a2e2-b0c814141ebf"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(632), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy StringBuilder jest realizacją wzorca Builder ?" },
                    { new Guid("ee74a619-3a1f-48b8-b3f3-2218268eccf4"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się proces od wątku ? Jak to się je z dostępem do zasobów ?" },
                    { new Guid("eee23c93-9731-40e3-ab0a-10ddc6b9da36"), new Guid("fc2f8cc9-1024-42eb-a1c7-df1270090675"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co wyświetli for(var i in lista) console.log() (zwrócić uwagę na znaki nowej linii) ?" },
                    { new Guid("ef0f7f7d-3fa8-4802-9d4b-9c793cffb2f2"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie i po co stosuje się słowo kluczowe sealed ?" },
                    { new Guid("efc94f91-497a-4448-acc8-2ecb61673440"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jaki sposób można rzutować wartości na inne typy ?" },
                    { new Guid("f00e7a91-f278-4d44-83d2-a9aae6aeff92"), new Guid("12300f34-a179-429c-859b-aa587001a67c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(2014), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz instrukcję Having." },
                    { new Guid("f073ef07-995f-482b-be84-c9d97a515867"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest mutual TLS ?" },
                    { new Guid("f0b61803-6518-4005-be9e-0c7c6d185672"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z czym związane są słowa async i await ?" },
                    { new Guid("f185c979-3eb5-4729-87e4-926a927ad0ab"), new Guid("36defef5-c34e-40be-b461-d217bb255566"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1624), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest .Net Framework ?" },
                    { new Guid("f2164efa-4534-40d5-82b7-cf9a1140688f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różną się wzorce fabryki abstrakcyjnej i metody fabryki ?" },
                    { new Guid("f24e596f-97de-4afa-b809-c003479ee208"), new Guid("f7e9ae2a-33e6-486c-b00c-7fde72c4f2ef"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1007), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są submoduły w GIT ?" },
                    { new Guid("f25791fb-0fd7-4f4d-a276-b36478a2afad"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(598), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dekorator" },
                    { new Guid("f309aa27-f32d-4f28-863c-c2cb11a868fe"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1498), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki typ zwraca GetHashCode() ? Czy jest możliwe, że zwróci tę samą wartość dla dwóch różnych obiektów ?" },
                    { new Guid("f37b3915-930d-4be3-bcd2-fe7cec2767d6"), new Guid("12d9bda6-2b20-4876-ab72-51498913f01a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1077), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Chmura ? Jakie znasz rozwiązania ? Czy masz z tym doświadczenie ?" },
                    { new Guid("f398662b-ec56-45f4-bc2f-841eb14d59fe"), new Guid("d3157372-95f8-4b34-a836-2538a87162c3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1765), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest WebAPI ?" },
                    { new Guid("f422c044-71d8-42cd-8563-7bd4e620cefa"), new Guid("23441e50-8dbc-4d2c-90a2-d623104fb37b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień dwa wielowątkowe typy w .NET." },
                    { new Guid("f42a32c9-fdc3-484e-97e5-57e72194239a"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest token ? Co zawiera i na co pozwala ?" },
                    { new Guid("f470bd3a-c5ea-4c0f-893e-78e3140bc505"), new Guid("a483b653-422d-41bb-a2ba-c8793bf1cd6d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1825), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest WCF ?" },
                    { new Guid("f62f1885-a2a1-4c54-9a00-a5d4e91e9160"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega wzorzec CQS i CQRS (command, action)?" },
                    { new Guid("f6f9b4aa-3c74-4506-86bc-498d35bf65f6"), new Guid("7cab840f-a28a-4681-a294-6c13d4441221"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mają wywołanie w pętli obiektu uruchamiającego lazy loading, jak to zmienić aby było wykonane pojedynczym zapytaniem ?" },
                    { new Guid("f83673da-30eb-4fa7-9c02-b72568543bd0"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Facade pattern (bardzo ważny wzorzec)" },
                    { new Guid("f857a862-3ca2-41b9-86b9-7145afc379d7"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1353), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy każdy wątek ma swój oddzielny stos ? Ile stosów mamy w aplikacji ?" },
                    { new Guid("f8627a70-7388-4103-b799-835bd195638b"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła SoC ?" },
                    { new Guid("f9b90328-6a78-4d8d-8e56-c8ed94e0d944"), new Guid("08c037f9-c4e9-48c4-a4c5-fb8e628aa792"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak podchodzisz do rozpoczęcia historyjek analitycznych ?" },
                    { new Guid("fa8d8cd4-48dd-4444-b5fe-36cd797c2c7d"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest OOP ? Jakie są 4 główne zasady programowania obiektowego ?" },
                    { new Guid("fb0298f8-c191-4070-bfbf-a5888525f050"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1349), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jeśli uderzasz requestami do serwisu bankowego i on przestanie działać - jak temu zapobiec ?" },
                    { new Guid("fb66d499-81f2-4c55-97d7-adbc0829d718"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(727), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła DRY ?" },
                    { new Guid("fe177917-13ee-4288-9f5e-0d4f75ec5362"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Unit Of Work" },
                    { new Guid("fe21ffaa-704c-4087-ad80-f58afbb204d0"), new Guid("5bc813e3-f490-4f6e-98a9-e378c07a0d74"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy wykorzystywałeś CI / CD w projekcie ? Jakich technologii użyłeś ?" },
                    { new Guid("fe8783ac-8a92-4853-9e16-96e1150ea482"), new Guid("995f25e7-5cb8-4b3e-a6bb-cd125857a332"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie rodzaje autoryzacji znasz ? Jakie implementowałeś ?" },
                    { new Guid("fef6407a-0c06-4003-8273-30527904b537"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 23, 16, 55, 29, 393, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła KISS ?" }
                });
        }
    }
}
