namespace Asteroids2D
{
    public interface IMove
    {
        float Speed { get; }
        void Move(float horizontal, float vertical);
    }
}