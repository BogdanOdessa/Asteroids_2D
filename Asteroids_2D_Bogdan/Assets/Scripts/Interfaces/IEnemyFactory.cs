namespace Asteroids2D
{
    public interface IEnemyFactory
    {
        public Enemy Create(float hp);
    }
}