using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRules : MonoBehaviour
{
    public GameObject RulesUI;
    public bool showUI = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnButtonClick()
    {
        showUI = !showUI;
        if (showUI)
        {
            RulesUI.SetActive(true);
        }
        else
        {
            RulesUI.SetActive(false);
        }
    }

    public void OnOtherButtonClick()
    {
        if (showUI==true)
        {
            RulesUI.SetActive(false);
            showUI = false;
        }
 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
