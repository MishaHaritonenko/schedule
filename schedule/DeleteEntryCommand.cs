namespace schedule
{
    internal class DeleteEntryCommand: BaseCommand
    {
        public DeleteEntryCommand(ListView lv, Button button, ToolStripMenuItem deleteToolStripMenuItem) : base(lv, button, deleteToolStripMenuItem)
        {
            lv.SelectedIndexChanged += Lv_SelectedIndexChanged;
            Lv_SelectedIndexChanged(null, null);
        }

        private void Lv_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                Disable();
            }
            else
            {
                Enable();
            }
        }

        protected override void Execute()
        {
            lv.Items.Remove(lv.SelectedItems[0]);


        }
    }
}