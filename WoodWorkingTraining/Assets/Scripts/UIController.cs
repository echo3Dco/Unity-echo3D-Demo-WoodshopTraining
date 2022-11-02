using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Controls the UI interactions and timing
public class UIController : MonoBehaviour
{
    public GameObject instructionScreenUI;
    public GameObject wrenchUI;
    public GameObject axeUI;
    public GameObject measuringTapeUI;
    public GameObject screwdriverUI;
    public GameObject goodJobUI;

    void Start()
    {
        Invoke("InstructionChange", 5.0f);
    }

    void InstructionChange()
    {
        instructionScreenUI.SetActive(false);
        wrenchUI.SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
               if (hit.transform.name == "Wrench")
                {
                    wrenchUI.SetActive(false);
                    axeUI.SetActive(true);
                }

                if (hit.transform.name == "Axe")
                {
                    axeUI.SetActive(false);
                    measuringTapeUI.SetActive(true);
                   
                }

                if (hit.transform.name == "MeasuringTape")
                {
                    measuringTapeUI.SetActive(false);
                    screwdriverUI.SetActive(true);
                }

                if (hit.transform.name == "Screwdriver")
                {
                    screwdriverUI.SetActive(false);
                    goodJobUI.SetActive(true);
                }
            }
        }
    }
}
