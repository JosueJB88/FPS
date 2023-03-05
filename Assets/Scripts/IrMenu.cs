using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IrMenu : MonoBehaviour
{
    public Button BTNpreserLV;
	// Start is called before the first frame update
	void Start()
	{
		BTNpreserLV.onClick.AddListener(LVpreservativos);
	}

	void LVpreservativos()
	{

		SceneManager.LoadScene("Menu");
	}
}
