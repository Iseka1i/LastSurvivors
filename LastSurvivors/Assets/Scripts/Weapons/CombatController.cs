using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    public class CombatController : MonoBehaviour
    {
        public Weapon weapon;
        public Animator animator;
        public Transform gunSlot;

        public bool canShoot;

        public void Start()
        {
            this.canShoot = true;
            this.weapon.Create(this.gunSlot, this.animator);
        }

        public void Update()
        {
            Attack();
            if (Input.GetKeyUp(KeyCode.R))
            {
                this.weapon.currentAmmos = this.weapon.maxAmmos;
            }
        }

        public void Attack()
        {
            if (Input.GetMouseButtonUp(0))
            {
                //Debug.Log("HBUIFGF(GOIFHUFHOO");
                if (this.weapon.isRangeWeapon && this.canShoot)
                {
                    RangeShoot();
                }
            }

        }
        public void RangeShoot()
        {
            if ( this.canShoot && this.weapon.currentAmmos > 0)
            {
                this.weapon.currentAmmos -= 1;
                this.animator.SetTrigger("Fire");
                this.weapon.weaponAnimator.SetTrigger("Firing");
                Ray rayInstance = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit[] items = Physics.RaycastAll(rayInstance);
                foreach (RaycastHit item in items)
                {
                    Health health = item.transform.GetComponent<Health>();
                    if (health != null)
                    {
                        health.health -= this.weapon.damage;
                        Debug.Log("Hitted - " + health.health);
                    }
                }
            }
        }
    } 
}


