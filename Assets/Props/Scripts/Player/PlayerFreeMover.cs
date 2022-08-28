using UnityEngine;
using UnityEngine.InputSystem;

namespace Props.Player
{
    public class PlayerFreeMover : MonoBehaviour
    {
        [SerializeField] private GameObject target;
        [Tooltip("Vector2 action for XY movement")]
        [SerializeField] private InputActionReference xyAxis;

        private void OnEnable()
        {
            xyAxis.action.Enable();
            xyAxis.action.started += Move;
            xyAxis.action.performed += Move;
            xyAxis.action.canceled += Move;
        }

        private void OnDisable()
        {
            xyAxis.action.Disable();
        }

        private void Move(InputAction.CallbackContext context)
        {
            var input = context.ReadValue<Vector2>();
        }
    }
}