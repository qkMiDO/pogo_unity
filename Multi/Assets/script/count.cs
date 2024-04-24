using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//level 1
public class count : MonoBehaviour
{
    Text Text;
    public static int scor = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor.ToString();    
    }
  
}
