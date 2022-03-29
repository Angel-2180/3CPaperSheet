using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour

{
    //Tweakable Var

    [Header("Needed player components")]
    [SerializeField]
    private Rigidbody rby = null;

    [Space]
    [Header("Players movement variables")]
    [SerializeField]
    private float MinSpeed = 13.8f;

    [SerializeField]
    private float Drag = 6f;

    [SerializeField]
    private float rotFactor = 20;

    [SerializeField]
    private float LengthOfBarrell = 5f;

    [SerializeField]
    private Vector3 Gravity = new Vector3(0, -1, 0);

    //Input

    private Controller control;
    private InputAction Move;
    private InputAction TiltLeft;
    private InputAction TiltRight;
    private InputAction BarrelLeft;
    private InputAction BarrelRight;

    //Var

    private Vector3 rot;
    private Vector2 move;
    public float Percentage;
    private bool lb = false;
    private bool rb = false;
    private bool lt = false;
    private bool rt = false;

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~InputSystem~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    private void Awake()
    {
        control = new Controller();
        Move = control.PlayerController.Movement;
        TiltLeft = control.PlayerController.TiltLeft;
        TiltRight = control.PlayerController.TiltRight;
        BarrelLeft = control.PlayerController.BarrelLeft;
        BarrelRight = control.PlayerController.BarrelRight;
    }

    private void OnEnable()
    {
        Move.Enable();
        TiltLeft.Enable();
        TiltRight.Enable();
        BarrelLeft.Enable();
        BarrelRight.Enable();

        Move.started += this.OnMovement;
        Move.performed += this.OnMovement;

        TiltLeft.started += this.OnTiltLeft;
        TiltLeft.performed += this.OnTiltLeft;
        TiltRight.started += this.OnTiltRight;
        TiltRight.performed += this.OnTiltRight;

        BarrelLeft.started += this.OnBarrelLeft;
        BarrelRight.started += this.OnBarrelRight;

        BarrelLeft.canceled += ctx =>
            this.lt = false;
        BarrelRight.canceled += ctx =>
            this.rt = false;

        TiltLeft.canceled += ctx =>
            this.lb = false;
        TiltRight.canceled += ctx =>
            this.rb = false;

        Move.canceled += ctx =>
            this.move = Vector2.zero;
    }

    private void OnDisable()
    {
        Move.Disable();
        TiltLeft.Disable();
        TiltRight.Disable();
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();
    }

    public void OnTiltLeft(InputAction.CallbackContext value)
    {
        if (value.started || value.performed)
        {
            lb = true;
        }
    }

    public void OnTiltRight(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            rb = true;
        }
    }

    public void OnBarrelRight(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            rt = true;
        }
    }

    public void OnBarrelLeft(InputAction.CallbackContext value)
    {
        if (value.started || value.performed)
        {
            lt = true;
        }
    }

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~UnityFrame Management~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    // Start is called before the first frame update
    private void Start()
    {
        Physics.gravity = Gravity;
        rot = transform.eulerAngles;
    }

    // Update is called once per frame
    private void Update()
    {
        //Rotate player
        // X
        rot.x += rotFactor * -move.y * Time.deltaTime;
        rot.x = Mathf.Clamp(rot.x, -5, 45);
        // Y
        rot.y += rotFactor * move.x * Time.deltaTime;
        // Z
        Tilting();
        if (lt || rt)
        {
            StartCoroutine(BarrelRoll());
        }
        transform.rotation = Quaternion.Euler(rot);
        Percentage = rot.x / 45;

        //Drag : Fast(4), Slow(6)
        float mod_drag = (Percentage * -Drag) + Drag;
        //Speed : Fast(13.8), Slow(12.5)
        float mod_speed = Percentage * (MinSpeed - 12.5f) + MinSpeed;

        rby.drag = mod_drag;
        Vector3 localV = transform.InverseTransformDirection(rby.velocity);
        localV.z = mod_speed;
        rby.velocity = transform.TransformDirection(localV);
    }

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~Function~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    private void Tilting()
    {
        if (lb)
        {
            rot.z += -rotFactor * Time.deltaTime;
            rot.z = Mathf.Clamp(rot.z, -5, 5);
            rot.y += -rotFactor * Time.deltaTime;
            rot.y = Mathf.Clamp(rot.y, -12, 12);
        }
        else if (rb)
        {
            rot.z += rotFactor * Time.deltaTime;
            rot.z = Mathf.Clamp(rot.z, -5, 5);
            rot.y += rotFactor * Time.deltaTime;
            rot.y = Mathf.Clamp(rot.y, -12, 12);
        }
    }

    private IEnumerator BarrelRoll()
    {
        print("Do a Barell Roll");
        if (lt)
        {
            print("Port");
            transform.Translate(-LengthOfBarrell, 0, 0);
            lt = false;
        }
        else if (rt)
        {
            print("Starboard");
            transform.Translate(LengthOfBarrell, 0, 0);
            rt = false;
        }
        yield return new WaitForSeconds(5f);
    }
}