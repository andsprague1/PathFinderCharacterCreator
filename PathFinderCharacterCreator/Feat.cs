using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows.Shapes;
using System.Data.SQLite;
using PathFinderCharacterCreator.Properties;
using System.Security.Cryptography;

namespace PathFinderCharacterCreator
{
    [DataContract]
    class Feat
    {
        //TODO, make consistant. This was created when I was storing with JSON not SQLite. use paramenters, and model it after Skill.cs

        [DataMember]
        public int Id;
        private string name;
        [DataMember]
        public string Description;
        [DataMember]
        public string FeatType;
        [DataMember]
        public int Level;

        [DataMember]
        public string Name { get => name; set => name = value; }

        public Feat()
        {
        }

        public Feat(int id,int level, string name,string description,string feattype)
        {
            Id = id;
            Level = level;
            Name = name;
            Description = description;
            FeatType = feattype;
        }

        internal static List<Feat> LoadFeats(string type = "")
        { //TODO Templates in C#
            List<Feat> feats = new List<Feat>();


            string query = "select * from Feats;";
            if(type.Length > 0)
            {
                query = "select * from Feats where feat_type = '" + type+ "'";
            }


            SQLiteConnection conn = new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader datareader = cmd.ExecuteReader();

            while(datareader.Read())
            {
                

                Feat addFeat=new Feat();
                addFeat.Id = datareader.GetInt32(0);
                addFeat.Level = datareader.GetInt32(1);
                addFeat.Name = datareader.GetString(2);
                addFeat.FeatType = datareader.GetString(3);
                addFeat.Description = datareader.GetString(4);

                feats.Add(addFeat);
            }
            conn.Close();

            return feats;
        }
    }
}
