using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class ConnectionString
    {
        public static string ConnectString = 
        @"Data Source=DESKTOP-16PSAEB;Initial Catalog=CreateAnalyticSystem;Integrated Security=True;Persist Security Info=False; Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
    }
}
//класс с хранимками статик
//добавить статику для смены