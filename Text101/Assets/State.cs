using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // Start is called before the first frame update
    [TextArea(14,14)][SerializeField]string storyText;
    public string GetStateStory()
    {
        return storyText;
    }
}
