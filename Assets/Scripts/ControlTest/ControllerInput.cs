using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum actions
{
    jumpedKey,
    forwardKey,
    backwardKey,
    leftKey,
    rightKey,
    defaultKey,
    menuKey,
}

public class ControllerInput : MonoBehaviour
{
    public static ControllerInput self;

    public Dictionary<actions, KeyCode> keys = new Dictionary<actions, KeyCode>();

    private void Awake()
    {
        if(null == self)
        {
            DontDestroyOnLoad(gameObject);
            self = this;
        } else if(this != self ){
            Destroy(gameObject);
        }
        
        keys[actions.jumpedKey] = setKey(actions.jumpedKey, "Space");
        keys[actions.forwardKey] = setKey(actions.forwardKey, "W");
        keys[actions.backwardKey] = setKey(actions.backwardKey, "S");
        keys[actions.leftKey] = setKey(actions.leftKey, "A");
        keys[actions.rightKey] = setKey(actions.rightKey, "D");
        keys[actions.menuKey] = setKey(actions.menuKey, "P");

    }

    private KeyCode setKey(actions actionName, string keyName)
    {
        return (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(actionName.ToString(), keyName));
    }

    public  actions getAction(string name)
    {
        switch (name)
        {
            case "jumpedKey":
                return actions.jumpedKey;
            case "forwardKey":
                return actions.forwardKey;
            case "backwardKey":
                return actions.backwardKey;
            case "leftKey":
                return actions.leftKey;
            case "rightKey":
                return actions.rightKey;
            case "menuKey":
                return actions.menuKey;
            default:
                return actions.defaultKey;
        }
    }

    public KeyCode getKey(string name)
    {
        return keys[getAction(name)];
    }
}
