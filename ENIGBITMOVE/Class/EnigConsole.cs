using ENIGBITMOVE;


    class EnigConsole
    {
        private static List <string>AllDisplayMessage = new List<string>();
        private static Panel CommandPanel;
        private static Panel InfoPanel;
        private static int LastLabelCMDPanelYpoint = 0;
        private static Color FontColor { set; get;}

        public static void SetPanels(Panel cmdPanel, Panel infPanel)
        {
              CommandPanel = cmdPanel;
              InfoPanel = infPanel;
              FontColor = Color.White;
        }
        private static Label CreateMessageLabel(string message)
        { 
            Label newMessage = new Label();
            newMessage.Text = message;
            newMessage.Font = new Font("Arial",8);
            newMessage.ForeColor = FontColor;
            newMessage.Width = 533;
            newMessage.Location = new Point(0, LastLabelCMDPanelYpoint);
            LastLabelCMDPanelYpoint+=20;
            return newMessage;
        }
        private static void AddMessageToCmdPanel(Label message)
        {
            CommandPanel.Controls.Add(message);

        }
        private static void AddMessageToInfoPanel(Label message)
        {
            //do napisania
        }
        public static void WriteLine(string message)
        {
            Label readyMessage = CreateMessageLabel(message);
            AddMessageToCmdPanel(readyMessage);
        }
        public static void SetFontColor(Color col)
        {
            FontColor = col;
        }
        public static void ClearConsole()
        {
            CommandPanel.Controls.Clear();
            InfoPanel.Controls.Clear();
            LastLabelCMDPanelYpoint=0;
        }
    }

