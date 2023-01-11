using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace kaulOV.Models
{
    class KauloDB
    {
        #region fields
        MySqlConnection _connection = new MySqlConnection("Server = kaulov.mysql.database.azure.com; UserID = kaulovmain;Password=Ax74@3V&RUE2ohMnEfB8U^n78*NXzKve$yEtNnnApSIHg1rleB;Database=kaulov;SslMode=MySqlSslMode.Required;SslCa=ssl\\DigiCertGlobalRootCA.crt.pem;");
        #endregion

        #region methods/functions

        #endregion
    }
}
