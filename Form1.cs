using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IrregularVerbs.src;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace IrregularVerbs
{
    public partial class Form1 : Form
    {
        private IrregularVerbTest tester { get; set; }
        private DataGridView dictionary { get; set; }
        private List<IrregularVerb> verbs { get; set; }
        public Form1()
        {
            InitializeComponent();

            verbs = new List<IrregularVerb> { };
            DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(List<IrregularVerb>));
            using (FileStream fs = new FileStream("dictionary.json", FileMode.OpenOrCreate))
            {
                verbs = (List<IrregularVerb>)jsonformatter.ReadObject(fs);
            }

            tester = new IrregularVerbTest(10);
            tester.Location = new Point(50, 50);
            tester.Size = new Size(500, 500);
            tabControl1.TabPages[0].Controls.Add(tester);

            dictionary = new DataGridView();
            dictionary.Size = new Size(500, 500);
            tabControl1.TabPages[1].Controls.Add(dictionary);
            dictionary.ColumnCount = 6;
            foreach (var verb in verbs)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dictionary);
                row.Cells[0].Value = verb.V1;
                row.Cells[1].Value = verb.V2;
                row.Cells[2].Value = verb.V3;
                row.Cells[3].Value = verb.Tr;
                row.Cells[4].Value = verb.Raiting;
                row.Cells[5].Value = verb.Sample;
                dictionary.Rows.Add(row);
            }
            //this.Controls.Add(tester);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(List<IrregularVerb>));
            using (FileStream fs = new FileStream("dictionary.json", FileMode.OpenOrCreate))
            {
                fs.SetLength(0);
                jsonformatter.WriteObject(fs, verbs);
            }
        }
    }
}
