using UnityEngine;

namespace Asteroids2D
{
    public class AsteroidMovingController : IUpdateExecute, IFixedUpdateExecute
    {
        private readonly AsteroidMovingView _asteroidMovingView;
        private readonly AsteroidMovingModel _asteroidMovingModel;
        private readonly AsteroidMovingHp _asteroidMovingHp;

        public AsteroidMovingController(AsteroidMovingView asteroidMovingView, AsteroidMovingModel asteroidMovingModel, 
            AsteroidMovingHp asteroidMovingHp)
        {
            _asteroidMovingView = asteroidMovingView;
            _asteroidMovingModel = asteroidMovingModel;
            _asteroidMovingHp = asteroidMovingHp;
            _asteroidMovingView.GetController(this);
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
                _asteroidMovingHp.TakeDamage(Bullet.Damage);
            }

        }

        private void KillPlayer(Collision2D player)
        {
            player.gameObject.SetActive(false);
        }
        
    }
}