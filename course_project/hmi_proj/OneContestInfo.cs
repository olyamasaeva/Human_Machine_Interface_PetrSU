using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using cfapi.Methods;
using cfapi.Objects;

namespace hmi_proj
{
    public partial class OneContestInfo : Form
    {
        int ContestId;
        Party team;
        List<String> handle;

        public OneContestInfo(int a, Party party)
        {
            handle = new List<string>();
            foreach (Member it in party.Members)
            {
                handle.Add(it.Handle);
            }
            ContestId = a;
            InitializeComponent();
            team = party;
            if (party != null)
            {
                if (party.TeamName != null)
                    TeamName.Text = party.TeamName;
                else
                    TeamName.Text = party.Members[0].Handle;
            }
        }
        Standing list;
        private void OneContestInfo_Load(object sender, EventArgs e)
        { 
            ContestStandingsRequest request = new ContestStandingsRequest();
            list = request.GetContestStandings(ContestId, 1 ,10000 , handle, 0, true);
            idBox.Text = ContestId.ToString();
            ContestName.Text = Program.getLocalLine(list.Contest.Name);
            char star = '★';
            for (int i = 0; i < list.Contest.Difficulty; i++)
                Difficulty.Text += star;
            for(int i = 0 ;i < list.Problems.Count;i++)
            {
                ProblemsTable.Rows.Add(list.Problems[i].Index);
            }
            foreach(var it in list.Rows)
            {
                string name;
                if (it.Party.TeamName == null)
                {
                    name = it.Party.Members[0].Handle;
                }
                else
                {
                    name = it.Party.TeamName;
                }
                int cnt = ProblemsTable.Columns.Add("Column" + name, name);
                ProblemsTable.Columns[cnt].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                int cnt_task = 0;
                foreach(var task in it.ProblemsResults)
                {
                    if (task.BestSubmissionTime != 0)
                    {
                        ProblemsTable.Rows[cnt_task].Cells[cnt].Value = "+" + (task.RejectedAttemptsCount > 0 ? task.RejectedAttemptsCount.ToString() : "");
                        ProblemsTable.Rows[cnt_task].Cells[cnt].Style.BackColor = Color.LightGreen;
                    }
                    else if (task.BestSubmissionTime == 0 && task.RejectedAttemptsCount > 0)
                    {
                        ProblemsTable.Rows[cnt_task].Cells[cnt].Style.BackColor = Color.LightSkyBlue;
                        ProblemsTable.Rows[cnt_task].Cells[cnt].Value = "-" + task.RejectedAttemptsCount.ToString();
                    }
                    ProblemsTable.Rows[cnt_task].Cells[cnt].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    ProblemsTable.Rows[cnt_task].Cells[cnt].ReadOnly = true;
                    cnt_task++;
                }
            }
            int tmp = 0;
            foreach(var task in list.Problems)
            {
                if(Program.isTask(task.Index + ". " + task.Name))
                    for (int j = 0; j < ProblemsTable.ColumnCount; j++)
                        ProblemsTable[j, tmp].Style.BackColor = Color.SandyBrown;

                tmp++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        { 
        }
        private void addNewTasks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i + 1 < ProblemsTable.Rows.Count;i++)
                if(ProblemsTable.Rows[i].Selected)
            {
                    // string s = it.ToString();
                    for (int j = 0; j < ProblemsTable.ColumnCount; j++)
                         ProblemsTable[j, i].Style.BackColor = Color.SandyBrown;
                string a = DateTime.Now.ToString();
                Program.myTasks.Add(Program.getLocalLine(a + "|" + list.Problems[i].Index + ". " + list.Problems[i].Name + "|" + list.Contest.Id.ToString() + "\n"));
            }
        }
    }
}
