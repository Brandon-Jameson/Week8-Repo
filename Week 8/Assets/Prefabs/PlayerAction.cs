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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float acceleration = movementAction.ReadValue<Vector2>().y;
        transform.Translate(Vector3.forward * playerspeed * acceleration * Time.deltaTime, Space.Self); 
    }
}