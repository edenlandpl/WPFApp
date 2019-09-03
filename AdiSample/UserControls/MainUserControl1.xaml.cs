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

namespace AdiSample
{
    /// <summary>
    /// Interaction logic for MainUserControl1.xaml
    /// </summary>
    public partial class MainUserControl1 : UserControl
    {
        public MainUserControl1()
        {
            InitializeComponent();
        }

        private void ZnajdzTekst(object sender, RoutedEventArgs e)
        {
            string tekst = TextBoxOne.Text;
            var positionFindingString = new System.Text.StringBuilder();
            int pozycja, start = 0;
            int lengthStringSecond = TextBoxTwo.Text.Length;

            //W pętli while musi być wyrażenie logiczne. I tak tu jest. W pętli while, że można dokonać przypisania w wyrażeniu logicznym, ale operacja
            //ta musi być ujęta w nawiasach okrągłych.Najpierw wywołana jest tu metoda IndexOf(), jej
            //rezultat jest przypisany do zmiennej pozycja, a dopiero później zmienna pozycja jest
            //porównywana z zerem(czy jest większa lub równa 0).

            while ((pozycja = tekst.IndexOf(TextBoxTwo.Text, start)) >= 0)  
            {
                positionFindingString.Append(pozycja.ToString() + ", ");
                start = pozycja + lengthStringSecond; // dalsze szukanie znaki dalej, zależne od długości String
            }
            wynik.Text = positionFindingString.ToString();  // wynik umieszczany w textBox wynik
        }
    }
}
