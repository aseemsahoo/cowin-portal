using System;
using System.Configuration;

namespace Cowin_Portal
{
    public static class Helper
    {
        public static string CnnVal (string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; 
        }
    }
}
