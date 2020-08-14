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

namespace PathFinderCharacterCreator.Windows
{
    /// <summary>
    /// Interaction logic for addNewBackground.xaml
    /// </summary>
    public partial class addNewBackground : Window
    {
        List<Feat> feats = new List<Feat>();
        List<Feat> selectedFeats = new List<Feat>();
        List<Skill> skills = new List<Skill>();
        public addNewBackground()
        {
            InitializeComponent();
            feats = Feat.LoadFeats();
            lstAvailableFeats.ItemsSource = feats;
            lstSelectedFeats.ItemsSource = selectedFeats;
            skills = Skill.FillSkillList();

            //can this be done with a list?
            fillSkillListBox(SkillsGrid);
        }

        void fillSkillListBox(Grid workGrid)
        {
            
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            workGrid.ColumnDefinitions.Add(gridCol1);
            workGrid.ColumnDefinitions.Add(gridCol2);
            int count = 0;
            foreach ( Skill s in skills)
            {

                System.Windows.Controls.Label newlabel = new System.Windows.Controls.Label();
                newlabel.Content = s.Name;
                

                ComboBox newcb = new ComboBox();

                newcb.Items.Add("untrained");
                newcb.Items.Add("trained");
                newcb.Items.Add("expert");
                newcb.Items.Add("master");
                newcb.Items.Add("legendary");

                newcb.Name = s.Name.Replace(" ", "")+"_"+s.Id + "_comboBox";
                RowDefinition gridRow1 = new RowDefinition();
                workGrid.RowDefinitions.Add(gridRow1);
                Grid.SetColumn(newlabel, 0);
                Grid.SetRow(newlabel, count);

                workGrid.Children.Add(newlabel);

                Grid.SetColumn(newcb, 1);
                Grid.SetRow(newcb, count);

                workGrid.Children.Add(newcb);

                count += 1;
            }
        }

        //todo, gui components, this is used in 2 sections. Can it be separated out?
        //todo These could be done with a swap list box function
        private void ButtonAddFeat_Click(object sender, RoutedEventArgs e)
        {
            if (lstAvailableFeats.SelectedItem is null)
            {
                return;
            }
            selectedFeats.Add((Feat)lstAvailableFeats.SelectedItem);
            feats.Remove((Feat)lstAvailableFeats.SelectedItem);
            lstAvailableFeats.ItemsSource = null;
            lstSelectedFeats.ItemsSource = null;
            lstAvailableFeats.ItemsSource = feats;
            lstSelectedFeats.ItemsSource = selectedFeats;
        }

        private void ButtonRemoveFeat_Click(object sender, RoutedEventArgs e)
        {

            if (lstSelectedFeats.SelectedItem is null)
            {
                return;
            }
            feats.Add((Feat)lstSelectedFeats.SelectedItem);
            selectedFeats.Remove((Feat)lstSelectedFeats.SelectedItem);
            lstAvailableFeats.ItemsSource = null;
            lstSelectedFeats.ItemsSource = null;
            lstAvailableFeats.ItemsSource = feats;
            lstSelectedFeats.ItemsSource = selectedFeats;
        }

    }
}
