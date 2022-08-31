using Cinemachine;
using UnityEngine;

namespace Props.Cam
{
    public class OnTriggerSwitchCamera : MonoBehaviour
    {
        [SerializeField] CinemachineVirtualCamera virtualCamera;

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag(Constants.Player.Tag))
            {
                virtualCamera.Priority = Constants.Camera.SystemAutoPriority;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(Constants.Player.Tag))
            {
                virtualCamera.Priority = Constants.Camera.LowPriority;
            }
        }
    }
}