using System;


namespace FightClub
{
    [Serializable]
    public class Player
    {
        public short HP { get; private set; }
        public short MaxHP { get;}
        public String Name  { get;}
        public BodyPart Blocked { get; private set;}


        public delegate void PlayerEvent(Object sender,EventArgs e);
        [field: NonSerialized]
        public event PlayerEvent Block;
        [field: NonSerialized]
        public event PlayerEvent Wound;
        [field: NonSerialized]
        public event PlayerEvent Death;

        public Player(string name,short hp)  {
            HP = hp;
            MaxHP = hp;
            Name = name;
        }
        public void setBlocked (BodyPart blocked) {
            Blocked = blocked;
        }
        public void getHit(BodyPart hit) {
            if (hit == Blocked) {
                Block?.Invoke(this, new PlayerEventArgs(this,hit));
            }
            else {
                HP -= (short)hit;
                if (HP > 0)
                    Wound?.Invoke(this, new PlayerEventArgs(this, hit));
                else {
                    HP = 0;
                    Death?.Invoke(this, new PlayerEventArgs(this, hit));
                }
                    
            } 
        }
        

    }
}
