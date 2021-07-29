using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCanvasListener : MonoBehaviour
{
	public void OnClickBackBtn()
	{
		SceneManager.LoadScene("IntroScene");
	}
}
