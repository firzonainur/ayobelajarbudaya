using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swipe_control : MonoBehaviour
{
    public GameObject scrollbar;
    float scroll_post = 0;
    float[] pos; // array untuk menyimpan posisi tiap-tiap objek 
    int posisi = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void next()
    {
        if (posisi < pos.Length - 1)
        {
            posisi += 1;
            scroll_post = pos[posisi];
        }
    }

    public void prev()
    {
        if (posisi > 0)
        {
            posisi -= 1;
            scroll_post = pos[posisi];
        }
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_post = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_post < pos[i] + (distance / 2) && scroll_post > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.5f);
                    posisi = i;
                }
            }
        }

        
    }
}
