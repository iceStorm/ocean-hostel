using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using DTO;

namespace GUI.ChildrenForms.QuanLyThietBi.PhanBoThietBi
{
    public partial class fPhanBoThietBi : DevExpress.XtraEditors.XtraForm
    {
        public fPhanBoThietBi()
        {
            InitializeComponent();
        }

        private void fPhanBoThietBi_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            string[] listKhu = BLL_KHU.LayDanhSachTenKhu();
            DTO_KHU khu = new DTO_KHU();

            /*
            int count = 0;
            foreach (string str in listKhu)
            {
                this.treeViewKhuTang.Nodes.Add(str);

                khu.TenKhu = str;
                string[] listTang = BLL_TANG.LayDanhSachTang_TheoTenKhu(khu);

                List<TreeNode> childrenNodes = new List<TreeNode>();
                foreach (string tenTang in listTang)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = tenTang;
                    childrenNodes.Add(tn);
                }

                this.treeViewKhuTang.Nodes[count++].Nodes.AddRange(childrenNodes.ToArray());
            }*/
        }

    }
}