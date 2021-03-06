﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FormCRM : Form
    {
        public FormCRM()
        {
            InitializeComponent();
        }

        private void buttonSelectOldModule_Click(object sender, EventArgs e)
        {
            SelectOldModulePath();
        }

        private void SelectOldModulePath()
        {
            folderBrowserDialog1.Description = "コピー元のRUNフォルダを指定してください。";
            var ret = folderBrowserDialog1.ShowDialog();

            if (ret == DialogResult.OK)
            {
                textBoxOldModule.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FormCRM_Load(object sender, EventArgs e)
        {
            SelectOldModulePath();

        }
    }
}
