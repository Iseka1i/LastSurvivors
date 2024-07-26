using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Game/Create Weapon")]
    public class Weapon : ScriptableObject
    {
        public GameObject weaponPrefab;
        public GameObject weaponObject;
        public Animator weaponAnimator;
        public AnimatorOverrideController overrideController;
        

        public float xPlace;
        public float yPlace;
        public float zPlace;

        public bool isRangeWeapon;

        public bool isSingleRate;
        public bool isBurstRate;
        public bool isAutoRate;

        public float damage;
        public float fireSpeed;
        public float recoil;
        public string caliber;
        public int maxAmmos;
        public int currentAmmos;

        public void Start()
        {
            //Create();
        }


        public virtual void Create(Transform hand, Animator animator)
        {
            if (this.weaponPrefab)
            {
                this.weaponObject = Instantiate(this.weaponPrefab, hand);
                this.weaponAnimator = this.weaponObject.GetComponent<Animator>();
                //Debug.Log("HJHFDH");
                if (xPlace != 0 || yPlace != 0 || zPlace != 0)
                {
                    Vector3 newPosition = Vector3.zero;
                    newPosition.x = this.xPlace;
                    newPosition.y = this.yPlace;
                    newPosition.z = this.zPlace;
                    weaponObject.transform.position += newPosition;
                }
            }

            if (this.overrideController)
            {
                animator.runtimeAnimatorController = this.overrideController;
            }
        }
    }
}


