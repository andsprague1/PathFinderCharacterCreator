using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PathFinderCharacterCreator
{
    class Skill
    {
        int id = -1;
        string name = "";
        string description = "";
        string ability = "";

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Ability { get => ability; set => ability = value; }
        public int Id { get => id; set => id = value; }

        public Skill()
        {

        }
        public Skill(int getId)
        {
            SQLiteConnection Conn = new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            string query = "select * from Skills where id =" + id.ToString();
            SQLiteCommand cmd = new SQLiteCommand(query, Conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            
            if(reader.HasRows)
            {
                id = getId;
                Name = reader.GetString(1);
                Description = reader.GetString(2);
                Ability = reader.GetString(3);
            }

        }

        public static List<Skill> FillSkillList()
        {
            List<Skill> skillList = new List<Skill>();

            String query = "Select * from Skills;";
            var con = new SQLiteConnection(Properties.Settings.Default.ConnectionString);

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();
            SQLiteDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Skill addSkill = new Skill();
                addSkill.id = datareader.GetInt32(0);
                addSkill.Name = datareader.GetString(1);
                addSkill.Description = datareader.GetString(2);
                addSkill.Ability = datareader.GetString(3);
                skillList.Add(addSkill);
            }
            con.Close();
            //        DataTable dt = new DataTable();
            //          SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
            //            dataAdapter.Fill(dt);

            return skillList;
        }


    }
}
