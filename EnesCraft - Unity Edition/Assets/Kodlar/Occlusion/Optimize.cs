using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimize : MonoBehaviour
{
    Renderer MyRend;
    public float DisplayTime;

    // Start is called before the first frame update
    private void OnEnable()
    {
        MyRend = gameObject.GetComponent<Renderer>();
        DisplayTime = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayTime > 0)
        {
            DisplayTime -= Time.deltaTime;
            MyRend.enabled = true;
        } else
        {
            MyRend.enabled = false;

        }
    }

    public void HitOptimize(float time)
    {
        DisplayTime = time;
        MyRend.enabled = true;
    }
}
