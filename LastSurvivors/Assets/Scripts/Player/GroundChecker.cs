using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    public class GroundChecker : MonoBehaviour
    {
        public bool isGrounded;

        public bool isJump;

        public bool canJump;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<IsJumpable>() != null || collision.gameObject.GetComponent<NavMeshAgent>() != null)
            {
                isGrounded = true;
                isJump = false;
                canJump = true;
            }
            else if (collision.gameObject.GetComponent<IsJumpable>() == null)
            {
                isGrounded = true;
                isJump = false;
                canJump = false;
            }


        }
        private void OnCollisionExit(Collision collision)
        {
            if (Input.GetKey(KeyCode.Space) && collision.gameObject.GetComponent<IsJumpable>() != null)
            {
                isGrounded = false;
                isJump = true;
                canJump = false;

            }
        }
    }
}

