using ColdSort.Core.Interfaces.Controllers;
using System;
using System.Windows.Forms;

namespace ColdSort.Views
{
    public partial class MainView : Form
    {
        private IMainController _mainController;

        public string OriginalLocation
        {
            get
            {
                return this.txtOriginalLocation.Text;
            }
            set
            {
                this.txtOriginalLocation.Text = value;
            }
        }

        public string DestinationLocation
        {
            get
            {
                return this.txtDestinationLocation.Text;
            }
            set
            {
                this.txtDestinationLocation.Text = value;
            }
        }

        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(IMainController mainController)
        {
            _mainController = mainController;
        }

        public void ErrorBox(string message)
        {
            MessageBox.Show("Error", message);
        }

        private void btnOriginalLocationBrowse_Click(object sender, EventArgs e)
        {
            string path = _mainController.SelectFolder(OriginalLocation);
            txtOriginalLocation.Text = path;
        }

        private void btnDestinationLocationBrowse_Click(object sender, EventArgs e)
        {
            string path = _mainController.SelectFolder(DestinationLocation);
            txtOriginalLocation.Text = path;
        }

        private void btnCreateSchema_Click(object sender, EventArgs e)
        {
            _mainController.CreateSchema();
        }

        private void btnEditSchema_Click(object sender, EventArgs e)
        {
            _mainController.EditSchema();

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            _mainController.SortWithoutDiagnostics();
        }
    }
}
