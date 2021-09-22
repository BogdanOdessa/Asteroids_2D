namespace Asteroids2D
{
    internal class BulletModifer
    {
        protected BulletData _bulletData;
        protected BulletModifer Next;
    
        public BulletModifer(BulletData bulletData)
        {
            _bulletData = bulletData;
        }

        public void Add(BulletModifer cm)
        {
            if (Next != null)
            {
                Next.Add(cm);
            }
            else
            {
                Next = cm;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}