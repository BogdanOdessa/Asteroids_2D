using UnityEngine;

namespace Asteroids.Decorator
{
    public class WeaponData
    {
        public readonly AudioSource audioSource;
        public readonly AudioClip audioClip;
        public readonly Transform barrelTransform;

        public WeaponData(AudioSource audioSource, AudioClip audioClip, Transform barrelTransform)
        {
            this.audioSource = audioSource;
            this.audioClip = audioClip;
            this.barrelTransform = barrelTransform;
        }
    }
}