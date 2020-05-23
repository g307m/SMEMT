using RecipeEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeEditor
{
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
            foreach(String key in Localization.languagesjson.Properties().Select(p => p.Name).ToList())
            { // adds values of all keys to the combo
                if(!languageCombo.Items.Contains(Localization.languagesjson[key]))
                    languageCombo.Items.Add(Localization.languagesjson[key]);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = languageCombo.SelectedItem.ToString();
            Settings.Default.Save();
            this.Close();
            Application.Restart();
        }
    }
}
