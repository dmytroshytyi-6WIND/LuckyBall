using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class BallUserControl : MonoBehaviour
    {
        private Ball ball; //ссылка
        private Vector3 move;
        // направление движения
        private Transform cam; 
        private Vector3 camForward; // следуещее направление камеры
        private bool jump; // нажата ли клавиша "прыжок"


        private void Awake()
        {
            //выделение памяти
            ball = GetComponent<Ball>();
 
        }


        private void Update()
        {
            // получаем оси и статус джампа
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            jump = CrossPlatformInputManager.GetButton("Jump");

            //считаем направление движения
            move = (v*Vector3.forward + h*Vector3.right).normalized;
            }


        private void FixedUpdate()
        {
            // Call the Move function of the ball controller
            ball.Move(move, jump);
            jump = false;
        }
    }
}
