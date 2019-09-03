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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdiSample.UserControls.UserControl03
{
    /// <summary>
    /// Logika interakcji dla klasy UC03_06_WindowInterface.xaml
    /// </summary>
    /// 

    public partial class UC03_06_WindowInterface : UserControl
    {

        // Puste kolumny dla warstw 0 i 1:
        ColumnDefinition column1CloneForLayer0;
        ColumnDefinition column2CloneForLayer0;
        ColumnDefinition column2CloneForLayer1;

        public UC03_06_WindowInterface()
        {
            InitializeComponent();

            // Inicjowanie pustych kolumn uĪywanych przy dokowaniu:
            column1CloneForLayer0 = new ColumnDefinition();
            column1CloneForLayer0.SharedSizeGroup = "column1";
            column2CloneForLayer0 = new ColumnDefinition();
            column2CloneForLayer0.SharedSizeGroup = "column2";
            column2CloneForLayer1 = new ColumnDefinition();
            column2CloneForLayer1.SharedSizeGroup = "column2";
        }
        // Przeáączenie pomiĊdzy stanem zadokowanym i niezadokowanym (panel 1)
        public void pane1Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Collapsed)
                UndockPane(1);
            else
                DockPane(1);
        }
        // Przeáączenie pomiĊdzy stanem zadokowanym i niezadokowanym (panel 2)
        public void pane2Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane2Button.Visibility == Visibility.Collapsed)
                UndockPane(2);
            else
                DockPane(2);
        }
        // Pokazanie panelu 1 przy umieszczeniu myszy nad przyciskiem
        public void pane1Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            layer1.Visibility = Visibility.Visible;
            // Korekta kolejnoĞci w osi Z, aby panel byá na szczycie:
            parentGrid.Children.Remove(layer1);
            parentGrid.Children.Add(layer1);
            // Upewnienie siĊ, Īe panel 2 jest ukryty, gdy jest niezadokowany
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }
        // Pokazanie panelu 2 przy umieszczeniu myszy nad przyciskiem
        public void pane2Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            layer2.Visibility = Visibility.Visible;
            // Korekta kolejnoĞci w osi Z, aby panel byá na szczycie:
            Grid.SetZIndex(layer1, 1); ;
            Grid.SetZIndex(layer1, 0);
            // Upewnienie siĊ, Īe panel 1 jest ukryty, gdy jest niezadokowany
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
        }
        // Ukrycie niezadokowanych paneli, gdy mysz jest nad warstwą 0
        public void layer0_MouseEnter(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }
        // Ukrycie pozostaáych niezadokowanych paneli, gdy mysz jest nad panelem 1
        public void pane1_MouseEnter(object sender, RoutedEventArgs e)
        {
            // Upewniamy siĊ, Īe pozostaáe panele są ukryte, jeĪeli nie są zadokowane
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }
        // Ukrycie pozostaáych niezadokowanych paneli, gdy mysz jest nad panelem 2
        public void pane2_MouseEnter(object sender, RoutedEventArgs e)
        {
            // Upewniamy siĊ, Īe pozostaáe panele są ukryte, jeĪeli nie są zadokowane
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
        }
        // Dokowanie panelu, co ukrywa odpowiedni przycisk panelu
        public void DockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                pane1Button.Visibility = Visibility.Collapsed;
                pane1PinImage.Source = new BitmapImage(new Uri("pin.gif", UriKind.Relative));
                // Dodanie do warstwy 0 sklonowanej kolumny po lewej stronie:
                layer0.ColumnDefinitions.Add(column1CloneForLayer0);
                // Dodanie do warstwy 1 sklonowanej kolumny, ale tylko gdy panel 2 jest zadokowany:
                if (pane2Button.Visibility == Visibility.Collapsed)
                    layer1.ColumnDefinitions.Add(column2CloneForLayer1);
            }
            else if (paneNumber == 2)
            {
                pane2Button.Visibility = Visibility.Collapsed;
                pane2PinImage.Source = new BitmapImage(new Uri("pin.gif", UriKind.Relative));
                // Dodanie do warstwy 0 sklonowanej kolumny:
                layer0.ColumnDefinitions.Add(column2CloneForLayer0);
                // Dodanie do warstwy 1 sklonowanej kolumny, ale tylko gdy panel 1 jest zadokowany:
                if (pane1Button.Visibility == Visibility.Collapsed)
                    layer1.ColumnDefinitions.Add(column2CloneForLayer1);
            }
        }
        // UsuniĊcie dokowania panelu, co powoduje pokazanie odpowiedniego przycisku
        public void UndockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                layer1.Visibility = Visibility.Collapsed;
                pane1Button.Visibility = Visibility.Visible;
                pane1PinImage.Source = new BitmapImage
                (new Uri("pinHorizontal.gif", UriKind.Relative));
                // UsuniĊcie sklonowanych kolumn z warstw 0 i 1:
                layer0.ColumnDefinitions.Remove(column1CloneForLayer0);
                // Nie musi istnieü, ale Remove ignoruje nieprawidáowe kolumny:
                layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
            else if (paneNumber == 2)
            {
                layer2.Visibility = Visibility.Collapsed;
                pane2Button.Visibility = Visibility.Visible;
                pane2PinImage.Source = new BitmapImage
                (new Uri("pinHorizontal.gif", UriKind.Relative));
                // UsuniĊcie sklonowanych kolumn z warstw 0 i 1:
                layer0.ColumnDefinitions.Remove(column2CloneForLayer0);
                // Nie musi istnieü, ale Remove ignoruje nieprawidáowe kolumny:
                layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
        }
    }
}
