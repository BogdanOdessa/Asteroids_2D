using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Asteroids2D;
using UnityEditor.Timeline.Actions;
using UnityEngine;

namespace Asteroids2D
{
    public sealed class WeaponProxy : IGun
    {
        private readonly IGun _weapon;
        private readonly UnlockWeapon _unlockWeapon;
        private readonly PlayerView _playerView;

        public WeaponProxy(IGun weapon, UnlockWeapon unlockWeapon, PlayerView playerView)
        {
            _weapon = weapon;
            _unlockWeapon = unlockWeapon;
            _playerView = playerView;
           
        }

        public void Shoot()
        {
            if (_unlockWeapon.IsUnlock)
            {
                _playerView.Shoot();
               
                //_weapon.Shoot();
            }
            else
            {
                Debug.Log("Weapon is lock. Press R to Reload");
            }
        }

    }
}


