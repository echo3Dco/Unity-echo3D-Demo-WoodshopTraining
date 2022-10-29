using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Starts the Garage Scene to begin training
public class StartTrainingScene : MonoBehaviour
{
    void Start()
    {
        Invoke("StartTraining", 3.0f);
    }

    void StartTraining()
    {
        SceneManager.LoadScene("GarageScene");
    }
}
