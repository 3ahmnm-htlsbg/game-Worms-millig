using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode downKey;
    public KeyCode forwardKey;
    public KeyCode backwardKey;
    public KeyCode shootKey;
    public Rigidbody z;
    public Vector3 x;
    public Vector3 y;
    public ForceMode f;
    public GameObject projectile;
    public Vector3 position;
    public Quaternion quat;

    public GameObject Weapon;
    public Vector3 PosW;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            //dieser Code wird ausgeführt sobald die in der Variable jumpKey definierte Taste gedrückt wird
            Debug.Log("Sprungtaste wird gedrückt.");
            z.AddForce(x, f);
        }

        if (Input.GetKeyDown(forwardKey))
        {
            Debug.Log("Charakter bewegt sich nach rechts.");
            z.AddForce(y, f);
        }

        if (Input.GetKeyDown(backwardKey))
        {
            Debug.Log("Charakter bewegt sich nach links.");
            z.AddForce(-y);
        }

        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Charakter bewegt sich nach unten.");
            z.AddForce(-x);
        }

        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("Charakter schießt.");
            PosW = Weapon.transform.position;
            Instantiate(projectile, PosW, quat);
        }

    }
}
