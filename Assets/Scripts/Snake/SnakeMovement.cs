using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class SnakeMovement : MonoBehaviour
{
    [SerializeField] string _moveInputId;
    [SerializeField] PlayerInput _input;
    [SerializeField] float _velocity;

    private Vector2 _direction;
    //private Vector2 _newDir;

    private void OnEnable()
    {
        _input.actions[_moveInputId].performed += SnakeMovement_performed;
    }

    private void OnDisable()
    {
        _input.actions[_moveInputId].performed -= SnakeMovement_performed;
    }

    private void SnakeMovement_performed(InputAction.CallbackContext ctx)
    {
        _direction = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        transform.Translate(_direction*_velocity*Time.deltaTime);
    }
}