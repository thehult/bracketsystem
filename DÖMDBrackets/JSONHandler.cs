using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace DÖMDBrackets
{
    
    class JSONHandler
    {
        public static void loadJSON(string JSON, int teamCount) {
            Match tmpMatch;
            int round = 1;


            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<dynamic>(JSON);
            int i = 0;
            foreach (dynamic dic in dict)
            {
                
                tmpMatch = new Match();
                tmpMatch.id = dic["id"];
                tmpMatch.roundID = dic["roundID"];
                tmpMatch.team1 = dic["teams"][0];
                tmpMatch.team2 = dic["teams"][1];
                BracketHandler.matches[round - 1, i] = tmpMatch;
                i++;
                if (i == teamCount / (int)Math.Pow(2, round) - 1)
                {
                    round++;
                    i = 0;
                }
                if (round >= BracketHandler.matches.GetLength(0))
                {
                    break;
                }
            }
        }
    }
}
