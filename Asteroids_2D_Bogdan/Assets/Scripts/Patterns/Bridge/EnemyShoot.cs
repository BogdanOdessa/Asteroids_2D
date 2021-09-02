using UnityEngine;

namespace Asteroids2D
{
    public class EnemyShoot : MonoBehaviour
    {

        private Transform _barrel;
        private GameObject _prefab;
        private const float TimeToWaitAfterFirstShot = 3f;
        private float _waitingTime;
        private bool _isShoot;

        private void Start()
        {
            _waitingTime = TimeToWaitAfterFirstShot;
            _prefab = Resources.Load<GameObject>("Enemy/EnemyBullet");
            _barrel = transform.GetChild(0);
            _isShoot = true;
        }
        
        public void Shoot()
        {
            if (_isShoot)
            {
                var shoot = Instantiate(_prefab, _barrel.position, _barrel.rotation);
                var rigidBody = shoot.GetComponent<Rigidbody2D>();
                rigidBody.AddForce(_barrel.up * EnemyBullet.BulletForce);
                _isShoot = false;
            }
        }

        public void ShootWithPause()
        {
            Shoot();
            PauseAfterShoot(pauseTime:3f);
        }

        private void PauseAfterShoot(float pauseTime)
        {
            if(!_isShoot)
            {
                _waitingTime -= Time.deltaTime;
                if (_waitingTime <= 0)
                {
                    _isShoot = true;
                    _waitingTime = pauseTime;
                }
                
            }
        }
    }
}