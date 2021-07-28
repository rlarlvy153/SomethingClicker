using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasListener : MonoBehaviour
{
	public void OnClickStartBtn()
	{
		SceneManager.LoadScene("MainScene");
	}
}
