using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Football_Championship : Form
    {
        public string table;
        
        public Football_Championship()
        {
            InitializeComponent();
        }


        private void Football_Championship_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "championshipDataSet.Match". При необходимости она может быть перемещена или удалена.
            this.matchTableAdapter.Fill(this.championshipDataSet.Match);
            //this.championshipTableAdapter.Fill(this.championshipDataSet.Championship);
            //this.teamTableAdapter.Fill(this.championshipDataSet.Team);
            //this.playerTableAdapter.Fill(this.championshipDataSet.Player);
            //this.ownerTableAdapter.Fill(this.championshipDataSet.Owner);
            //this.coachTableAdapter.Fill(this.championshipDataSet.Coach);
        }
    }
}
