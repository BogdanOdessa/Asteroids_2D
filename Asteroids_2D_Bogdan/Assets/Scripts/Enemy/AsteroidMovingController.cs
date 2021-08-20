namespace Asteroids2D
{
    public class AsteroidMovingController : IUpdateExecute, IFixedUpdateExecute
    {
        private readonly AsteroidMoving _asteroidMoving;

        public AsteroidMovingController(AsteroidMoving asteroidMoving)
        {
            _asteroidMoving = asteroidMoving;
        }

        public void UpdateExecute()
        {
            _asteroidMoving.RandomMovement();
        }

        public void FixedUpdateExecute()
        {
            _asteroidMoving.AddForce();
        }
    }
}