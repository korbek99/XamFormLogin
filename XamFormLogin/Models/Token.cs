using System;
using SQLite;

namespace XamFormLogin.Models
{
    public class Token
    {
        public Token()
        {
        }

        [PrimaryKey]
        public int id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }


    }
}
