using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class Weapon : IFire
    {
        public Transform BarrelPosition { get; private set; }
        private IAmmunition _bullet;
        private float _force;
        public AudioClip AudioClip { get; private set; }
        public readonly AudioSource AudioSource;

        public Weapon(IAmmunition bullet, Transform barrelPosition, float force, AudioSource audioSource, AudioClip audioClip)
        {
            _bullet = bullet;
            BarrelPosition = barrelPosition;
            _force = force;
            AudioSource = audioSource;
            AudioClip = audioClip;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            BarrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            AudioClip = audioClip;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, BarrelPosition.position, Quaternion.identity);
            bullet.AddForce(BarrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
            AudioSource.PlayOneShot(AudioClip);
        }
    }
}