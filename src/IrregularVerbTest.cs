using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrregularVerbs.src
{
    public partial class IrregularVerbTest : UserControl
    {
        public IrregularVerb verb {get; set;}
        public uint word_count { get; set; }
        private List<TextBox> v1;
        private List<TextBox> v2;
        private List<TextBox> v3;
        private List<TextBox> tr;

        public IrregularVerbTest(uint count)
        {
            InitializeComponent();
            word_count = count;
            int v_pos = 50;
            int pos_step = 25;
            int x_v1_pos = 25;
            int x_v2_pos = 150;
            int x_v3_pos = 275;
            int x_tr_pos = 400;


            v1 = new List<TextBox>();
            v2 = new List<TextBox>();
            v3 = new List<TextBox>();
            tr = new List<TextBox>();
            for (int i = 0; i < word_count; i++)
            {
                TextBox v_1 = new TextBox();
                v_1.Location = new Point(x_v1_pos, v_pos + i*pos_step);
                this.Controls.Add(v_1);
                v1.Add(v_1);

                TextBox v_2 = new TextBox();
                v_2.Location = new Point(x_v2_pos, v_pos + i * pos_step);
                this.Controls.Add(v_2);
                v2.Add(v_2);

                TextBox v_3 = new TextBox();
                v_3.Location = new Point(x_v3_pos, v_pos + i * pos_step);
                this.Controls.Add(v_3);
                v3.Add(v_3);

                TextBox v_tr = new TextBox();
                v_tr.Location = new Point(x_tr_pos, v_pos + i * pos_step);
                this.Controls.Add(v_tr);
                tr.Add(v_tr);
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
 	         base.OnPaint(e);

        }
    }
}
