using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[SerializeField] GameObject hpGauge;
	public static int Hp = 10;
	public static int Point = 0;

	public void DecreaseHp()
	{
		if (KuriController.dropflag == true)
		{
			// Á–Å(—‰ºI‚í‚è‚É)‘Ì—Í‚ğŒ¸‚ç‚·
			hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
		}
	}

	public void CacthKuri()
	{
		Point = Point + 1;
	}

	private void Update()
	{
		if(Hp == 0)
		{
			SceneManager.LoadScene("ResultScene");

			// ü‰ñ‰Â”\‚É‚·‚é‚½‚ß‚ÉHp‚ğ–ß‚·
			Hp = Hp + 10;
			hpGauge.GetComponent<Image>().fillAmount = hpGauge.GetComponent<Image>().fillAmount + 1.0f;
		}
	}
}
	
