using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Props.Cam
{
    public class CameraSwitcher : MonoBehaviour
    {
        [SerializeField] private InputActionReference switchRef;
        [SerializeField]
        private CinemachineVirtualCamera[] cameras;

        private int _cameraCount;
        private int _currentCameraIndex;
        private bool _switch;

        private void OnEnable()
        {
            switchRef.action.Enable();
            switchRef.action.started += OnSwitch;
        }

        private void Start()
        {
            _currentCameraIndex = 0;
            _cameraCount = cameras.Length;
            cameras[_currentCameraIndex].Priority = Constants.Camera.PlayerSelectPriority;
        }
        
        private void OnDisable()
        {
            switchRef.action.Disable();
        }

        private void OnSwitch(InputAction.CallbackContext context)
        {
            _switch =  context.ReadValueAsButton();
            if (_switch)
            {
                Next();
            }
        }

        private void Next()
        {
            var previousIndex = _currentCameraIndex;
            var nextIndex = _currentCameraIndex + 1;
            if (nextIndex >= _cameraCount) nextIndex = 0;
            
            // 切り替え
            cameras[previousIndex].Priority = Constants.Camera.DefaultPriority;
            cameras[nextIndex].Priority = Constants.Camera.PlayerSelectPriority;
            
            _currentCameraIndex = nextIndex;
        }
    }
}