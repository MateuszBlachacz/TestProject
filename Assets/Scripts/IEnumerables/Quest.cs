using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="UnnamedQuest", menuName = "IEnumerable/Quest", order = 0)]
public class Quest : ScriptableObject
{
    [SerializeField] List<string> tasks;
    

    public void AddTask(string newTask)
    {
        tasks.Add(newTask);
    }
    public IEnumerable<string> getTask()
    {
        foreach (string task in tasks)
        {
            yield return task;
        }
        
    }
}
