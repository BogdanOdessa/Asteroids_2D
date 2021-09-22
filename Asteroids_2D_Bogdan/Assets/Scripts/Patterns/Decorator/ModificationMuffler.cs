using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IMuffler _muffler;
        private readonly Vector3 _mufflerPosition;
        private WeaponData _weaponData;

        public ModificationMuffler(AudioSource audioSource, IMuffler muffler, Vector3 mufflerPosition)
        {
            _audioSource = audioSource;
            _muffler = muffler;
            _mufflerPosition = mufflerPosition;
        }
        
        protected override Weapon AddModification(Weapon weapon)
        {
            _weaponData = new WeaponData(weapon.AudioSource,weapon.AudioClip, weapon.BarrelPosition);
            var muffler = Object.Instantiate(_muffler.MufflerInstance, _mufflerPosition, Quaternion.identity);
            _audioSource.volume = _muffler.VolumeFireOnMuffler;
            weapon.SetAudioClip(_muffler.AudioClipMuffler);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }
        
        protected override Weapon RemoveModification(Weapon weapon)
        {
            Object.Destroy(GameObject.FindWithTag("muffler"));
            _audioSource.volume = _weaponData.audioSource.volume;
            weapon.SetAudioClip(_weaponData.audioClip);
            weapon.SetBarrelPosition(_weaponData.barrelTransform);
            
            return weapon;
        }
    }
}