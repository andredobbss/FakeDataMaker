using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class Sectors : ISectors
{
    public IDictionary<string, string> GetSectors() => new Dictionary<string, string>
        {
             { "Accounting", "accounting" },
             { "Aerospace", "aerospace" },
             { "Agriculture", "agriculture" },
             { "Automotive", "automotive" },
             { "Biotechnology","biotechnology" },
             { "Civil Construction", "civilConstruction" },
             { "Consumer Goods", "consumerGoods" },
             { "Contability","contability" },
             { "Cybersecurity","cybersecurity" },
             { "E-commerce","ecommerce" },
             { "Economy","economy" },
             { "Education", "education" },
             { "Energy", "energy" },
             { "Entertainment", "entertainment" },
             { "Environmental Services","environmental" },
             { "Finance", "finance" },
             { "Food", "food" },
             { "Government / Public Sector","publicSector" },
             { "Healthcare", "healthcare" },
             { "Hospitality", "hospitality" },
             { "Information Technology", "informationTechnology" },
             { "Insurance","insurance" },
             { "Legal Services","legalServices" },
             { "Logistics","logistics" },
             { "Manufacturing", "manufacturing" },
             { "Marketing", "marketing" },
             { "Media & Publishing","mediaPublishing" },
             { "Mining","mining" },
             { "Nonprofit / NGO","nonprofit" },
             { "Real Estate", "realState" },
             { "Retail", "retail" },
             { "Sports & Recreation","sportsRecreation" },
             { "Telecommunications","telecommunications" },
             { "Transportation", "transportation" },

         };
}
