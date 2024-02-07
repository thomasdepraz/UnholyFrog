using UnityEngine;

namespace UnholyFrog.Game.Components
{
    [CreateAssetMenu(fileName = nameof(PlayerControllerSettings), menuName = "Settings/PlayerController")]
    public class PlayerControllerSettings : ScriptableObject
    {
        /// <summary>
        /// Avatar speed
        /// </summary>
        public float Speed;
    }
}