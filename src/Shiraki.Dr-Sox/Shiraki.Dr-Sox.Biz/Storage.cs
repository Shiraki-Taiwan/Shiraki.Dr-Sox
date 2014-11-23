using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiraki.Dr_Sox
{
    public static class Storage
    {
        public static Dictionary<string, string> ShopAmount { get; set; }

        static Storage()
        {
            ShopAmount = new Dictionary<string, string>();
            ShopAmount.Add("0", "請選取數量");
            for (var i = 1; i <= 100; i++)
            {
                ShopAmount.Add(i.ToString(), i.ToString());
            }
        }
    }
}
