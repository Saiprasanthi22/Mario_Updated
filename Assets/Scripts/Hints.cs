using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{
    // Start is called before the first frame update
   
    private float time;
    private TMPro.TextMeshProUGUI text;
   
  
    void Awake()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
         time = 1 + Time.deltaTime;
}


    void Start()
    {
        
            StartCoroutine(HintTracker());
        
        
    }

    IEnumerator HintTracker()
    {
        
        if (time > 1)
        {
            text.text = "Use Arrows keys to move left and right";
        }
        yield return new WaitForSeconds(2f);
        time += 1;
        if (time > 2)
        {
            text.text = "Press SpaceBar to jump";
        }
        yield return new WaitForSeconds(2f);
        time += 1;
        if (time > 3)
        {
            text.text = "In powerup mode, when Mario is Read,Press CTRL to fire";
        }
        yield return new WaitForSeconds(2f);
        time += 1;
        if(time > 4)
        {
            text.text = "";
        }





    }
}
