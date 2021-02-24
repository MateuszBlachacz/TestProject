using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    [SerializeField] Quest quest;

    private void Start()
    {
        foreach(string Task in quest.getTask()) {
            Debug.Log(Task);
        }
    }
}
