using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
    {
    public Transform OrbPosition;
    // Start is called before the first frame update
    void Start ()
        {

        }

    // Update is called once per frame
    void Update ()
        {
        transform.position = new Vector3(OrbPosition.position.x, transform.position.y, OrbPosition.position.z);

        }
    }
