using UnityEngine;

public class myNull : MonoBehaviour
{

    string firstName = "Dylan";
    string lastName = null;
    int? meaningOfLife = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int trueNumber = meaningOfLife ?? 42;
        //  operator replaces NULL and Null only. 
        Debug.Log(trueNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
