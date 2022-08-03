using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroname = "superman";
    string villainname ="batman";
    int heropower = 19;
    int villainpower = 20;
    float playerspeed = 2.9f;
    
    // Start is called before the first frame update
    void Start()
    {
        if (villainpower > heropower)
        {
            print("the villani is more powerful");
        }
        else
        {
            print("the hero is more powerful");
        }
        print(playerspeed);
        setspeed();
        print(playerspeed);
    }
    void setspeed()
    {
        playerspeed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
