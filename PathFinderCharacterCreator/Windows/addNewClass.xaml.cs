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

namespace PathFinderCharacterCreator
{
    /// <summary>
    /// Interaction logic for addNewClass.xaml
    /// </summary>
    public partial class addNewClass : Window
    {
        public addNewClass()
        {
            InitializeComponent();
            LoadListBoxes();//TODO code is copied, move into it's own separate component?
        
        }

        private void LoadListBoxes()
        {

            string[] lines = System.IO.File.ReadAllLines("proficiencies");
            Grid NonSkillsGrid1 = new Grid();
            int start = 0;
            start = FillDataGrid(start, lines, NonSkillsGrid);

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

                newcb.Name = lines[start].Replace(" ", "") + "comboBox";
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

    }
}
