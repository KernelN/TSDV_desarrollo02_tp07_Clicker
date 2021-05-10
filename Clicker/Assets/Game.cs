using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
	public GameObject click01;
	public GameObject click02;
	public GameObject click03;

	public TMP_Text t;

	public GameObject click04;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    t.text = "Gold:" + coso.sc;

	    if (coso.sc > 10)
	    {
		    click01.SetActive(true);
	    }
	    else
	    {
		    click01.SetActive(false);
	    }
		if (coso.sc > 50)
	    {
		    click02.SetActive(true);
		}
	    else
	    {
			click02.SetActive(false);
		}
		if (coso.sc > 100)
		{
			click03.SetActive(true);
		}
		else
		{
			click03.SetActive(false);
		}
	    if (coso.sc > 200)
	    {
		    click04.SetActive(true);
	    }
	    else
	    {
		    click04.SetActive(false);
		}
	}

	public void Click01()
	{
		coso.sc += 1;
	}

	public void Click02()
	{
		coso.sc += 2;
	}

	public void Click03()
	{
		coso.sc += 5;
	}

	public void Click04()
	{
		coso.sc += 10;
	}

	public void Click05()
	{
		coso.sc += 50;
	}
}
