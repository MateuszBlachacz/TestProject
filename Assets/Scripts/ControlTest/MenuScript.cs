using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{
    [SerializeField]
    Canvas c;
    [SerializeField]
    Transform menuPanel;
    Event keyEvent;
    KeyCode newKey;

    bool menuActive = true;
    bool waitingForKey;

    // Start is called before the first frame update
    void Start()
    {

        waitingForKey = false;
        setText();
    }

    private void Update()
    {
        if (Input.GetKeyDown(ControllerInput.self.keys[actions.menuKey]))
        {
            menuActive = !menuActive;
            c.gameObject.SetActive(menuActive);
        }
    }
    void OnGUI()
    {
        keyEvent = Event.current;

        if (keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void changeKey(string keyName)
    {
        if (!waitingForKey) StartCoroutine(AssignKey(keyName));
    }

    public void setText()
    {
        for (int i = 0; i < menuPanel.childCount; i++)
        {
            var btn = menuPanel.GetChild(i);
            var btnTxt = btn.GetComponentInChildren<Text>();
            btnTxt.text = ControllerInput.self.getKey(btn.name).ToString();
        }
    }

    IEnumerator WaitForKey()
    {

        while (!keyEvent.isKey)
        {
            yield return null;
        }
    }

    public IEnumerator AssignKey(string keyName)
    { 
        waitingForKey = true;
        yield return WaitForKey();
        if (newKey != KeyCode.P)
        {
            ControllerInput.self.setKey(keyName, newKey.ToString());
            setText();
        }

        yield return null;
    }
}
