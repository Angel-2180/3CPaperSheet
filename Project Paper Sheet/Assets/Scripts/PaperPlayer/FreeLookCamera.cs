using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// A simple free camera to be added to a Unity game object.
///
/// Keys:
///	wasd / arrows	- movement
///	q/e 			- up/down (local space)
///	r/f 			- up/down (world space)
///	pageup/pagedown	- up/down (world space)
///	hold shift		- enable fast movement mode
///	right mouse  	- enable free look
///	mouse			- free look / rotation
///        if (Input.GetKeyDown(KeyCode.C))c

/// </summary>
///

public class FreeLookCamera : MonoBehaviour
{
    //Tweakable Var
    [Header("Needed Component")]
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private Rigidbody Player;

    [Header("Camera Varaiables")]
    [SerializeField]
    private float maxFOV = 110f;

    [SerializeField]
    private float startFOV = 100.0f;

    [SerializeField]
    private float MinSpeedToChangeFOV = 14f;

    [Header("FreeLook Variables")]
    [Space]
    [SerializeField]
    private float _mouseSensitivity = 3.0f;

    [SerializeField]
    private float _distanceFromTarget = 3.0f;

    [SerializeField]
    private float _smoothTime = 0.2f;

    [SerializeField]
    private Vector2 _rotationXMinMax = new Vector2(-40, 40);

    //Var
    private Camera MainCam;

    private Vector3 OriginalPos;
    private Vector3 Newpos;
    private Vector3 _currentRotation;
    private Vector3 _smoothVelocity = Vector3.zero;
    private float _rotationY;
    private float _rotationX;
    private bool IsFreeCam = false;
    private Vector2 move;

    //Input
    private Controller control;

    private InputAction Cam;

    private InputAction CamSwitch;

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~InputSystem~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    private void Awake()
    {
        control = new Controller();
        Cam = control.PlayerController.Camera;
        CamSwitch = control.PlayerController.CameraSwitch;
    }

    private void OnEnable()
    {
        //Enable
        Cam.Enable();
        CamSwitch.Enable();

        //Stick Press
        CamSwitch.started += OnCameraSwitch;

        //Stick Analog
        Cam.started += this.OnCamera;
        Cam.performed += this.OnCamera;
        Cam.canceled += ctx =>
            this.move = Vector2.zero;
    }

    private void OnDisable()
    {
        Cam.Disable();
        CamSwitch.Disable();
    }

    public void OnCamera(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();
    }

    public void OnCameraSwitch(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            IsFreeCam = !IsFreeCam;
        }
    }

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~Function~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    private void Start()
    {
        MainCam = GetComponent<Camera>();
        OriginalPos = MainCam.transform.position;
        Newpos = Player.transform.position - OriginalPos;

        MainCam.fieldOfView = startFOV;
    }

    private void Update()
    {
        //if (Input.GetButtonDown("RightStickPush"))
        //{
        //    IsFreeCam = !IsFreeCam;
        //}

        if (IsFreeCam)
        {
            float mouseX = move.y * _mouseSensitivity;
            float mouseY = move.x * _mouseSensitivity;

            _rotationY += mouseY;
            _rotationX += mouseX;

            // Apply clamping for x rotation
            _rotationX = Mathf.Clamp(_rotationX, _rotationXMinMax.x, _rotationXMinMax.y);

            Vector3 nextRotation = new Vector3(_rotationX, _rotationY);

            // Apply damping between rotation changes
            _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation, ref _smoothVelocity, _smoothTime);
            transform.localEulerAngles = _currentRotation;

            // Substract forward vector of the GameObject to point its forward vector to the target
            transform.position = _target.position - transform.forward * _distanceFromTarget;
        }
        else
        {
            MainCam.transform.rotation = Quaternion.Euler(
                Mathf.Clamp(Player.transform.rotation.x, 45f, 55f),
                0,
                Mathf.Clamp(Player.transform.rotation.z, -10.0f, 10.0f)
            );
            MainCam.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y - Newpos.y, Player.transform.position.z - Newpos.z);
        }
        if (Player.velocity.magnitude > MinSpeedToChangeFOV)
        {
            if (MainCam.fieldOfView < maxFOV)
            {
                MainCam.fieldOfView += (Player.velocity.magnitude * Time.deltaTime);
            }
        }
        else
        {
            if (MainCam.fieldOfView > startFOV)
            {
                MainCam.fieldOfView += (-(Player.velocity.magnitude) * Time.deltaTime - 0.01f);
            }
            else
            {
                MainCam.fieldOfView = startFOV;
            }
        }
    }
}