using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panther.Email.Winform.Controls
{
    public partial class DataGridControl : UserControl
    {

        TableLayoutPanel tableProject = new TableLayoutPanel();
        TableLayoutPanel tableHeader = new TableLayoutPanel();
        public DataGridControl()
        {
            InitializeComponent();
        }

        private void AddHeader()
        {
            tableHeader.RowCount = 1;

            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            //label.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label.Name = "label1";
            label.Text = "抽签顺序";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.BackColor = Color.Transparent;
            label.Margin = new Padding(0);
            tableHeader.Controls.Add(label, 0, 0);

            label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            //label.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label.Name = "label2";
            label.Text = "公司名称";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.BackColor = Color.Transparent;
            label.Margin = new Padding(0);
            tableHeader.Controls.Add(label, 1, 0);

            tableHeader.RowStyles[0].SizeType = SizeType.Absolute;
            tableHeader.RowStyles[0].Height = 23;
            //tableHeader.BackgroundImage = Properties.Resources.title1;
            //tableHeader.BackgroundImageLayout = ImageLayout.Stretch;
            tableHeader.Margin = new System.Windows.Forms.Padding(0);
            tableHeader.Height = 25;
            tableHeader.BackColor = Color.Transparent;
        }


        /// <summary>
        /// 把数据添加到tableLayoutPanel1
        /// </summary>
        /// <param name="entity"></param>
        //private void AddRow(ProjectSupplier entity)
        //{
        //    int RowID = 0;
        //    try
        //    {

        //        tableProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 110F));
        //        tableProject.RowCount = tableProject.RowCount + 1;
        //        RowID = tableProject.RowCount - 1;
        //        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
        //        label.Dock = System.Windows.Forms.DockStyle.Fill;
        //        label.BackColor = Color.Transparent;
        //        label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //        label.Text = entity.SortOrder.ToString();
        //        label.Name = "label1" + _pageSize * _pageIndex + RowID.ToString();
        //        //if (RowID % 2 == 0)
        //        //{
        //        //    label.BackColor = Color.Azure;

        //        //}
        //        label.Margin = new Padding(0);
        //        tableProject.Controls.Add(label, 0, RowID);

        //        System.Windows.Forms.Label link = new System.Windows.Forms.Label();
        //        link.Name = "label" + RowID.ToString();
        //        link.Text = entity.SupplierID.SupplierName;
        //        link.Dock = DockStyle.Fill;
        //        link.BackColor = Color.Transparent;
        //        link.TextAlign = ContentAlignment.MiddleCenter;
        //        //if (RowID % 2 == 0)
        //        //{
        //        //    link.BackColor = Color.Azure;

        //        //}
        //        link.Margin = new Padding(0);
        //        tableProject.Controls.Add(link, 1, RowID);





        //        tableProject.RowStyles[RowID].SizeType = SizeType.Absolute;
        //        tableProject.RowStyles[RowID].Height = 42;


        //        tableProject.Height = tableProject.Height + Convert.ToInt32(tableProject.RowStyles[RowID].Height);
        //        tableProject.BackColor = Color.Transparent;

        //    }
        //    catch (Exception ex)
        //    {
        //        //LogTool.LogToDirDest("", ex.Message, LogType.Error);
        //    }

        //}
    }
}
