using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacensFn : MonoBehaviour
{
    string btnName;
    public GameObject predio;
    public Button botao;
    
    // Start is called before the first frame update
    void Start()
    {

        predio.SetActive(false);
        botao.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;

                if (btnName == "btnC")
                {
                    predio.SetActive(true);
                    botao.gameObject.SetActive(true);
                }

            }
        }
    }
    public void Hide()
    { 
            predio.SetActive(false);
            botao.gameObject.SetActive(false);
        //GameObject.FindGameObjectWithTag("btnRestart").SetActive(false);
    }
}
