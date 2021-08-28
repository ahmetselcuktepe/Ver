using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ver
{
    public partial class Form1 : Form
    {
        public int dbiVersion;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "MDF Files|*.mdf|LDF Files|*.ldf";
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_yol.Text = openFileDialog1.FileName;
                Kod();
            }
            else { this.Close(); }
        }

        public void Kod()
        {
            using (FileStream fs = File.OpenRead(txt_yol.Text))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    br.ReadBytes(9 * 8192 + 96 + 4);
                    byte[] buffer = br.ReadBytes(2);
                    dbiVersion = buffer[0] + 256 * buffer[1];
                    lbl_vkod.Text = Convert.ToString(dbiVersion);
                    Dongu();
                }
                fs.Close();
            }

        }

        public void Dongu()
        {
            if (lbl_vkod.Text == "904")
            { MessageBox.Show("Versiyon: MSSQL Server 2019 CTP 3.2 / RC 1 / RC 1.1", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "902")
            { MessageBox.Show("Versiyon: MSSQL Server 2019 CTP 3.0/3.1", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "897")
            { MessageBox.Show("Versiyon: MSSQL Server 2019 CTP 2.4/2.5", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "896")
            { MessageBox.Show("Versiyon: MSSQL Server 2019 CTP 2.2", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "895")
            { MessageBox.Show("Versiyon: MSSQL Server 2019 CTP 2.0", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "868" || lbl_vkod.Text == "869")
            { MessageBox.Show("Versiyon: MSSQL 2017", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "852")
            { MessageBox.Show("Versiyon: MSSQL 2016", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "782")
            { MessageBox.Show("Versiyon: MSSQL 2014", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "706")
            { MessageBox.Show("Versiyon: MSSQL 2012", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "684")
            { MessageBox.Show("Versiyon: MSSQL 2012 CTP", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "660" || lbl_vkod.Text == "661")
            { MessageBox.Show("Versiyon: MSSQL 2008 R2", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "665")
            { MessageBox.Show("Versiyon: MSSQL 2008", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "612")
            { MessageBox.Show("Versiyon: MSSQL 2005", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            if (lbl_vkod.Text == "539")
            { MessageBox.Show("Versiyon: MSSQL 2000", "MDF Versiyon Tespit Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }
            this.Close();


        }
    }
}
