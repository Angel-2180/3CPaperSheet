using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Colisions : MonoBehaviour
{
    // Life System
    public GameObject[] hearts;
    public int life;
    private bool isDead;
    private bool isGodMode = false;

    // Obstacle damage
    private int damage = 1;

    // Respawn
    private Transform playerPos;
    private Transform spawnPoint;

    // Power UP
    [SerializeField] private float godModDuration = 5f;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        spawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform;

    }

    void Update()
    {
        if (isDead)
        {
            print("You DIED");
            // INSERT DEATH CODE HERE !
        }
    }


    public void TakeDamage(int damage)
    {
        if (isGodMode)
        {
            print("Player is in god mod");
            return;
        }
        if (life >= 1)
        {
            life -= damage;
            Destroy(hearts[life].gameObject); //[0]
            playerPos.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        }
        if (life < 1)
        {
            isDead = true;
        }

    }

    private IEnumerator godMode(float time)
    {
        if (isGodMode)
        {
            yield return null;
        }
        else
        {
            isGodMode = true;
            yield return new WaitForSeconds(5f);
            isGodMode = false;
        }
    }



    // TEST ZONE

    [UnityEditor.MenuItem("Test/DamagePlayer")]
    public static void Test()
    {
        print("Try to hurt player");
        print($"Life before : {FindObjectOfType<Colisions>().life}");
        FindObjectOfType<Colisions>().TakeDamage(1);
        print($"Life after : {FindObjectOfType<Colisions>().life}");
    }

    [UnityEditor.MenuItem("Test/EnableGodMode")]
    public static void EnableGodMode()
    {
        FindObjectOfType<Colisions>().isGodMode = true;
    }
    [UnityEditor.MenuItem("Test/DisableGodMode")]
    public static void DisableGodMode()
    {
        FindObjectOfType<Colisions>().isGodMode = false;
    }


    private void OnCollisionEnter(Collision infoCollision)
    {
        switch (infoCollision.gameObject.tag)
        {
            case "Obstacles":
                TakeDamage(damage);
                break;
            case "God Mode":
                StartCoroutine(godMode(godModDuration));
                break;
            case "Health Pack":

                break;
            case "Finish":
                // WIN
                break;
        }
    }
}