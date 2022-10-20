namespace Instrumentation
{
    public class MusicPlayer
    {
        public void Start()
        {
            Player player = new Player("Myself");
            Instrument[] orchestra = {
                new Violins(),
                new Bass(),
                new Cellos()
                };

            player.TuneAll(orchestra);
        }
        
    }
}
