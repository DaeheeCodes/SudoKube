using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{

    public GameObject Panel;

    void Start()
    {
        Panel.gameObject.SetActive(false);
    }

    public void ClosePanel()
    {
        Panel.gameObject.SetActive(false);
    }

    public void ShowPanel()
    {
        Panel.gameObject.SetActive(true);
    }

}
