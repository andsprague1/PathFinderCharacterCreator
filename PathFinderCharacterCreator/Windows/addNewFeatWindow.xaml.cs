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
            if (File.Exists("Feats.json"))
            {
                feats = Feat.LoadFeats();
            }
            nextID = feats.Count;
            foreach (Feat f in feats)
            {
                listBoxFeats.Items.Add(f.Name);
            }
        }

        private void FeatTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists("Feats.json"))
            {
                File.Delete("Feats.json");
            }
            StreamWriter sw = new StreamWriter("Feats.json");
            foreach(Feat f in feats)
            {                
                string JSONresult = JsonConvert.SerializeObject(f);
                sw.WriteLine(JSONresult);
            }
            sw.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int lvl = int.Parse(txtLevel.Text);//TODO error checking
            TextRange textRange = new TextRange(TextBoxDescription.Document.ContentStart, TextBoxDescription.Document.ContentEnd);
            Feat newFeat = new Feat(nextID,lvl, FeatNameTextBox.Text, textRange.Text, FeatTypeComboBox.Text);
            feats.Add(newFeat);
            listBoxFeats.Items.Add(newFeat.Name);
            nextID += 1;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            feats.RemoveAt(listBoxFeats.SelectedIndex);
            listBoxFeats.Items.RemoveAt(listBoxFeats.SelectedIndex);
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
