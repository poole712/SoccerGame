using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeedUp : MonoBehaviour
{
    public static PowerUpSpeedUp instance; 
    public GameObject powerUpBall;
    public GameObject theBall;
    private bool waited;
    private List<int> potentialPositions = new List<int> { 45, 15, 30, 5 };


    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartCoroutine(waiter());


    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("TheBall").GetComponent<BallBehaviour>().ballThrust += 5000;
    }

    IEnumerator waiter()
    {
        int wait_time = Random.Range(0, 10);
        yield return new WaitForSeconds(wait_time);
        int positionIndex = Random.Range(0, 4);
        GameObject powerUpBallCopy = Instantiate(powerUpBall, new Vector3(potentialPositions[positionIndex],0, potentialPositions[positionIndex]), transform.rotation);

    }
}
