using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int counter;

    public GameObject bonusObj;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup() {
        Debug.Log("pickup message has been recieved");

        counter--;
        if (counter == 0) {
            SpawnBonus();
        }
    }

    void SpawnBonus() {
        // instantiate our prefab
        GameObject.Instantiate(bonusObj, transform);
    }
}
