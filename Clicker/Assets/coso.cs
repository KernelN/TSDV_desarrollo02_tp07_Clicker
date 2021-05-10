using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coso : MonoBehaviour
{
	public static int sc = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if (sc > 1000)
	    {
			SceneManager.LoadScene(2);
	    }

	}
}
