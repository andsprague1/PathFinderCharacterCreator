using Microsoft.Data.Sqlite;
using PathFinderCharacterCreator.Windows;
using System.IO;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;

namespace PathFinderCharacterCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character character = new Character();
        public MainWindow()
        {
            InitializeComponent();

            LoadListBoxes();

        }

        private void LoadListBoxes()
        {

            string[] lines = System.IO.File.ReadAllLines("proficiencies");
            Grid NonSkillsGrid1 = new Grid();
            int start = 0;
            start = FillDataGrid(start, lines,NonSkillsGrid);

            start += 1;

            start = FillDataGrid(start, lines, SkillsGrid);

            start += 1;

            start = FillDataGrid(start, lines, SavesGrid);

        }

        private int FillDataGrid(int start, string[] lines, Grid workGrid)
        {
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            workGrid.ColumnDefinitions.Add(gridCol1);
            workGrid.ColumnDefinitions.Add(gridCol2);
            int count = 0;
            while (!lines[start].Equals("-"))
            {
                System.Windows.Controls.Label newlabel = new System.Windows.Controls.Label();
                newlabel.Content = lines[start];


                ComboBox newcb = new ComboBox();

                newcb.Items.Add("untrained");
                newcb.Items.Add("trained");
                newcb.Items.Add("expert");
                newcb.Items.Add("master");
                newcb.Items.Add("legendary");

                newcb.Name = lines[start].Replace(" ","") + "comboBox";
                RowDefinition gridRow1 = new RowDefinition();
                workGrid.RowDefinitions.Add(gridRow1);
                Grid.SetColumn(newlabel, 0);
                Grid.SetRow(newlabel, count);

                workGrid.Children.Add(newlabel);

                Grid.SetColumn(newcb, 1);
                Grid.SetRow(newcb, count);

                workGrid.Children.Add(newcb);

                count += 1;
                start += 1;
            }
            return start;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StrengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            character.Strength = int.Parse(StrengthTextBox.Text);
            STRModifierTextBox.Text = character.CalculateAbilityModifier(character.Strength).ToString();
        }

        private void DexterityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            character.Dexterity = int.Parse(DexterityTextBox.Text);
            DEXModifierTextBox.Text = character.CalculateAbilityModifier(character.Dexterity).ToString();
        }

        private void ConstitutionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            character.Constitution = int.Parse(ConstitutionTextBox.Text);
            CONModifierTextBox.Text = character.CalculateAbilityModifier(character.Constitution).ToString();
        }

        private void IntelligenceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            character.Inteligence = int.Parse(IntelligenceTextBox.Text);
            INTModifierTextBox.Text = character.CalculateAbilityModifier(character.Inteligence).ToString();
        }

        private void WisdomTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            character.Wisdom = int.Parse(WisdomTextBox.Text);
            WISModifierTextBox.Text = character.CalculateAbilityModifier(character.Wisdom).ToString();
        }

        private void CharismaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            character.Charisma = int.Parse(CharismaTextBox.Text);
            CHAModifierTextBox.Text = character.CalculateAbilityModifier(character.Charisma).ToString();
        }

        private void STRModifierTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NewClassButton_Click(object sender, RoutedEventArgs e)
        {
            addNewClass newClass = new addNewClass();
            newClass.Show();
        }

        private void NewAncestryButton_Click(object sender, RoutedEventArgs e)
        {
            addNewAncestryWindow newAncestryWindow = new addNewAncestryWindow();
            newAncestryWindow.Show();
        }

        private void NewHearatageButton_Click(object sender, RoutedEventArgs e)
        {
            addNewHeritageWindow newHeritageWindow = new addNewHeritageWindow();
            newHeritageWindow.Show();
        }

        private void NewFeatButton_Click(object sender, RoutedEventArgs e)
        {
            addNewFeatWindow newFeatWindow = new addNewFeatWindow();
            newFeatWindow.Show();
        }

        private void NewSkillButton_Click(object sender, RoutedEventArgs e)
        {
            addNewSkillWindow newSkillWindow = new addNewSkillWindow();
            newSkillWindow.Show();
        }

        private void NewBackgroundButton_Click(object sender, RoutedEventArgs e)
        {
            addNewBackground newBackgroundWindow = new addNewBackground();
            newBackgroundWindow.Show();
        }
    }
    
    
}
