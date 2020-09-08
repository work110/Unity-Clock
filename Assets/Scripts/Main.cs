using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public GameObject Timetext;
    public GameObject Ison;

    public GameObject Audiosource;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DateTime.Now.Minute % 60);

        Ison.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
        Timetext.GetComponent<Text>().text= DateTime.Now.ToString();
        Audiosource.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        UITimeUpdate();
    }



    void UITimeUpdate() {

        Timetext.GetComponent<Text>().text = DateTime.Now.ToString();

        if (DateTime.Now.Minute % 60 == 0 && Ison.GetComponent<Toggle>().isOn == false) {
            Audiosource.GetComponent<AudioSource>().Play();
            Ison.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
        }

        if (DateTime.Now.Minute % 1 == 0 && Ison.GetComponent<Toggle>().isOn == true)
        {
            Audiosource.GetComponent<AudioSource>().Play();
            Ison.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
        }
    }
}
