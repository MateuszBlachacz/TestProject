using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControllerInput : MonoBehaviour
{
    public static ControllerInput self;

    public KeyCode jump { get; set; }
    public KeyCode forward { get; set; }
    public KeyCode backward { get; set;}
    public KeyCode left { get; set; }
    public KeyCode right { get; set; }


    private void Awake()
    {
        if(null == self)
        {
            DontDestroyOnLoad(gameObject);
            self = this;
        } else if(this != self ){
            Destroy(gameObject);
        }

        jump = setKey("jumpedKey", "Space");
        forward = setKey("forwardKey", "W");
        backward = setKey("backwordKey", "S");
        left = setKey("leftKey", "A");
        right = setKey("rightKey", "D");

    }

    private KeyCode setKey(string actionName, string keyName)
    {
        return (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(actionName, keyName));
    }
}
