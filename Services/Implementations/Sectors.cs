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
             { "Construction", "construction" },
             { "Consumer Goods", "consumerGoods" },
             { "Education", "education" },
             { "Energy", "energy" },
             { "Entertainment", "entertainment" },            
             { "Finance", "finance" },
             { "Food", "food" },
             { "Healthcare", "healthcare" },
             { "Hospitality", "hospitality" },
             { "Information Technology", "informationTechnology" },
             { "Manufacturing", "manufacturing" },
             { "Marketing", "marketing" },
             { "Real Estate", "realState" },
             { "Retail", "retail" },
             { "Transportation", "transportation" }                                
         };
}
