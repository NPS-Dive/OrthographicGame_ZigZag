using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrbController : MonoBehaviour
    {
    [Range(1, 20)]
    public float OrbSpeed = 1f;
    public float OrbSpeedTimer;
    public float SpeedAddUp;
    public bool IsRightDirection = true;
    public GameManager ZigZagGameManager;
    public AudioManager ZigZagAudioManager;
    public bool IsGameStart = false;
    public GameObject GameOverPanel;
    public GameObject MainMenu;

    //movement vectors
    private Vector3 GoAhead = new Vector3(1, 0, 0);
    private Vector3 GoLeft = new Vector3(0, 0, 1);
    private Vector3 GoRight = new Vector3(1, 0, 0);


    // Start is called before the first frame update
    void Start ()
        {
        InvokeRepeating("OrbSpeedIncrementation", OrbSpeedTimer, OrbSpeedTimer);
        }

    // Update is called once per frame
    void Update ()
        {
        if (IsGameStart is true)
            {
            Move();
            }

        }

    #region CustomFunctions

    void OrbSpeedIncrementation ()
        {
        OrbSpeed += SpeedAddUp;
        }

    void Move ()
        {
        if (IsRightDirection is true)
            {
            if (Input.GetKey(KeyCode.LeftArrow))
                {
                GoAhead = GoLeft;
                IsRightDirection = false;
                ZigZagAudioManager.PlayBtnClickSound();
                }
            }
        else
            {
            if (Input.GetKey(KeyCode.RightArrow))
                {
                GoAhead = GoRight;
                IsRightDirection = true;
                ZigZagAudioManager.PlayBtnClickSound();
                }
            }
#pragma warning disable UNT0024
        transform.position += GoAhead * OrbSpeed * Time.deltaTime;
#pragma warning restore UNT0024
        }

    private void OnTriggerEnter ( Collider collider )
        {
        if (collider.CompareTag("Gem"))
            {
            ZigZagAudioManager.PlayGetGemSound();

            ZigZagGameManager.Gem++;
            ZigZagGameManager.SaveGems();
            Destroy(collider.gameObject);
            }
        else if (collider.CompareTag("CheckCollider"))
            {
            //print("ZigZag game over");
            MainMenu.SetActive(false);
            GameOverPanel.SetActive(true);
            ZigZagAudioManager.PlayGameOverSound();
            }
        }


    #endregion CustomFunctions
    }
