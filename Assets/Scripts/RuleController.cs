using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RuleController : MonoBehaviour
{
	private void Update()
	{
		if (Keyboard.current.enterKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("GameScene");
		}
	}
}
