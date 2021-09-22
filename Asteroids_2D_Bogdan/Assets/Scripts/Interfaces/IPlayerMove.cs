namespace Asteroids2D
{
    public interface IPlayerMove
    {
        float Speed { get; }
        void Move(float horizontal, float vertical);
    }
}