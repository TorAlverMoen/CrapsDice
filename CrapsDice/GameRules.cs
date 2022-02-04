using System;
using System.Reflection;
using System.Windows.Forms;

namespace CrapsDice
{
    partial class GameRules : Form
    {
        public GameRules()
        {
            InitializeComponent();
            this.textBox.Text = "During the first turn (with no points established) the following rules apply:\n" +
                "- If the come-out roll is 7 or 11, the player wins.\n" +
                "- If the come-out roll is 2, 3 or 12, the player loses.\n" +
                "- If the roll is any other value, it establishes the value as points.\n\n" +
                "After the first turn (with established points), the rules are:\n" +
                "- If, with a point established, that point is rolled again before a 7, the player wins.\n" +
                "- If, with a point established, a 7 is rolled before the point is rolled again, the player loses.\n";
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
