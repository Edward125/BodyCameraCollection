using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BodyCameraCollection
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        #region 防止屏幕闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadUI();


        }


        private void LoadUI()
        {
            this.WindowState = FormWindowState.Maximized;
            p.CheckFolder();
            p.CreateIni();
            p.ReadIni();
        }


        private void tlpBody_Paint(object sender, PaintEventArgs e)
        {
            Pen pp = new Pen(Color.White);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X - 1, e.ClipRectangle.Y - 1, e.ClipRectangle.X + e.ClipRectangle.Width - 0, e.ClipRectangle.Y + e.ClipRectangle.Height - 0);

        }

        private void tlpBody_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Pen pp = new Pen(Color.White);
            e.Graphics.DrawRectangle(pp, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Y + e.CellBounds.Height - 1);

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Form  f = new frmCheckPwd();
           DialogResult dr = f.ShowDialog();

           if ( p.CheckPwd)
           {
              // MessageBox.Show("密码正确");
               Environment.Exit(0);
           }
        }


        private void gDrawInfo(PaintEventArgs e,string str)
        {

            Graphics g = e.Graphics; //创建画板,这里的画板是由Form提供的. 
            //
            System.Drawing.Font font = new System.Drawing.Font("黑体", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(str, font, brush, 100F, 25F);


        }

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {
            gDrawInfo(e, p.AppTitle);
        }

        private void picSet_Click(object sender, EventArgs e)
        {
         
        }

    }
}
