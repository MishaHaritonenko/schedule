using static System.Windows.Forms.ListViewItem;

namespace schedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void AddEntry(Entry entry)
        {
            var lvi = new ListViewItem();
            lvi.SubItems[0].Text = entry.Day;

            var lvsi = new ListViewSubItem();
            lvsi.Text = entry.Begin.ToString();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewSubItem();
            lvsi.Text = entry.End.ToString();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewSubItem();
            lvsi.Text = entry.Subject;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewSubItem();
            lvsi.Text = entry.Name;
            lvi.SubItems.Add(lvsi);

            listView1.Items.Add(lvi);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var add = new AddEntryCommand(listView1, button1, addToolStripMenuItem);
            var delete = new DeleteEntryCommand(listView1, bDelete, deleteToolStripMenuItem);
        }
    }
}