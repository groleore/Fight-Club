using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FightClub
{
    public class Presenter: INotifyPropertyChanged
    {
        public GameSession Session { get; }
        private GameView gameView;
        public Logger Logger;

        public Presenter(Player human, Player computer, GameView gameView) {
            Session = new GameSession(human, computer);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this;
            this.gameView = gameView;
            gameView.Presenter = this;
            gameView.setBindings(bindingSource);
            Logger = new Logger();
            Logger.AddLog += gameView.updateLog;
            Logger.Add(String.Format("Start of the new match!! {0}", DateTime.Now));
            subscribePlayersToEvents();
            gameView.setNextAction();
        }
        public void Action (BodyPart part) {
            Session.Action(part);
            NotifyPropertyChanged();
        }
        private void onBlock(Object sender, EventArgs e)
        {
            if (!(e is PlayerEventArgs))
                throw new ArgumentException();
            PlayerEventArgs playerArgs = (PlayerEventArgs)e;
            Logger.Add(String.Format("{0} blocked hit in {1}. His HP's still {2}", playerArgs.Name, playerArgs.Hitted, playerArgs.HP));
            gameView.setNextAction();
        }
        private void onWound(Object sender, EventArgs e)
        {
            if (!(e is PlayerEventArgs))
                throw new ArgumentException();
            PlayerEventArgs playerArgs = (PlayerEventArgs)e;
            Logger.Add(String.Format("{0} was hit in {1}. His HP's now {2}", playerArgs.Name, playerArgs.Hitted, playerArgs.HP));
            gameView.setNextAction();
        }
        private void onDeath(Object sender, EventArgs e)
        {
            if (!(e is PlayerEventArgs))
                throw new ArgumentException();
            PlayerEventArgs playerArgs = (PlayerEventArgs)e;
            Logger.Add(String.Format("{0} was killed by hit in {1}", playerArgs.Name, playerArgs.Hitted));
            String winner = (Session.State == GameState.HumanLost) ? Session.ComputerPlayer.Name : Session.HumanPlayer.Name;
            Logger.Add(String.Format("The winner of the match is {0}!!", DateTime.Now));
            Logger.Add(String.Format("End of the match!! {0}", DateTime.Now));
            
        }
        private void subscribePlayerToEvents(Player p)
        {
            p.Death += onDeath;
            p.Block += onBlock;
            p.Wound += onWound;
        }
        private void subscribePlayersToEvents()
        {
            subscribePlayerToEvents(Session.ComputerPlayer);
            subscribePlayerToEvents(Session.HumanPlayer);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
