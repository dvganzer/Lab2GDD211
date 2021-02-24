using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    public Rigidbody Vehicle;
    public string playerName2;
    public Text CarName;
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Vehicle.AddForce(new Vector3(0f, 0f, .5f));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vehicle.AddForce(new Vector3(.1f, 0f, 0f));
        }
        else if(Input.GetKey(KeyCode.A))
        {
            Vehicle.AddForce(new Vector3(-.1f, 0f, 0f));
        }
    }
    private void Awake()
    {
        playerName2 = PlayerPrefs.GetString("ThisPlayer","playerName");
       CarName.text =  playerName2;
    }
    
 

}
