using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialSystem : MonoBehaviour
    {
    public Material[] BoxMatList;
    public Material BoxMat;
    public Material DefaultBoxMaterial;
    public float ChangeTime = 10f;


    // Start is called before the first frame update
    void Start ()
        {
        BoxMat.color = DefaultBoxMaterial.color;
        InvokeRepeating("ChangeMaterial", ChangeTime, ChangeTime);
        }

    // Update is called once per frame
    void Update ()
        {

        }


    #region Custom Functions

    void ChangeMaterial ()
        {
        int RandomMaterial = Random.Range(0, 4);
        BoxMat.color = BoxMatList[RandomMaterial].color;

        }

    #endregion Custom Functions
    }
