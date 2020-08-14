using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderCharacterCreator
{
    [DataContract]
    class Class
    {
        [DataMember]
        public int Id;
        [DataMember]
        private string _name = "";
        [DataMember]
        private int _standardHitpoints=0;
        [DataMember]
        private string _keyAbility="";
        [DataMember]
        public List<string> TrainedIn;
        [DataMember]
        public List<string> ExpertIn;
        [DataMember]
        private string description = "";
        
        Class(string name, int standardHitpoints, string keyAbility)
        {
            _name = name;
            _standardHitpoints = standardHitpoints;
            _keyAbility = keyAbility;
            TrainedIn = new List<string>();
            ExpertIn = new List<string>();
        }

        public void AddTraining(string training)
        {
            TrainedIn.Add(training);
        }
        
        public void AddExpertise(string expertise)
        {
            ExpertIn.Add(expertise);
        }

    }
}
