namespace Instrumentation
{
    public class Player
    {
        public string name;
        public Player(string name)
        {
            this.name = name;
        }
        public void Tune(Instrument i)
        {
            i.Player(i);
        }
        public void TuneAll(Instrument[] e)
        {
            e.First().What()
            for (int i = 0; i < e.Length; i++)
                Tune(e[i]);
        }
    }
}
