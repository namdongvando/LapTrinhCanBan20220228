using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDB.Model
{
    class Countries
    {
        public string name { get; set; }
        public string code { get; set; }


        public static List<Countries>  GetCountries() {
            string content = File.ReadAllText(@"Data/countries.json");
            var ListCountries = JsonConvert.DeserializeObject<List<Countries>>(content); return ListCountries;

        }


    }
     
}
