using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathwayBlockController : MonoBehaviour
{
    private Rigidbody rb;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit ( Collider collider )
        {
        if (collider.CompareTag("Orb"))
        {
            gameManager.Score+=1;
            gameManager.SaveScore();

            gameManager.LastScore += 1;
            gameManager.SaveScore();

            rb.isKinematic = false;
            Destroy(gameObject,2);
        }
        }
    }
