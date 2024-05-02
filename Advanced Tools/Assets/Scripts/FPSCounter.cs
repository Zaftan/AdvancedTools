using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private float targetTime = 60.0f; //One Minute
    private List<float> log = new List<float>();
    private bool isLogging = true;

    private void Start()
    {
        StartCoroutine(Logger());

    }

    private IEnumerator Logger()
    {
        while (isLogging)
        {
            yield return new WaitForEndOfFrame();
            log.Add(Time.unscaledDeltaTime);
            
            targetTime -= Time.deltaTime;
            //Debug.Log(targetTime);
            
            if (targetTime <= 0.0f)
            {
                isLogging = false;
                CreateCSV();
                Debug.Log("Time's up!");
            }
        }
    }

    private void CreateCSV()
    {
        string CSV = "";
        foreach (var l in log)
        {
            CSV += l + ",";
        }
        
        var file = File.CreateText("FPSLog.csv");
        file.WriteLine(CSV);
        file.Close();
    }
}
