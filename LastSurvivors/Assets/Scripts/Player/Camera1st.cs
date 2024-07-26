using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Camera1st : MonoBehaviour
    {
        private float mouseX;
        private float mouseY;

        float xRotation = 0f;

        public float sensitivityMouse = 2f;
        private float sensMouse;

        public Transform Player;

        public void Start()
        {
            sensMouse = sensitivityMouse;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void Update()
        {
            Camera();
        }

        public void Camera()
        {
            mouseX = Input.GetAxis("Mouse X") * sensMouse;
            mouseY = Input.GetAxis("Mouse Y") * sensMouse;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -40f, 40f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.Rotate(-mouseY * new Vector3(1, 0, 0) * Time.deltaTime);

            Player.Rotate(mouseX * new Vector3(0, 1, 0));
        }
    }
}

