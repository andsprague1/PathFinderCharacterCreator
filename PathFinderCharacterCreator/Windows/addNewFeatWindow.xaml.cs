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
using System.IO;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace PathFinderCharacterCreator.Windows
{

    //TODO save edits, correct deletes, shift to SQL (Currently using JSON for practice, but that should only be the final sheets)
    /// <summary>
    /// Interaction logic for addNewFeatWindow.xaml
    /// </summary>
    public partial class addNewFeatWindow : Window
    {
        List<Feat> feats;
        int nextID = 0;
        public addNewFeatWindow()
        {
            InitializeComponent();
            feats = new List<Feat>();
            feats = Feat.LoadFeats();


            listBoxFeats.ItemsSource = feats;

        }

        private void FeatTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        //TODO save and add are very similar, they could probably be made one function and take a query string as a parameter
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            int lvl = int.Parse(txtLevel.Text);//TODO error checking
            TextRange textRange = new TextRange(TextBoxDescription.Document.ContentStart, TextBoxDescription.Document.ContentEnd);

            string query = "Update Feats set feat_level=@lvl,feat_name=@name,feat_type=@type,feat_description=@description where id_feat=@id;";

            SQLiteConnection conn = new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            cmd.Parameters.AddWithValue("@lvl", lvl);
            cmd.Parameters.AddWithValue("@name", FeatNameTextBox.Text);
            cmd.Parameters.AddWithValue("@type", FeatTypeComboBox.Text);
            cmd.Parameters.AddWithValue("@description", textRange.Text);

            conn.Close();

            feats = Feat.LoadFeats();
            listBoxFeats.ItemsSource = feats;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int lvl = int.Parse(txtLevel.Text);//TODO error checking
            TextRange textRange = new TextRange(TextBoxDescription.Document.ContentStart, TextBoxDescription.Document.ContentEnd);

            string query = "Insert into Feats(feat_level,feat_name,feat_type,feat_description) Values(@lvl,@name,@type,@description);";

            SQLiteConnection conn = new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            cmd.Parameters.AddWithValue("@lvl",lvl);
            cmd.Parameters.AddWithValue("@name", FeatNameTextBox.Text);
            cmd.Parameters.AddWithValue("@type", FeatTypeComboBox.Text);
            cmd.Parameters.AddWithValue("@description", textRange.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            feats = Feat.LoadFeats();
            listBoxFeats.ItemsSource = feats;

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            feats.RemoveAt(listBoxFeats.SelectedIndex);
            listBoxFeats.Items.RemoveAt(listBoxFeats.SelectedIndex);

            string query="Delete from Feats where id_feat = " + feats[listBoxFeats.SelectedIndex].Id;
            SQLiteConnection conn = new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void listBoxFeats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxFeats.SelectedIndex > -1)
            {
                Feat selectedFeat = feats[listBoxFeats.SelectedIndex];

                TextBoxDescription.Selection.Text = selectedFeat.Description;
                FeatNameTextBox.Text = selectedFeat.Name;
                FeatTypeComboBox.Text = selectedFeat.FeatType;
                txtLevel.Text = selectedFeat.Level.ToString();
            }
        }
    }
}
