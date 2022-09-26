namespace schedule
{
    internal class AddEntryCommand: BaseCommand
    {
        public AddEntryCommand(ListView lv, Button button, ToolStripMenuItem addToolStripMenuItem) : base(lv, button, addToolStripMenuItem)
        {
        }

        protected override void Execute()
        {
            AddScheduleEntryForm form = new AddScheduleEntryForm();
            DialogResult r = form.ShowDialog();
            if (r != DialogResult.OK)
            {
                return;
            }
            Entry entry = form.GetScheduleEntry();

            mainForm.AddEntry(entry);
        }
    }
}