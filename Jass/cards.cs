using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jass
{
    class cards
    {
        //ILog log;
        string cardresult = "";
        string[] colors = { "Rose", "Eichle", "Schälle", "Schelte" };
        string[] values = { "-Sechsi", "-Sebni", "-Achti", "-Nüni", "-Banner", "-Under", "-Ober", "-König", "-Ass" };

        public void CreateCardList()
        {
            //log = LogManager.GetLogger("cards");
            List<string> list = new List<string>();
            for (int i = 0; i != 4; i++)
            {
                for (int ii = 0; ii != 9; ii++)
                {
                    cardresult = colors[i].ToString();
                    cardresult += values[ii];
                    list.Add(cardresult);
                    
                    Console.WriteLine($"Karte {cardresult}");
                }
            }

        }

        private void shuffle()
        {

        }
    }
}
