using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        private PlayerAbilitySelector _playerAbilities;
        private readonly ILog _log;
        private EnemyCount _enemyCount;

        public PlayerController(PlayerView playerView, IGun gun, PlayerAbilitySelector playerAbilities)
        {
            _playerView = playerView;
            _gun = gun;
            _unlockWeapon = new UnlockWeapon(true);
            _weaponProxy = new WeaponProxy(_gun, _unlockWeapon, _playerView);
            _bulletsCount = new BulletsCount {Bullets = BulletsCount.FullClip};
            _playerAbilities = playerAbilities;
            _enemyCount = new EnemyCount();
        }
        public void UpdateExecute()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                var randAb = _playerAbilities.GetRandomAbility();
                var ability = _playerAbilities.GetAbility();
                var ab =_playerAbilities.GetAbilityByIndex(AbilitiesCount.FirstAbility); 
                Debug.Log(randAb);
            }
            
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

            if (Input.GetKeyUp(KeyCode.C))
            {
                _enemyCount.Activate(new WarningLog());
            }
        }

        public void FixedUpdateExecute()
        {
            _playerView.Rotate();
            _playerView.Move();
        }
    } 
}


