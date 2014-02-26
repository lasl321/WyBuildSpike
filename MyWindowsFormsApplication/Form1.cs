using System.Windows.Forms;

namespace MyWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            versionLabel.Text = Application.ProductVersion;
        }
    }
}