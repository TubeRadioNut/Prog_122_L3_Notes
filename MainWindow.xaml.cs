//Charles Milender
//4-10-2024
//CSI 122
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122_L3_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }//MainWindow

        /// <summary>
        /// Test method
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="word1"></param>
        /// <returns>returns a string</returns>
        public string TestMethod(int number1, string word1)
        {
            return "";
        }

        private void btnDisplayInformation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Steps
                //1. creates string variable for first and last name
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                //int.Parse(firstName);
                //2. Concatenate them together to form a full name
                // string interpolation
                string fullName = $"{firstName} {lastName}";
                //3. Display that information to our label
                lblDisplayFullName.Content = fullName;

                //4. display to the rich text box
                runDisplay.Text = fullName;
                
                //x- Add a new Rich Text Box for getting an address

                //x- Add a label for the Rich Text box

                // -Properly name the "Run" tag

                // Write the code to grab the text from RTB
                string address = runHomeInfo.Text;

                // Display it to our original runDisplay
                runDisplay.Text += "\n\n";
                //append the address
                runDisplay.Text += address;

            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.ToString());
            }
            //catch(DivideByZeroException dvz){ MessageBox.Show("You cannot divide by zero");
            
        }
    }//Class
}//Namespace