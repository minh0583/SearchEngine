using System.Configuration;

namespace EngineConfiguration
{
    public class SearchEngineSetting : ConfigurationSection
    {
        private static SearchEngineSetting settings = ConfigurationManager.GetSection("SearchEngineSetting") as SearchEngineSetting;

        public static SearchEngineSetting Settings => settings;

        [ConfigurationProperty("isEnabled", DefaultValue = false, IsRequired = true)] 
        public bool IsEnabled
        {
            get { return (bool)this["isEnabled"]; }
            set { this["isEnabled"] = value; }
        }

        [ConfigurationProperty("connectionUrl", IsRequired = true)]
        public string ConnectionUrl
        {
            get { return (string)this["connectionUrl"]; }
            set { this["connectionUrl"] = value; }
        }

        [ConfigurationProperty("engineType", IsRequired = true)]
        public EngineType EngineType
        {
            get { return (EngineType)this["engineType"]; }
            set { this["engineType"] = value; }
        }
    }
}
