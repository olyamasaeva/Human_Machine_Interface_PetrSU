using cfapi.Methods;
using cfapi.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hmi_proj
{
    public partial class Trains : Form
    {
        private List<string> lines;
        
        public Trains()
        {
            InitializeComponent();
        }
        void AddTask(String a)
        {
            if (a != "")
            {
                String[] words = a.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                object[] props = { words[0],words[1], words[2] };
                PracticeList.Rows.Add(props);
            }
        }
        void update_PractiseTable()
        {
            PracticeList.Rows.Clear();
            foreach (var it in Program.myTasks)
                AddTask(it);
        }
        private void Trains_Load(object sender, EventArgs e)
        {
      
            Program.myTasks = new HashSet<String>();
            lines = new List<string>();
            File.AppendAllText("history.txt", "");
            foreach (var it in File.ReadAllLines("history.txt"))
                lines.Add(it);
            foreach (var it in lines)
                TypedHandle.AutoCompleteCustomSource.Add(it);
            File.AppendAllText("Practice.txt", "");
            foreach (var it in File.ReadAllLines("Practice.txt"))
                Program.myTasks.Add(it);
            update_PractiseTable();
        }

        private void TypedHandle_TextChanged(object sender, EventArgs e)
        {

        }

        private Dictionary<int, Party> teams;
        private void TrainsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (-1 < e.RowIndex && e.RowIndex < TrainsTable.RowCount)
            {
                int a = System.Convert.ToInt32(TrainsTable.Rows[e.RowIndex].Cells[1].Value.ToString());
                OneContestInfo t = new OneContestInfo(a, teams[a]);
                t.Show();
            }
        }
        private void refreshTable()
        {
            label1.Visible = false;
            //button1.Text = "Идет поиск...";
            Cursor = Cursors.WaitCursor;
            button1.Refresh();
            TrainsTable.Rows.Clear();
            string handle = TypedHandle.Text;
            UserStatusRequest request = new UserStatusRequest();
            List<Submission> list = request.GetUserSubmissions(handle);

            Dictionary<int, Tuple<List<string>, int, int>> contests = new Dictionary<int, Tuple<List<string>, int, int>>();
            teams = new Dictionary<int, Party>();

            if (list == null)
            {

                Cursor = Cursors.Default;
                label1.Visible = true;
                return;
            }
            foreach (Submission it in list)
            {
                if (!contests.ContainsKey(it.ContestId))
                {
                    contests.Add(it.ContestId, Tuple.Create<List<string>, int, int>(new List<string>(), it.CreationTime, 0));
                    teams.Add(it.ContestId, it.Author);
                }
                if (it.Author.TeamName != null)
                    teams[it.ContestId] = it.Author;
                if (it.Verdict == SubmissionVerdict.OK) {                 
                    contests[it.ContestId].Item1.Add(it.Problem.Name);
                }
                if (contests[it.ContestId].Item2 > it.CreationTime)
                    contests[it.ContestId] = Tuple.Create<List<string>, int, int>(contests[it.ContestId].Item1, it.CreationTime, contests[it.ContestId].Item3);
                contests[it.ContestId] = Tuple.Create<List<string>, int, int>(contests[it.ContestId].Item1, contests[it.ContestId].Item2, contests[it.ContestId].Item3 + 1);
            }

            foreach (var it in contests)
            {
                object[] props = {new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(it.Value.Item2).ToLocalTime(),
                        it.Key, it.Value.Item1.Count, it.Value.Item3};
                TrainsTable.Rows.Add(props);
            }
            TrainsTable.Sort(TrainsTable.Columns[0], ListSortDirection.Descending);
            button1.Text = "Найти";
            button1.Refresh();
            Cursor = Cursors.Default; ;
            TrainsTable.Focus();

            {
                bool flag = true;
                if (lines != null)
                {
                    foreach (var it in lines)
                        if (it == handle)
                        {
                            flag = false;
                            break;
                        }
                }
                if (flag)
                {
                    File.AppendAllText("history.txt", handle + "\n");
                    lines.Add(handle);
                    TypedHandle.AutoCompleteCustomSource.Add(handle);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void TypedHandle_Click(object sender, EventArgs e)
        {
        }

        private void button1_PressKey(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                refreshTable();
        }

        private void TrainsTable_KeyDown(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_PractiseTable();
        }

        private void Trains_FormClosing(object sender, FormClosingEventArgs e)
        {

            using (StreamWriter writer = new StreamWriter("Practice.txt", false, Encoding.UTF8, 1))
            {
                writer.Write("");
            }
            foreach (var it in Program.myTasks)
            {
                if (it.Length > 0)
                {
                    using (StreamWriter writer = new StreamWriter("Practice.txt", true, Encoding.UTF8, it.Length))
                    {
                        writer.Write(it + "\n");
                    }
                }
            }
        }

        private void PracticeList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= PracticeList.RowCount - 1)
                return;
            System.Diagnostics.Process.Start("https://codeforces.com/gym/" + PracticeList.Rows[e.RowIndex].Cells[2].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void typedHandle_Enter(object sender, EventArgs e)
        {
            if (TypedHandle.Text == "Введите хендл пользователя")
            {
                TypedHandle.Text = "";
            }
            TypedHandle.ForeColor = Color.Black;
        }

        private void typedHandle_leave(object sender, EventArgs e)
        {
            if (TypedHandle.Text == "")
            {
                TypedHandle.ForeColor = Color.Gray;
                TypedHandle.Text = "Введите хендл пользователя";
            }
        }

        private void RemoveSelectedTasks_Click(object sender, EventArgs e)
        {
            int selectedRowCount = PracticeList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    int t = PracticeList.SelectedRows[0].Index;
                    if (t < 0 || t >= PracticeList.RowCount - 1)
                    {
                        PracticeList.Rows[t].Selected = false;
                        continue;
                    }
                    string r = Program.findTask(PracticeList[1, t].Value.ToString());
                    Program.myTasks.Remove(r);
                    PracticeList.Rows.RemoveAt(t);
                }
            }
        }
    }
}
