using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EARL_Program
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            String imgName = "CHANGE THIS.GIF";
            String imgPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.ToString()) + imgName;

            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body>");
            sb.Append("<img src = \"" + imgPath + "\">");
            sb.Append("</body></html>");

            webBrowser1.DocumentText = sb.ToString();
        }
    }
}
