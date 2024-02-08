using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counto : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI numbertext;
    int counter=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void buttonPressed(){
        counter++;
        numbertext.text=counter+"";
    }
}
