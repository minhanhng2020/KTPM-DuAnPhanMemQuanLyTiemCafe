using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DAO;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public partial class fTableServices : Form
    {
        TableBUS tableBUS = new TableBUS();

        public fTableServices()
        {
            InitializeComponent();
        }

        private void fTableServices_Load(object sender, EventArgs e)
        {
            //dataGridView.DataSource = tableBUS.Get();
            DataTable tables = tableBUS.Get();

            foreach (DataRow table in tables.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(150, 150);
                btn.Text = table[1].ToString() + Environment.NewLine + Environment.NewLine + table[2].ToString();
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.TextImageRelation = TextImageRelation.TextAboveImage;

                switch (table[2].ToString())
                {
                    case "Trống":
                        btn.BackgroundImage = DuAnPhanMemQuanLyTiemCafe.Properties.Resources.coffeeBlack;
                        break;
                    default:
                        btn.BackgroundImage = DuAnPhanMemQuanLyTiemCafe.Properties.Resources.coffeeColor;
                        break;
                }

                flpTableStatus.Controls.Add(btn);
            }
        }
    }
}
