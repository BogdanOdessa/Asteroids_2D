using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class EnemyShip
    {
        private readonly IAttack _attack;
        private readonly IMove _move;

        public EnemyShip(IAttack attack, IMove move)
        {
            _attack = attack;
            _move = move;
        }

        public void Attack()
        {
            _attack.Attack();
        }
        
        public void Move()
        {
            _move.Move();
        }

    } 
}

