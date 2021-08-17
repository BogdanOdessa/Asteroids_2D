namespace Asteroids2D
{
    public interface IPlayerFactory
    {
        public PlayerCreate Create(Health hp);
    }
}