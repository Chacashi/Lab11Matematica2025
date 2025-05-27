using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public UnityEvent OnTapUp;
    public UnityEvent OnTapDown;

    private float _height;
    private float _currentPos;

    private void Start()
    {
        _height = Screen.height / 2;
    }

    public void TrackMouse(InputAction.CallbackContext context)
    {
        _currentPos = context.ReadValue<Vector2>().y;
    }


    public void  OnClick(InputAction.CallbackContext context)
    {
        if (!context.performed) return;


        
            if (_height > _currentPos)
            {
                OnTapDown?.Invoke();
            }
            else
            {
                OnTapUp?.Invoke();
            }
        
    }

}
