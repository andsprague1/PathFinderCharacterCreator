using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows.Shapes;

namespace PathFinderCharacterCreator
{
    [DataContract]
    class Feat
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Name;
        [DataMember]
        public string Description;
        [DataMember]
        public string FeatType;
        [DataMember]
        public int Level;

        public Feat(int id,int level, string name,string description,string feattype)
        {
            Id = id;
            Level = level;
            Name = name;
            Description = description;
            FeatType = feattype;
        }

        internal static List<Feat> LoadFeats()
        { //TODO Templates in C#
            List<Feat> feats = new List<Feat>();
            StreamReader file = new StreamReader("Feats.json");
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Feat));
            string jsonData;
            while ((jsonData = file.ReadLine())!=null)
            {
                MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData));
                Feat feat;
                feat = (Feat) jsonSerializer.ReadObject(stream);
                feats.Add(feat);
            }

            return feats;
        }
    }
}
