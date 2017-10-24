using System;


namespace FightClub
{
    public class PlayerEventArgs : EventArgs
    {
        public short HP { get;}
        public String Name { get; }
        public BodyPart Hitted { get; }
        public PlayerEventArgs (Player p,BodyPart hit) {
            HP = p.HP;
            Name = p.Name;
            Hitted = hit;
        }
    }
}
