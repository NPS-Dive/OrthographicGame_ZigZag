using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathwayGeneratorScript : MonoBehaviour
    {
    public GameObject Orb;
    public GameObject PathwayBlock;
    public GameObject Distance;
    public GameObject Gem;

    public float PathwayBlockDistance;
    private float GemGeneratorTimer;
    public float GenerateTime;

    // Start is called before the first frame update
    void Start ()
        {

        }

    // Update is called once per frame
    void Update ()
        {
        PwGenerator();
        GemGeneratorTimer += Time.deltaTime;
        }

    #region Custom Functions

    void PwGenerator ()
        {
        if (Vector3.Distance(Orb.transform.position, Distance.transform.position) < 20)
            {
            for (int i = 0; i < 10; i++)
                {
                if (Random.Range(0f, 1f) > .5f)
                    {
                    var newBlock = Instantiate(
                        PathwayBlock,
                        new Vector3(
                            Distance.transform.position.x + PathwayBlockDistance,
                            Distance.transform.position.y,
                            Distance.transform.position.z),
                        Quaternion.identity);

                    Distance = newBlock;
                    PathwayBlock = newBlock;

                    if (GemGeneratorTimer >= GenerateTime)
                        {
                        GemGerator(newBlock.transform);
                        GemGeneratorTimer = 0f;
                        }
                    }

                if (Random.Range(0f, 1f) < .5f)
                    {

                    var newBlock = Instantiate(
                        PathwayBlock,
                        new Vector3(
                            Distance.transform.position.x,
                            Distance.transform.position.y,
                            Distance.transform.position.z + PathwayBlockDistance),
                        Quaternion.identity);

                    Distance = newBlock;
                    }
                }


            }
        }

    void GemGerator ( Transform generatePosition )
        {
        Instantiate(
            Gem,
            new Vector3(
               generatePosition.position.x,
               generatePosition.position.y + 1f,
               generatePosition.position.z
                ),
            new Quaternion(
                180,
                generatePosition.rotation.y,
                generatePosition.rotation.z,
                generatePosition.rotation.w)
            );
        }

    #endregion Custom Functions
    }
