using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerController : IUpdateExecute, IFixedUpdateExecute
    {
        private readonly PlayerView _playerView;
        private readonly IGun _gun;
        private readonly UnlockWeapon _unlockWeapon;
        private readonly WeaponProxy _weaponProxy;
        private readonly BulletsCount _bulletsCount;


        public PlayerController(PlayerView playerView, IGun gun)
        {
            _playerView = playerView;
            _gun = gun;
            _unlockWeapon = new UnlockWeapon(true);
            _weaponProxy = new WeaponProxy(_gun, _unlockWeapon, _playerView);
            _bulletsCount = new BulletsCount {Bullets = BulletsCount.FullClip};
        }
        public void UpdateExecute()
        {
            
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _playerView.Accelerate();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _playerView.DeAccelerate();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                if (_bulletsCount.Bullets <=0)
                {
                    _unlockWeapon.IsUnlock = false;
                }
                _weaponProxy.Shoot();
                _bulletsCount.Bullets -= BulletsCount.OneBulletShoot;
                
                //_playerView.Shoot();
            }

            if (Input.GetKeyUp(KeyCode.R))
            {
                _bulletsCount.Bullets = BulletsCount.FullClip;
                _unlockWeapon.IsUnlock = true;
            }
        }

        public void FixedUpdateExecute()
        {
            _playerView.Rotate();
            _playerView.Move();
        }
    } 
}


