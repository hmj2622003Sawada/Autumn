using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	private void Start()
	{
		Application.targetFrameRate = 60;
	}

	private void Update()
	{
		// ¶‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
		if(Keyboard.current.leftArrowKey.wasPressedThisFrame)
		{
			transform.Translate(-2, 0, 0);
		}
		// ‰E‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
		if(Keyboard.current.rightArrowKey.wasPressedThisFrame)
		{
			transform.Translate(2, 0, 0);
		}

		// ‰æ–ÊŠO‚Éo‚È‚¢‚æ‚¤‚É‚·‚é
		Vector3 pos = transform.position;
		pos.x = Mathf.Min(pos.x, 6.0f);
		pos.x = Mathf.Max(pos.x, -6.0f);
		transform.position = pos;
	}
}
