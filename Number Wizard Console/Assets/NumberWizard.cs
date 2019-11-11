using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max=1000,min=1;
        int guessNum=1;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Please pick a number, don't tell me what it is!:...");
        Debug.Log("The highest number u can pick is: "+max);
        Debug.Log("The lowest number u can pick is: "+min);
        Debug.Log("Tell me if your number is higher or lower than"+guessNum);
        Debug.Log("Push Up = higher, Push Down = Lower, Push Enter = Correct");
        
        // print("Welcome yo :| ...");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Up Arrow key was pressed");
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("Down Arrow key was pressed");
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
        }
    }
}
