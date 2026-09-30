using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestultController : MonoBehaviour
{
	private void Update()
	{
		if (Keyboard.current.enterKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("TitleScene");
		}
	}
}
