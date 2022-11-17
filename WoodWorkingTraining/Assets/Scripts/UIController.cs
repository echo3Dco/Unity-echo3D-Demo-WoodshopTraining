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
        Invoke("InstructionChange", 8.0f);
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
                if (hit.transform.name == "WrenchParent")
                {
                    wrenchUI.SetActive(false);
                    axeUI.SetActive(true);
                }

                if (hit.transform.name == "AxeParent")
                {
                    axeUI.SetActive(false);
                    measuringTapeUI.SetActive(true);
                   
                }

                if (hit.transform.name == "MeasuringTapeParent")
                {
                    measuringTapeUI.SetActive(false);
                    screwdriverUI.SetActive(true);
                }

                if (hit.transform.name == "ScrewdriverParent")
                {
                    screwdriverUI.SetActive(false);
                    goodJobUI.SetActive(true);
                }
            }
        }
    }
}
