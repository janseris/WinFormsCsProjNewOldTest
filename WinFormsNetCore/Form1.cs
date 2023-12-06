using WinFormsNetFrameworkClassLibraryNewProjectStructure;

using WinFormsNetFrameworkClassLibraryOldProjectStructure;

namespace WinFormsNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var newCsprojUC = new NewProjectStructureUC();
            newCsprojUC.Dock = DockStyle.Top;
            var oldCsprojUC = new OldProjectStructureUC();
            oldCsprojUC.Dock = DockStyle.Bottom;
            Controls.Add(newCsprojUC);
            Controls.Add(oldCsprojUC);
        }
    }
}
