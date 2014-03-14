using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace DÖMDBrackets
{
    class Match
    {
        public int id;
        public int roundID;
        public string team1;
        public string team2;
        public string winner;
        public int timestamp;
        public bool needRender = true;
    }
}
