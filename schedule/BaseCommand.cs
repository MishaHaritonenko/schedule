namespace schedule
{
    internal abstract class BaseCommand
    {
        protected readonly  Form1 mainForm;
        private readonly Button button;
        private readonly ToolStripMenuItem menuItem;
        protected readonly ListView lv;

        public BaseCommand(ListView lv, Button button, ToolStripMenuItem menuItem)
        {
            mainForm = (Form1)button.Parent;
            button.Click += Button_Click;
            menuItem.Click += Button_Click;
            this.button = button;
            this.menuItem = menuItem;
            this.lv = lv;
        }



        abstract protected void Execute();

        void Button_Click(object? sender, EventArgs e)
        {
            Execute();
        }

        public void Enable()
        {
            button.Enabled = true;
            menuItem.Enabled = true;
        }
        public void Disable()
        {
            button.Enabled = false;
            menuItem.Enabled = false;
        }

    }
}