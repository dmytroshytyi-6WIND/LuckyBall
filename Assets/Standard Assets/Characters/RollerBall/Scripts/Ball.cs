using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 5; // сила приложеная к мячу что бы двигать его
        [SerializeField] private bool m_UseTorque = true; // использовать крутящий момент что бы двигать мяч
        [SerializeField] private float m_MaxAngularVelocity = 25; // максимальная скорость с которой может вращаться мяч
        [SerializeField] private float m_JumpPower = 2; //сила прышка

        private const float k_GroundRayLength = 1f;  
        private Rigidbody m_Rigidbody;


        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            //задать макс. угловую скорость
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }


        public void Move(Vector3 moveDirection, bool jump)
        {
            //используем крутящий момент, что бы крутить шар?
            if (m_UseTorque)
            {
                // добавить крутящий момент вокруг оси определенной направлением движения, плече на момент силы.
                m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower);
            }
            else
            {
             // добавить силу в указанном направлении
                m_Rigidbody.AddForce(moveDirection*m_MovePower);
            }

           // если на земле был нажата кнопка прыжок
            if (Physics.Raycast(transform.position, -Vector3.up, k_GroundRayLength) && jump)
            {
                m_Rigidbody.AddForce(Vector3.up*m_JumpPower, ForceMode.Impulse);
            }
        }
    }
}
