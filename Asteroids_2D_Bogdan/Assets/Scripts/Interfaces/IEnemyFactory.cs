namespace Asteroids2D
{
    public interface IEnemyFactory
    {
        public Enemy Create(Health hp);
    }
}