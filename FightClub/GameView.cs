using System;
using System.Linq;
using System.Windows.Forms;

namespace FightClub
{
    public partial class GameView : Form
    {
        public Presenter Presenter { get; set; }

        public GameView()
        {
            InitializeComponent();
        }
        public void setBindings(BindingSource source) {
            ComputerHPLabel.DataBindings.Add("Text", source, "Session.ComputerPlayer.HP");
            ComputerName.DataBindings.Add("Text", source, "Session.ComputerPlayer.Name");
            ComputerHPBar.DataBindings.Add("Maximum", source, "Session.ComputerPlayer.MaxHP");
            ComputerHPBar.DataBindings.Add("Value", source, "Session.ComputerPlayer.HP");

            HumanHPLabel.DataBindings.Add("Text", source, "Session.HumanPlayer.HP");
            HumanName.DataBindings.Add("Text", source, "Session.HumanPlayer.Name");
            HumanHPBar.DataBindings.Add("Maximum", source, "Session.HumanPlayer.MaxHP");
            HumanHPBar.DataBindings.Add("Value", source, "Session.HumanPlayer.HP");

            RoundLabel.DataBindings.Add("Text", source, "Session.Round");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HeadBtn.Tag = BodyPart.Head;
            LegsBtn.Tag = BodyPart.Legs;
            BodyBtn.Tag = BodyPart.Body;
        }
        private Player createPlayer() {
            Player p = null;
            using (var playerForm = new CreatePlayerForm())
            {
                var result = playerForm.ShowDialog();
                if (result == DialogResult.OK)
                    p = new Player(playerForm.playerName, playerForm.HP);
                else
                    throw new Exception();
            }
            return p;
        }
        public void setNextAction() {
            if (Presenter.Session.State == GameState.HumanAttack)
                GameBtn.Text = "Attack!";
            else if (Presenter.Session.State == GameState.ComputerAttack)
                GameBtn.Text = "Block!";
        }
        public void updateLog() {
            LogBox.AppendText(Presenter.Logger.LastLog() + '\n');
        }
        public void endGame() {
            String winner = (Presenter.Session.State == GameState.HumanLost) ? Presenter.Session.ComputerPlayer.Name : Presenter.Session.HumanPlayer.Name;
            MessageBox.Show(String.Format("The winner of the match is {0}. Congratulations!",winner));
            Presenter.Logger.WriteToFile("Log.txt");
            Application.Exit();
        }
        private void startGame() {
            initPresenter();
            setGameComponents();
        }
        private void setGameComponents() {
            partBox.Enabled = true;
            computerBox.Enabled = true;
            humanBox.Enabled = true;
            HeadBtn.Checked = true;
            RoundLabel.Visible = true;
            RoundLabel2.Visible = true;
        } 
        private void initPresenter() {
            Player humanPlayer = createPlayer();
            Player computerPlayer = createPlayer();
            new Presenter(humanPlayer, computerPlayer, this);
        }
        private void GameBtn_Click(object sender, EventArgs e)
        {
            if (Presenter == null)
                startGame();
            else {
                Presenter.Action((BodyPart)partBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag);
                if (Presenter.Session.State == GameState.HumanLost || Presenter.Session.State == GameState.ComputerLost)
                    endGame();
            }
               
        }
    }
}
