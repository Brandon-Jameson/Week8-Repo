using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] private float playerspeed;
    private PlayerActions actions;
    private InputAction movementAction;

    void Awake()
    {
        actions = new PlayerActions();
        movementAction = actions.movement.walk;
    }

    void OnEnable()
    {
        movementAction.Enable();
        
    }

    void OnDisable()
    {
        movementAction.Disable();
        
    }

    void Update()
    {
        Vector3 movementDirection = new Vector3(movementAction.ReadValue<Vector2>().x, 0,
                                                movementAction.ReadValue<Vector2>().y);
        transform.Translate(movementDirection * playerspeed * Time.deltaTime, Space.Self); 
        
    }
}
