using UnityEngine;
using UnityEngine.InputSystem;

namespace Props.Player
{
    public class PlayerFreeMover : MonoBehaviour
    {
        [SerializeField] private GameObject target;
        [Tooltip("Vector2 action for XY movement")]
        [SerializeField] private InputActionReference xyAxis;
        [SerializeField] private float moveSpeed;
        private Vector3 _moveInput;
        private Vector3 _velocity;

        private void OnEnable()
        {
            xyAxis.action.Enable();
            xyAxis.action.started += OnMove;
            xyAxis.action.performed += OnMove;
            xyAxis.action.canceled += OnMove;
        }

        private void OnDisable()
        {
            xyAxis.action.Disable();
        }

        private void OnMove(InputAction.CallbackContext context)
        { 
            var input = context.ReadValue<Vector2>();
            _moveInput = new Vector3(input.x, 0, input.y);
        }

        private void FixedUpdate()
        {
            var deltaTime = Time.deltaTime;
            _velocity = moveSpeed * _moveInput;
            target.transform.position += _velocity * deltaTime;
        }
    }
}