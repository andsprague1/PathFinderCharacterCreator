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
    /// Interaction logic for addNewAncestryWindow.xaml
    /// </summary>
    public partial class addNewAncestryWindow : Window
    {
        List<Feat> feats = new List<Feat>();
        List<Feat> selectedFeats = new List<Feat>();
        public addNewAncestryWindow()
        {
            InitializeComponent();

            feats = Feat.LoadFeats("Class Feat");
            lstAvailableFeats.ItemsSource = feats;
            lstSelectedFeats.ItemsSource = selectedFeats;

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

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

            if(lstSelectedFeats.SelectedItem is null)
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
