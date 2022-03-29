using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    private PlayerControler player;

    [SerializeField] private Vector3 WindParameter;

    [SerializeField] private float Force;

    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponent<PlayerControler>();
    }

    private void OnTriggerStay(Collider other)
    {
        var truc = other.gameObject.GetComponent<Rigidbody>();
        truc.AddForce(WindParameter * Force, ForceMode.Impulse);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}