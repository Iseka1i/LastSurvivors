using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class MoveController : MonoBehaviour
    {
        public float speed;
        public float runSpeed;
        public bool isJump;
        public float jumpPower = 200f;

        public Transform playerTransform;
        public Rigidbody rb;
        public GroundChecker groundChecker;
        public Animator animator;

        public void Start()
        {
            this.groundChecker = this.GetComponent<GroundChecker>();
            this.playerTransform = this.GetComponent<Transform>();
        }

        public void Update()
        {
            this.GetInputMovement();
        }


        public void GetInputMovement()
        {
            if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S)) // Вперед
            {
                //isGo = true;
                //isGoFb = true;
                //isStrafe = false;
                //goFOrB = 1;
                //movementDirection = 1;
                this.animator.SetBool("IsGo", true);
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    //isRun = true;
                    //goFOrB = 2;
                    //movementDirection = 2;
                    this.transform.position += transform.forward * runSpeed * Time.deltaTime;
                }
                else
                {
                    //goFOrB = 1;
                    //movementDirection = 1;
                    //isRun = false;
                    this.transform.position += transform.forward * speed * Time.deltaTime;
                }
            }
            else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) // Назад
            {
                //isGo = true;
                //isGoFb = true;
                //isStrafe = false;
                //goFOrB = -1;
                ///movementDirection = -1;
                this.transform.position += -transform.forward * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) // Лево
            {
                //isGo = true;
                //isGoFb = false;
                //isStrafe = true;
                //strafeRl = -1;
                //movementDirection = -0.25f;
                this.transform.position += -transform.right * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A)) // Право
            {
                //isGo = true;
                //isGoFb = false;
                //isStrafe = true;
                //strafeRl = 1;
                //movementDirection = 0.25f;
                this.transform.position += transform.right * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) // Лево и перед
            {
                //isGo = true;
                this.transform.position += transform.forward * speed * Time.deltaTime;
                this.transform.position += -transform.right * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A)) // Право и вперед
            {
                //isGo = true;
                this.transform.position += transform.forward * speed * Time.deltaTime;
                this.transform.position += transform.right * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D)) // Лево и назад
            {
                //isGo = true;
                this.transform.position += -transform.forward * speed * Time.deltaTime;
                this.transform.position += -transform.right * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A)) // Право и назад
            {
                //isGo = true;
                this.transform.position += -transform.forward * speed * Time.deltaTime;
                this.transform.position += transform.right * speed * Time.deltaTime;
                this.animator.SetBool("IsGo", true);
            }
            else
            {
                this.animator.SetBool("IsGo", false);
                //isGoFb = false;
                //isGo = false;
                //isStrafe = false;
                //strafeRl = 0;
                //goFOrB = 0;
                //movementDirection = 0;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (groundChecker.canJump == true)
                {
                    this.rb.AddForce(transform.up * jumpPower);
                    this.isJump = true;
                }
                else
                {
                    this.isJump = false;
                }
            }
        }
    }
}

