using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoi
{
    public static class Bd
    {
        static string connectionString = "server=localhost;port=3308;username=root;password=2726011013;database=plumbers_shop;";
        public static string get_st() {  return connectionString; }
    }
}
