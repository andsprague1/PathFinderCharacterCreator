using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderCharacterCreator
{
    class Class
    {
        private string _name = "";
        private int _standardHitpoints=0;
        private string _keyAbility="";
        public List<string> TrainedIn;
        public List<string> ExpertIn;
        
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
