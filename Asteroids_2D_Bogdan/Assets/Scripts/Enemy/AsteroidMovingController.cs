using UnityEngine;

namespace Asteroids2D
{
    public class AsteroidMovingController : IUpdateExecute, IFixedUpdateExecute
    {
        private readonly AsteroidMovingView _asteroidMovingView;
        private readonly AsteroidMovingModel _asteroidMovingModel;
        private readonly AsteroidMovingHp _asteroidMovingHp;
        protected readonly PointsCounter PointsCounter;

        public AsteroidMovingController(AsteroidMovingView asteroidMovingView, AsteroidMovingModel asteroidMovingModel, 
            AsteroidMovingHp asteroidMovingHp, PointsCounter pointsCounterClass)
        {
            _asteroidMovingView = asteroidMovingView;
            _asteroidMovingModel = asteroidMovingModel;
            _asteroidMovingHp = asteroidMovingHp;
            _asteroidMovingView.GetController(this);
            PointsCounter = pointsCounterClass;
        }
    
        public void UpdateExecute()
        {
            _asteroidMovingView.RandomMovement(
                AsteroidMovingModel.MINRandomRange, AsteroidMovingModel.MAXRandomRange, 
                _asteroidMovingModel.accelerationTime);
        }

        public void FixedUpdateExecute()
        {
            _asteroidMovingView.AddForce(_asteroidMovingModel.maxSpeed);
        }

        public void Collision(Collision2D other)
        {
            if (other.gameObject.GetComponent<PlayerView>())
            {
                KillPlayer(other);
            }

            if (other.gameObject.GetComponent<Bullet>())
            {
                var bullet = other.gameObject.GetComponent<Bullet>();
                _asteroidMovingHp.TakeDamage(bullet.Damage);
            }

        }

        private void KillPlayer(Collision2D player)
        {
            player.gameObject.SetActive(false);
        }

        public void GetPointsAmount()
        {
            PointsCounter.ReceivePoints();
        }
        
    }
}