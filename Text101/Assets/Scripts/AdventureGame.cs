using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]Text textComponent;
    [SerializeField] State startingState;
    private State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        StateManager();    
    }
    private void StateManager()
    {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
            state = nextStates[0];
        else if(Input.GetKeyDown(KeyCode.Alpha2))
            state = nextStates[1];
        textComponent.text = state.GetStateStory();    
    }
    
}
