using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_SCB.Models
{
    public class PopulationContext : DbContext
    {
        public DbSet<Multiplicity> Municipalities { get; set; }
        public DbSet<MultiplicityName> MunicipalityNames { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<BirthRate> Rates { get; set; }

        public PopulationContext() : base("SCBdatabase")
        {
            Database.SetInitializer<PopulationContext>(new PopulationContextInitializer());
        }

        public class PopulationContextInitializer : CreateDatabaseIfNotExists<PopulationContext>
//CreateDatabaseIfNotExists<PopulationContext>
        {
            protected override void Seed(PopulationContext context)
            {
                addData(context);
            }

            private void addData(PopulationContext context)
            {
                var municipalityNames = new List<MultiplicityName>();

                municipalityNames.Add(new MultiplicityName(0114, "Upplands Väsby"));
                municipalityNames.Add(new MultiplicityName(0115, "Vallentuna"));
                municipalityNames.Add(new MultiplicityName(0117, "Österåker"));
                municipalityNames.Add(new MultiplicityName(0120, "Värmdö"));
                municipalityNames.Add(new MultiplicityName(0123, "Järfälla"));
                municipalityNames.Add(new MultiplicityName(0125, "Ekerö"));
                municipalityNames.Add(new MultiplicityName(0126, "Huddinge"));
                municipalityNames.Add(new MultiplicityName(0127, "Botkyrka"));
                municipalityNames.Add(new MultiplicityName(0128, "Salem"));
                municipalityNames.Add(new MultiplicityName(0136, "Haninge"));
                municipalityNames.Add(new MultiplicityName(0138, "Tyresö"));
                municipalityNames.Add(new MultiplicityName(0139, "Upplands - Bro"));
                municipalityNames.Add(new MultiplicityName(0140, "Nykvarn"));
                municipalityNames.Add(new MultiplicityName(0160, "Täby"));
                municipalityNames.Add(new MultiplicityName(0162, "Danderyd"));
                municipalityNames.Add(new MultiplicityName(0163, "Sollentuna"));
                municipalityNames.Add(new MultiplicityName(0180, "Stockholm"));
                municipalityNames.Add(new MultiplicityName(0181, "Södertälje"));
                municipalityNames.Add(new MultiplicityName(0182, "Nacka"));
                municipalityNames.Add(new MultiplicityName(0183, "Sundbyberg"));
                municipalityNames.Add(new MultiplicityName(0184, "Solna"));
                municipalityNames.Add(new MultiplicityName(0186, "Lidingö"));
                municipalityNames.Add(new MultiplicityName(0187, "Vaxholm"));
                municipalityNames.Add(new MultiplicityName(0188, "Norrtälje"));
                municipalityNames.Add(new MultiplicityName(0191, "Sigtuna"));
                municipalityNames.Add(new MultiplicityName(0192, "Nynäshamn"));
                municipalityNames.Add(new MultiplicityName(0305, "Håbo"));
                municipalityNames.Add(new MultiplicityName(0319, "Älvkarleby"));
                municipalityNames.Add(new MultiplicityName(0330, "Knivsta"));
                municipalityNames.Add(new MultiplicityName(0331, "Heby"));
                municipalityNames.Add(new MultiplicityName(0360, "Tierp"));
                municipalityNames.Add(new MultiplicityName(0380, "Uppsala"));
                municipalityNames.Add(new MultiplicityName(0381, "Enköping"));
                municipalityNames.Add(new MultiplicityName(0382, "Östhammar"));
                municipalityNames.Add(new MultiplicityName(0428, "Vingåker"));
                municipalityNames.Add(new MultiplicityName(0461, "Gnesta"));
                municipalityNames.Add(new MultiplicityName(0480, "Nyköping"));
                municipalityNames.Add(new MultiplicityName(0481, "Oxelösund"));
                municipalityNames.Add(new MultiplicityName(0482, "Flen"));
                municipalityNames.Add(new MultiplicityName(0483, "Katrineholm"));
                municipalityNames.Add(new MultiplicityName(0484, "Eskilstuna"));
                municipalityNames.Add(new MultiplicityName(0486, "Strängnäs"));
                municipalityNames.Add(new MultiplicityName(0488, "Trosa"));
                municipalityNames.Add(new MultiplicityName(0509, "Ödeshög"));
                municipalityNames.Add(new MultiplicityName(0512, "Ydre"));
                municipalityNames.Add(new MultiplicityName(0513, "Kinda"));
                municipalityNames.Add(new MultiplicityName(0560, "Boxholm"));
                municipalityNames.Add(new MultiplicityName(0561, "Åtvidaberg"));
                municipalityNames.Add(new MultiplicityName(0562, "Finspång"));
                municipalityNames.Add(new MultiplicityName(0563, "Valdemarsvik"));
                municipalityNames.Add(new MultiplicityName(0580, "Linköping"));
                municipalityNames.Add(new MultiplicityName(0581, "Norrköping"));
                municipalityNames.Add(new MultiplicityName(0582, "Söderköping"));
                municipalityNames.Add(new MultiplicityName(0583, "Motala"));
                municipalityNames.Add(new MultiplicityName(0584, "Vadstena"));
                municipalityNames.Add(new MultiplicityName(0586, "Mjölby"));
                municipalityNames.Add(new MultiplicityName(0604, "Aneby"));
                municipalityNames.Add(new MultiplicityName(0617, "Gnosjö"));
                municipalityNames.Add(new MultiplicityName(0642, "Mullsjö"));
                municipalityNames.Add(new MultiplicityName(0643, "Habo"));
                municipalityNames.Add(new MultiplicityName(0662, "Gislaved"));
                municipalityNames.Add(new MultiplicityName(0665, "Vaggeryd"));
                municipalityNames.Add(new MultiplicityName(0680, "Jönköping"));
                municipalityNames.Add(new MultiplicityName(0682, "Nässjö"));
                municipalityNames.Add(new MultiplicityName(0683, "Värnamo"));
                municipalityNames.Add(new MultiplicityName(0684, "Sävsjö"));
                municipalityNames.Add(new MultiplicityName(0685, "Vetlanda"));
                municipalityNames.Add(new MultiplicityName(0686, "Eksjö"));
                municipalityNames.Add(new MultiplicityName(0687, "Tranås"));
                municipalityNames.Add(new MultiplicityName(0760, "Uppvidinge"));
                municipalityNames.Add(new MultiplicityName(0761, "Lessebo"));
                municipalityNames.Add(new MultiplicityName(0763, "Tingsryd"));
                municipalityNames.Add(new MultiplicityName(0764, "Alvesta"));
                municipalityNames.Add(new MultiplicityName(0765, "Älmhult"));
                municipalityNames.Add(new MultiplicityName(0767, "Markaryd"));
                municipalityNames.Add(new MultiplicityName(0780, "Växjö"));
                municipalityNames.Add(new MultiplicityName(0781, "Ljungby"));
                municipalityNames.Add(new MultiplicityName(0821, "Högsby"));
                municipalityNames.Add(new MultiplicityName(0834, "Torsås"));
                municipalityNames.Add(new MultiplicityName(0840, "Mörbylånga"));
                municipalityNames.Add(new MultiplicityName(0860, "Hultsfred"));
                municipalityNames.Add(new MultiplicityName(0861, "Mönsterås"));
                municipalityNames.Add(new MultiplicityName(0862, "Emmaboda"));
                municipalityNames.Add(new MultiplicityName(0880, "Kalmar"));
                municipalityNames.Add(new MultiplicityName(0881, "Nybro"));
                municipalityNames.Add(new MultiplicityName(0882, "Oskarshamn"));
                municipalityNames.Add(new MultiplicityName(0883, "Västervik"));
                municipalityNames.Add(new MultiplicityName(0884, "Vimmerby"));
                municipalityNames.Add(new MultiplicityName(0885, "Borgholm"));
                municipalityNames.Add(new MultiplicityName(0980, "Gotland"));
                municipalityNames.Add(new MultiplicityName(1060, "Olofström"));
                municipalityNames.Add(new MultiplicityName(1080, "Karlskrona"));
                municipalityNames.Add(new MultiplicityName(1081, "Ronneby"));
                municipalityNames.Add(new MultiplicityName(1082, "Karlshamn"));
                municipalityNames.Add(new MultiplicityName(1083, "Sölvesborg"));
                municipalityNames.Add(new MultiplicityName(1214, "Svalöv"));
                municipalityNames.Add(new MultiplicityName(1230, "Staffanstorp"));
                municipalityNames.Add(new MultiplicityName(1231, "Burlöv"));
                municipalityNames.Add(new MultiplicityName(1233, "Vellinge"));
                municipalityNames.Add(new MultiplicityName(1256, "Östra Göinge"));
                municipalityNames.Add(new MultiplicityName(1257, "Örkelljunga"));
                municipalityNames.Add(new MultiplicityName(1260, "Bjuv"));
                municipalityNames.Add(new MultiplicityName(1261, "Kävlinge"));
                municipalityNames.Add(new MultiplicityName(1262, "Lomma"));
                municipalityNames.Add(new MultiplicityName(1263, "Svedala"));
                municipalityNames.Add(new MultiplicityName(1264, "Skurup"));
                municipalityNames.Add(new MultiplicityName(1265, "Sjöbo"));
                municipalityNames.Add(new MultiplicityName(1266, "Hörby"));
                municipalityNames.Add(new MultiplicityName(1267, "Höör"));
                municipalityNames.Add(new MultiplicityName(1270, "Tomelilla"));
                municipalityNames.Add(new MultiplicityName(1272, "Bromölla"));
                municipalityNames.Add(new MultiplicityName(1273, "Osby"));
                municipalityNames.Add(new MultiplicityName(1275, "Perstorp"));
                municipalityNames.Add(new MultiplicityName(1276, "Klippan"));
                municipalityNames.Add(new MultiplicityName(1277, "Åstorp"));
                municipalityNames.Add(new MultiplicityName(1278, "Båstad"));
                municipalityNames.Add(new MultiplicityName(1280, "Malmö"));
                municipalityNames.Add(new MultiplicityName(1281, "Lund"));
                municipalityNames.Add(new MultiplicityName(1282, "Landskrona"));
                municipalityNames.Add(new MultiplicityName(1283, "Helsingborg"));
                municipalityNames.Add(new MultiplicityName(1284, "Höganäs"));
                municipalityNames.Add(new MultiplicityName(1285, "Eslöv"));
                municipalityNames.Add(new MultiplicityName(1286, "Ystad"));
                municipalityNames.Add(new MultiplicityName(1287, "Trelleborg"));
                municipalityNames.Add(new MultiplicityName(1290, "Kristianstad"));
                municipalityNames.Add(new MultiplicityName(1291, "Simrishamn"));
                municipalityNames.Add(new MultiplicityName(1292, "Ängelholm"));
                municipalityNames.Add(new MultiplicityName(1293, "Hässleholm"));
                municipalityNames.Add(new MultiplicityName(1315, "Hylte"));
                municipalityNames.Add(new MultiplicityName(1380, "Halmstad"));
                municipalityNames.Add(new MultiplicityName(1381, "Laholm"));
                municipalityNames.Add(new MultiplicityName(1382, "Falkenberg"));
                municipalityNames.Add(new MultiplicityName(1383, "Varberg"));
                municipalityNames.Add(new MultiplicityName(1384, "Kungsbacka"));
                municipalityNames.Add(new MultiplicityName(1401, "Härryda"));
                municipalityNames.Add(new MultiplicityName(1402, "Partille"));
                municipalityNames.Add(new MultiplicityName(1407, "Öckerö"));
                municipalityNames.Add(new MultiplicityName(1415, "Stenungsund"));
                municipalityNames.Add(new MultiplicityName(1419, "Tjörn"));
                municipalityNames.Add(new MultiplicityName(1421, "Orust"));
                municipalityNames.Add(new MultiplicityName(1427, "Sotenäs"));
                municipalityNames.Add(new MultiplicityName(1430, "Munkedal"));
                municipalityNames.Add(new MultiplicityName(1435, "Tanum"));
                municipalityNames.Add(new MultiplicityName(1438, "Dals - Ed"));
                municipalityNames.Add(new MultiplicityName(1439, "Färgelanda"));
                municipalityNames.Add(new MultiplicityName(1440, "Ale"));
                municipalityNames.Add(new MultiplicityName(1441, "Lerum"));
                municipalityNames.Add(new MultiplicityName(1442, "Vårgårda"));
                municipalityNames.Add(new MultiplicityName(1443, "Bollebygd"));
                municipalityNames.Add(new MultiplicityName(1444, "Grästorp"));
                municipalityNames.Add(new MultiplicityName(1445, "Essunga"));
                municipalityNames.Add(new MultiplicityName(1446, "Karlsborg"));
                municipalityNames.Add(new MultiplicityName(1447, "Gullspång"));
                municipalityNames.Add(new MultiplicityName(1452, "Tranemo"));
                municipalityNames.Add(new MultiplicityName(1460, "Bengtsfors"));
                municipalityNames.Add(new MultiplicityName(1461, "Mellerud"));
                municipalityNames.Add(new MultiplicityName(1462, "Lilla Edet"));
                municipalityNames.Add(new MultiplicityName(1463, "Mark"));
                municipalityNames.Add(new MultiplicityName(1465, "Svenljunga"));
                municipalityNames.Add(new MultiplicityName(1466, "Herrljunga"));
                municipalityNames.Add(new MultiplicityName(1470, "Vara"));
                municipalityNames.Add(new MultiplicityName(1471, "Götene"));
                municipalityNames.Add(new MultiplicityName(1472, "Tibro"));
                municipalityNames.Add(new MultiplicityName(1473, "Töreboda"));
                municipalityNames.Add(new MultiplicityName(1480, "Göteborg"));
                municipalityNames.Add(new MultiplicityName(1481, "Mölndal"));
                municipalityNames.Add(new MultiplicityName(1482, "Kungälv"));
                municipalityNames.Add(new MultiplicityName(1484, "Lysekil"));
                municipalityNames.Add(new MultiplicityName(1485, "Uddevalla"));
                municipalityNames.Add(new MultiplicityName(1486, "Strömstad"));
                municipalityNames.Add(new MultiplicityName(1487, "Vänersborg"));
                municipalityNames.Add(new MultiplicityName(1488, "Trollhättan"));
                municipalityNames.Add(new MultiplicityName(1489, "Alingsås"));
                municipalityNames.Add(new MultiplicityName(1490, "Borås"));
                municipalityNames.Add(new MultiplicityName(1491, "Ulricehamn"));
                municipalityNames.Add(new MultiplicityName(1492, "Åmål"));
                municipalityNames.Add(new MultiplicityName(1493, "Mariestad"));
                municipalityNames.Add(new MultiplicityName(1494, "Lidköping"));
                municipalityNames.Add(new MultiplicityName(1495, "Skara"));
                municipalityNames.Add(new MultiplicityName(1496, "Skövde"));
                municipalityNames.Add(new MultiplicityName(1497, "Hjo"));
                municipalityNames.Add(new MultiplicityName(1498, "Tidaholm"));
                municipalityNames.Add(new MultiplicityName(1499, "Falköping"));
                municipalityNames.Add(new MultiplicityName(1715, "Kil"));
                municipalityNames.Add(new MultiplicityName(1730, "Eda"));
                municipalityNames.Add(new MultiplicityName(1737, "Torsby"));
                municipalityNames.Add(new MultiplicityName(1760, "Storfors"));
                municipalityNames.Add(new MultiplicityName(1761, "Hammarö"));
                municipalityNames.Add(new MultiplicityName(1762, "Munkfors"));
                municipalityNames.Add(new MultiplicityName(1763, "Forshaga"));
                municipalityNames.Add(new MultiplicityName(1764, "Grums"));
                municipalityNames.Add(new MultiplicityName(1765, "Årjäng"));
                municipalityNames.Add(new MultiplicityName(1766, "Sunne"));
                municipalityNames.Add(new MultiplicityName(1780, "Karlstad"));
                municipalityNames.Add(new MultiplicityName(1781, "Kristinehamn"));
                municipalityNames.Add(new MultiplicityName(1782, "Filipstad"));
                municipalityNames.Add(new MultiplicityName(1783, "Hagfors"));
                municipalityNames.Add(new MultiplicityName(1784, "Arvika"));
                municipalityNames.Add(new MultiplicityName(1785, "Säffle"));
                municipalityNames.Add(new MultiplicityName(1814, "Lekeberg"));
                municipalityNames.Add(new MultiplicityName(1860, "Laxå"));
                municipalityNames.Add(new MultiplicityName(1861, "Hallsberg"));
                municipalityNames.Add(new MultiplicityName(1862, "Degerfors"));
                municipalityNames.Add(new MultiplicityName(1863, "Hällefors"));
                municipalityNames.Add(new MultiplicityName(1864, "Ljusnarsberg"));
                municipalityNames.Add(new MultiplicityName(1880, "Örebro"));
                municipalityNames.Add(new MultiplicityName(1881, "Kumla"));
                municipalityNames.Add(new MultiplicityName(1882, "Askersund"));
                municipalityNames.Add(new MultiplicityName(1883, "Karlskoga"));
                municipalityNames.Add(new MultiplicityName(1884, "Nora"));
                municipalityNames.Add(new MultiplicityName(1885, "Lindesberg"));
                municipalityNames.Add(new MultiplicityName(1904, "Skinnskatteberg"));
                municipalityNames.Add(new MultiplicityName(1907, "Surahammar"));
                municipalityNames.Add(new MultiplicityName(1960, "Kungsör"));
                municipalityNames.Add(new MultiplicityName(1961, "Hallstahammar"));
                municipalityNames.Add(new MultiplicityName(1962, "Norberg"));
                municipalityNames.Add(new MultiplicityName(1980, "Västerås"));
                municipalityNames.Add(new MultiplicityName(1981, "Sala"));
                municipalityNames.Add(new MultiplicityName(1982, "Fagersta"));
                municipalityNames.Add(new MultiplicityName(1983, "Köping"));
                municipalityNames.Add(new MultiplicityName(1984, "Arboga"));
                municipalityNames.Add(new MultiplicityName(2021, "Vansbro"));
                municipalityNames.Add(new MultiplicityName(2023, "Malung - Sälen"));
                municipalityNames.Add(new MultiplicityName(2026, "Gagnef"));
                municipalityNames.Add(new MultiplicityName(2029, "Leksand"));
                municipalityNames.Add(new MultiplicityName(2031, "Rättvik"));
                municipalityNames.Add(new MultiplicityName(2034, "Orsa"));
                municipalityNames.Add(new MultiplicityName(2039, "Älvdalen"));
                municipalityNames.Add(new MultiplicityName(2061, "Smedjebacken"));
                municipalityNames.Add(new MultiplicityName(2062, "Mora"));
                municipalityNames.Add(new MultiplicityName(2080, "Falun"));
                municipalityNames.Add(new MultiplicityName(2081, "Borlänge"));
                municipalityNames.Add(new MultiplicityName(2082, "Säter"));
                municipalityNames.Add(new MultiplicityName(2083, "Hedemora"));
                municipalityNames.Add(new MultiplicityName(2084, "Avesta"));
                municipalityNames.Add(new MultiplicityName(2085, "Ludvika"));
                municipalityNames.Add(new MultiplicityName(2101, "Ockelbo"));
                municipalityNames.Add(new MultiplicityName(2104, "Hofors"));
                municipalityNames.Add(new MultiplicityName(2121, "Ovanåker"));
                municipalityNames.Add(new MultiplicityName(2132, "Nordanstig"));
                municipalityNames.Add(new MultiplicityName(2161, "Ljusdal"));
                municipalityNames.Add(new MultiplicityName(2180, "Gävle"));
                municipalityNames.Add(new MultiplicityName(2181, "Sandviken"));
                municipalityNames.Add(new MultiplicityName(2182, "Söderhamn"));
                municipalityNames.Add(new MultiplicityName(2183, "Bollnäs"));
                municipalityNames.Add(new MultiplicityName(2184, "Hudiksvall"));
                municipalityNames.Add(new MultiplicityName(2260, "Ånge"));
                municipalityNames.Add(new MultiplicityName(2262, "Timrå"));
                municipalityNames.Add(new MultiplicityName(2280, "Härnösand"));
                municipalityNames.Add(new MultiplicityName(2281, "Sundsvall"));
                municipalityNames.Add(new MultiplicityName(2282, "Kramfors"));
                municipalityNames.Add(new MultiplicityName(2283, "Sollefteå"));
                municipalityNames.Add(new MultiplicityName(2284, "Örnsköldsvik"));
                municipalityNames.Add(new MultiplicityName(2303, "Ragunda"));
                municipalityNames.Add(new MultiplicityName(2305, "Bräcke"));
                municipalityNames.Add(new MultiplicityName(2309, "Krokom"));
                municipalityNames.Add(new MultiplicityName(2313, "Strömsund"));
                municipalityNames.Add(new MultiplicityName(2321, "Åre"));
                municipalityNames.Add(new MultiplicityName(2326, "Berg"));
                municipalityNames.Add(new MultiplicityName(2361, "Härjedalen"));
                municipalityNames.Add(new MultiplicityName(2380, "Östersund"));
                municipalityNames.Add(new MultiplicityName(2401, "Nordmaling"));
                municipalityNames.Add(new MultiplicityName(2403, "Bjurholm"));
                municipalityNames.Add(new MultiplicityName(2404, "Vindeln"));
                municipalityNames.Add(new MultiplicityName(2409, "Robertsfors"));
                municipalityNames.Add(new MultiplicityName(2417, "Norsjö"));
                municipalityNames.Add(new MultiplicityName(2418, "Malå"));
                municipalityNames.Add(new MultiplicityName(2421, "Storuman"));
                municipalityNames.Add(new MultiplicityName(2422, "Sorsele"));
                municipalityNames.Add(new MultiplicityName(2425, "Dorotea"));
                municipalityNames.Add(new MultiplicityName(2460, "Vännäs"));
                municipalityNames.Add(new MultiplicityName(2462, "Vilhelmina"));
                municipalityNames.Add(new MultiplicityName(2463, "Åsele"));
                municipalityNames.Add(new MultiplicityName(2480, "Umeå"));
                municipalityNames.Add(new MultiplicityName(2481, "Lycksele"));
                municipalityNames.Add(new MultiplicityName(2482, "Skellefteå"));
                municipalityNames.Add(new MultiplicityName(2505, "Arvidsjaur"));
                municipalityNames.Add(new MultiplicityName(2506, "Arjeplog"));
                municipalityNames.Add(new MultiplicityName(2510, "Jokkmokk"));
                municipalityNames.Add(new MultiplicityName(2513, "Överkalix"));
                municipalityNames.Add(new MultiplicityName(2514, "Kalix"));
                municipalityNames.Add(new MultiplicityName(2518, "Övertorneå"));
                municipalityNames.Add(new MultiplicityName(2521, "Pajala"));
                municipalityNames.Add(new MultiplicityName(2523, "Gällivare"));
                municipalityNames.Add(new MultiplicityName(2560, "Älvsbyn"));
                municipalityNames.Add(new MultiplicityName(2580, "Luleå"));
                municipalityNames.Add(new MultiplicityName(2581, "Piteå"));
                municipalityNames.Add(new MultiplicityName(2582, "Boden"));
                municipalityNames.Add(new MultiplicityName(2583, "Haparanda"));
                municipalityNames.Add(new MultiplicityName(2584, "Kiruna"));

                context.MunicipalityNames.AddRange(municipalityNames);
                context.SaveChanges();

                context.Genders.AddRange(new List<Gender>()
                {
                    new Gender() {GenderId = 1, Name = "Male"},
                    new Gender() {GenderId = 2, Name = "Female"},
                });
                context.SaveChanges();

                var apiConsummer = new APIConsumer();
                context.Municipalities.AddRange(apiConsummer.CollectSetOneData());
                context.SaveChanges();
            }
        }
    }
}