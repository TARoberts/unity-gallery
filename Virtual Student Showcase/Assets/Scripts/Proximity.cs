using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Proximity : MonoBehaviour
{
    public string newTask;
    public string newDetail;

    private Transform other;
    private Text theTask;
    private Text theDetail;

    private float dist;
    private GameObject player;
    private GameObject message1;
    private GameObject message2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();
        message1 = GameObject.FindWithTag("Task Title");
        message2 = GameObject.FindWithTag("Task Detail");
        theTask = message1.GetComponent<Text>();
        theTask.text = "";
        theDetail = message2.GetComponent<Text>();
        theDetail.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
           dist = Vector3.Distance(transform.position, other.position);
            print("Distance to player: " + dist);
            if (dist < 6)
            {
                theTask.text = newTask;
                theDetail.text = newDetail;
            }
        }
    }
}
