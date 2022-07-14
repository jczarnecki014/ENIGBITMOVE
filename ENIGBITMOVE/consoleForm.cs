using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENIGBITMOVE
{
    public partial class consoleForm : Form
    {
        private static Form previousForm;
        public consoleForm(Form menuForm)
        {
            InitializeComponent();
            EnigConsole.SetPanels(ConsoleComandPanel, ConsoleInfoPanel);
            previousForm = menuForm;
        }

        private void consoleForm_Shown(object sender, EventArgs e)
        {
            main.runProgram(this,previousForm);
        }

        /*private void CONSOLE_Load(object sender, EventArgs e)
        {
            EnigConsole.SetPanels(ConsoleComandPanel, ConsoleInfoPanel);
            main.runProgram();
        }*/
    }
}
