using OSGeo.GDAL;
using System;
using System.IO;
using System.Windows.Forms;

namespace OvrBuilder
{
    public partial class FormMain : Form
    {
        private FormProgress formProgress;

        public object GeoUtils { get; private set; }

        public FormMain()
        {
            InitializeComponent();
            formProgress = new FormProgress();

            Gdal.AllRegister();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            textBoxIn.Text = "";
            if (folderBrowserDialogIn.ShowDialog() == DialogResult.OK)
            {
                textBoxIn.Text = folderBrowserDialogIn.SelectedPath;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string path = textBoxIn.Text;
            if (path == null || path.Trim().Equals(""))
            {
                MessageBox.Show("请选择文件夹");
                return;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles("*.tif");
            int fileNum = files.Length;
            if (fileNum == 0)
            {
                MessageBox.Show("文件夹内没有tif文件");
                return;
            }

            int n = 0;
            formProgress.Show();
            formProgress.SetProgressAll(string.Format("已完成：0/{0}", fileNum), 0);
            foreach (FileInfo file in files)
            {
                formProgress.SetLabelFile(string.Format("处理文件：{0}", file.Name));
                Dataset ds = Gdal.Open(file.FullName, Access.GA_ReadOnly);
                buildOverviews(ds);
                n++;
                formProgress.SetProgressAll(string.Format("已完成：{0}/{1}", n, fileNum), n * 100 / fileNum);
            }

            MessageBox.Show("影像金字塔生成完成");
            Dispose();
        }

        private int buildOverviews(Dataset ds)
        {
            int size = ds.RasterXSize;
            if (size < ds.RasterYSize)
            {
                size = ds.RasterYSize;
            }
            int n = (int)Math.Ceiling(Math.Log2(size / 256.0));
            int[] levels = new int[n];
            for (int i = 0; i < n; i++)
            {
                levels[i] = (int)Math.Pow(2.0, i + 1);
            }
            return ds.BuildOverviews("nearest", levels, progressFunc, null);
        }

        private int progressFunc(double complete, IntPtr message, IntPtr data)
        {
            int newValue = (int)(complete * 100);
            formProgress.SetProgressBarFile(newValue);

            return 1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
