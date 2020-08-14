using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PathFinderCharacterCreator.Properties;
using System.Data;

namespace PathFinderCharacterCreator.Windows
{
    /// <summary>
    /// Interaction logic for addNewSkillWindow.xaml
    /// </summary>
    public partial class addNewSkillWindow : Window
    {
        List<Skill> skillList = new List<Skill>();
        int selectedId = -1;
        public addNewSkillWindow()
        {
            InitializeComponent();
            LoadSkills();
        }

        private void LoadSkills()
        {
            skillList = Skill.FillSkillList();
            skillsListBox.ItemsSource = skillList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            String query="Insert Into Skills(skillName,skillDescription,skillAbility) Values(@skillName, @skillDescription, @skillAbility);";
            int numberOfRowsAffected = 0;

            using (var con = new SQLiteConnection(Properties.Settings.Default.ConnectionString))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(query, con))
                {
                    TextRange textRange = new TextRange(txtDescription.Document.ContentStart, txtDescription.Document.ContentEnd);

                    cmd.Parameters.AddWithValue("@skillName", txtName.Text);
                    cmd.Parameters.AddWithValue("@skillDescription", textRange.Text);
                    cmd.Parameters.AddWithValue("@skillAbility", AbilityComboBox.Text);

                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            LoadSkills();
                

            
        }

        private void skillsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(skillList.Count<0)
            {
                return;
            }
            if(skillsListBox.SelectedIndex < 0)
            {
                return;
            }

            txtName.Text = skillList[skillsListBox.SelectedIndex].Name;
            txtDescription.Document.Blocks.Clear();
            txtDescription.AppendText(skillList[skillsListBox.SelectedIndex].Description);

            AbilityComboBox.Text = skillList[skillsListBox.SelectedIndex].Ability;
            selectedId = skillList[skillsListBox.SelectedIndex].Id;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            String query = "Update Skills Set skillName = @skillName ,skillDescription = @skillDescription" +
                ",skillAbility = @skillAbility where id = @id;";
            int numberOfRowsAffected = 0;

            using (var con = new SQLiteConnection(Properties.Settings.Default.ConnectionString))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(query, con))
                {
                    TextRange textRange = new TextRange(txtDescription.Document.ContentStart, txtDescription.Document.ContentEnd);


                    cmd.Parameters.AddWithValue("@skillName", txtName.Text);
                    cmd.Parameters.AddWithValue("@skillDescription", textRange.Text);
                    cmd.Parameters.AddWithValue("@skillAbility", AbilityComboBox.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);


                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            LoadSkills();



        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            String query = "Delete from Skills where id = @id;";
            int numberOfRowsAffected = 0;

            using (var con = new SQLiteConnection(Properties.Settings.Default.ConnectionString))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            LoadSkills();


        }
    }
}
