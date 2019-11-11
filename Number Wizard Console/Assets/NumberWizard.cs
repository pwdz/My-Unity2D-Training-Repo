using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max,min;
    private int guessNum;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();   
        // print("Welcome yo :| ...");
    }

    private void StartGame()
    {

        max=1000;
        min = 1;
        guessNum=500;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Please pick a number, don't tell me what it is!:...");
        Debug.Log("The highest number u can pick is: "+max);
        Debug.Log("The lowest number u can pick is: "+min);
        Debug.Log("Tell me if your number is higher or lower than"+guessNum);
        Debug.Log("Push Up = higher, Push Down = Lower, Push Enter = Correct");
        max++;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guessNum;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guessNum;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I found ur number :')");
            StartGame();
        }

    }
    private void NextGuess()
    {
        guessNum = (min+max)/2;
        Debug.Log("Is it higher or lower than: "+guessNum);
    }
}
