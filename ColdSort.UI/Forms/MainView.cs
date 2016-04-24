using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Views;
using System;
using System.Windows.Forms;

namespace ColdSort.UI.Forms
{
    public partial class MainView : Form, IMainView
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
    }
}
