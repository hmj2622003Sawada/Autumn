using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
	private void Update()
	{
		if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("RuleScene");
		}
	}
}
