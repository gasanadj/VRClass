using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public bool isVisible = false;
    void Start()
    {
        canvas.SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggelCanvas()
    {
        isVisible = !isVisible;
        canvas.SetActive(!isVisible);
    }
}
