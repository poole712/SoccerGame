using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone : MonoBehaviour
{

    public string teamName;
    public ScoreManager sm;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        BallManager.instance.InstantiateBall();

        if(teamName == "blue")
        {
            sm.blueScored();
        }
        if(teamName == "green")
        {
            sm.greenScored();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
