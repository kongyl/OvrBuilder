using System.Windows.Forms;

namespace OvrBuilder
{
    public partial class FormProgress : Form
    {
        public FormProgress()
        {
            InitializeComponent();
        }

        public void SetProgressAll(string newLabel, int newValue)
        {
            labelAll.Text = newLabel;
            progressBarAll.Value = newValue;
            Refresh();
        }

        public void SetLabelFile(string newLabel)
        {
            labelFile.Text = newLabel;
            Refresh();
        }

        public void SetProgressBarFile(int newValue)
        {
            progressBarFile.Value = newValue;
            Refresh();
        }
    }
}
