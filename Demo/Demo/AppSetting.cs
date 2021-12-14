using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Demo
{
    class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string getConnectionString(string NameCS)
        {
            return config.ConnectionStrings.ConnectionStrings[NameCS].ConnectionString;
        }
        public void setConnectionString(string nameCS,string valueCS )
        {
            config.ConnectionStrings.ConnectionStrings[nameCS].ConnectionString = valueCS;
            config.ConnectionStrings.ConnectionStrings[nameCS].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
