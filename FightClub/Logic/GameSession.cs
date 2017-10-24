using System;


namespace FightClub
{
    public class GameSession
    {
        public Player HumanPlayer { get; }
        public Player ComputerPlayer { get; }
        private Random rand = new Random();
        public GameState State { get; private set; }
        public int Round { get; private set; }

        public GameSession(Player human, Player computer) {
            HumanPlayer = human;
            ComputerPlayer = computer;
            HumanPlayer.Death += setHumanLostState;
            ComputerPlayer.Death += setComputerLostState;
            State = GameState.HumanAttack;
            Round = 1;
        }
        private void setHumanLostState(Object sender,EventArgs e) {
            State = GameState.HumanLost;
        }
        private void setComputerLostState(Object sender, EventArgs e)
        {
            State = GameState.ComputerLost;
        }
        private BodyPart getRandomBodyPart() {
            var parts = Enum.GetValues(typeof(BodyPart));
            return (BodyPart)parts.GetValue(rand.Next(parts.Length));
        }
        public void Action(BodyPart humanChoice) {
            BodyPart computerChoice = getRandomBodyPart();
            if (State == GameState.HumanAttack)
            {
                State = GameState.ComputerAttack;
                ComputerPlayer.setBlocked(computerChoice);
                ComputerPlayer.getHit(humanChoice);
            }
            else if (State == GameState.ComputerAttack) {
                State = GameState.HumanAttack;
                HumanPlayer.setBlocked(humanChoice);
                HumanPlayer.getHit(computerChoice);
                ++Round;
            }
        }

    }
}
