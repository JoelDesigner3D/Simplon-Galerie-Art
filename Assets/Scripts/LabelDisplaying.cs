using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class LabelDisplaying : MonoBehaviour
{
 
[SerializeField] private GameObject infosCanvas; 


    void Start()
    {
       infosCanvas.SetActive(false);
    }


    private void OnMouseEnter()
    {
        Debug.Log("Mouse enter");
        infosCanvas.SetActive(true);
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        infosCanvas.SetActive(false);

    }

   

}
