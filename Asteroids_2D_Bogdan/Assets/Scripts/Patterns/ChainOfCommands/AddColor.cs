using UnityEngine;

namespace Asteroids2D
{
    internal sealed class AddColor : BulletModifer
    {
        private readonly Color _color;
        //private readonly BulletData _bulletData;

        public AddColor(BulletData bulletData, Color color) 
            : base(bulletData)
        {
            //_bulletData = bulletData;
            _color = color;
        }

        public override void Handle()
        {
            _bulletData.ChangeColor(_color);
            base.Handle();
        }
    }
}