using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode forwardKey;
    public KeyCode backwardKey;
    public Rigidbody z;
    public Vector3 x;
    public Vector3 y;

    public ForceMode f;


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

    }
}
