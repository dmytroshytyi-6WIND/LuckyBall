using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class BallUserControl : MonoBehaviour
    {
        private Ball ball; //������
        private Vector3 move;
        // ����������� ��������
        private Transform cam; 
        private Vector3 camForward; // ��������� ����������� ������
        private bool jump; // ������ �� ������� "������"


        private void Awake()
        {
            //��������� ������
            ball = GetComponent<Ball>();
 
        }


        private void Update()
        {
            // �������� ��� � ������ ������
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            jump = CrossPlatformInputManager.GetButton("Jump");

            //������� ����������� ��������
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
