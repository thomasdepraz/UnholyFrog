using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEditor;
using UnityEngine;

namespace UnholyFrog.Game.Components
{
    public class PlayerController : MonoBehaviour
    {
        /// <summary>
        /// Settings for the player controller
        /// </summary>
        public PlayerControllerSettings settings;

        [InputAxis]
        public string HorizontalInput;

        [InputAxis]
        public string VerticalInput;

        private Rigidbody m_Ridigbody;
        private float m_HorizontalInput;
        private float m_VerticalInput;

        void Start()
        {
            m_Ridigbody = GetComponentInChildren<Rigidbody>();
        }

        void Update()
        {
            m_HorizontalInput = Input.GetAxis(HorizontalInput);
            m_VerticalInput = Input.GetAxis(VerticalInput);

            Vector3 direction = new Vector3(m_VerticalInput, 0, m_HorizontalInput);
            direction.Normalize();

            if(m_HorizontalInput != 0 || m_VerticalInput != 0)
            {
                m_Ridigbody.velocity = direction * settings.Speed;
            }
            else
            {
                m_Ridigbody.velocity = Vector3.zero;
            }
        }
    }
}