using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	
	bool leftflag = false;
	bool rightflag = false;
	private void Start()
	{
		Application.targetFrameRate = 60;
	}

	private void Update()
	{
		
		// ¶‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
		if(Keyboard.current.leftArrowKey.wasPressedThisFrame && leftflag == false)
		{
			transform.Translate(-2, 0, 0);
		}
		// ‰E‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
		if(Keyboard.current.rightArrowKey.wasPressedThisFrame && rightflag == false)
		{
			transform.Translate(2, 0, 0);

		}

		Vector3 pos = transform.position;

		pos.x = Mathf.Min(pos.x, 6.0f);
		pos.x = Mathf.Max(pos.x, -6.0f);

		transform.position = pos;
	}
}
