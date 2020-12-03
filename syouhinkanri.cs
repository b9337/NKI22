using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class syouhinnkannri : Form
    {
        public syouhinnkannri()
        {
            InitializeComponent();
        }

        private void syouhinnkannri_Load(object sender, EventArgs e)
        {

        }

        private void btn_Regist_Pro_Click(object sender, EventArgs e)
        {
            try
            {
                M_Product pr = new M_Product()
                {
                    MaID = int.Parse(textB_MakerID_Pro.Text),
                    PrName = textB_ProName_Pro.Text,
                    Price = int.Parse(textB_Pri_Pro.Text),
                    PrJCode = textB_JAN_Pro.Text,
                    PrSafetyStock = int.Parse(textB_SSQ_Pro.Text),
                    ScID = int.Parse(textB_SCID_Pro.Text),
                    PrModelNumber = int.Parse(textB_Mnumber_Pro.Text),
                    PrColor = textB_Color_Pro.Text,
                    PrReleaseDate = dtp_RelDate_Pro.Value,
                    PrFlag = checkB_Del_Pro.Checked ? 1 : 0,
                };
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_Products.Add(pr);
                context.SaveChanges();
                context.Dispose();

                MessageBox.Show("登録が完了しました。", "登録完了",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
