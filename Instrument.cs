namespace Instrumentation
{
    public class Instrument : IInstrument
    {
        public void Player(Instrument play)
        {
            Console.WriteLine("Play Instrument " + play);
        }
    }
}
