namespace Asteroids2D
{
    public interface IMove
    {
        float Speed { get; }
        // ReSharper disable Unity.PerformanceAnalysis
        void Move(float horizontal, float vertical);
    }
}