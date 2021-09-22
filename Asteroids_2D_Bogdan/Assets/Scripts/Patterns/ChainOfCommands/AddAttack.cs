using Asteroids2D;

namespace Asteroids2D
{
    internal sealed class AddAttack : BulletModifer
    {
        private readonly int _attack;

        public AddAttack(BulletData bulletData, int attack) 
            : base(bulletData)
        {
            _attack = attack;
        }

        public override void Handle()
        { 
            
            _bulletData.AddDamage(_attack);
            base.Handle();
        }
    }
}