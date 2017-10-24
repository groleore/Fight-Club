using System;
using System.Windows.Forms;

namespace FightClub
{
    public partial class CreatePlayerForm : Form
    {
        public string playerName { get; set; }
        public short HP { get; set; }
        public CreatePlayerForm()
        {
            InitializeComponent();
        }

        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            HPBox.Text = HPBar.Value.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Length >= 3)
                this.playerName = NameBox.Text;
            else {
                MessageBox.Show("Name must be longer than 2 characters");
                return;
            }
            HP = short.Parse(HPBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void HPBar_Scroll(object sender, EventArgs e)
        {
            HPBox.Text = HPBar.Value.ToString();
        }
    }
}
