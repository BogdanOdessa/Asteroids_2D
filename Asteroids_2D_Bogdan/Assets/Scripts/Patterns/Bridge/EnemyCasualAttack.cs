using UnityEngine;

namespace Asteroids2D
{
    public class EnemyCasualAttack : IAttack
    {
        private readonly EnemyShoot _enemyShoot;
        
        public EnemyCasualAttack(EnemyShoot enemyShoot)
        {
            _enemyShoot = enemyShoot;
        }
        public void Attack()
        {
            _enemyShoot.ShootWithPause();
        }
    }
}