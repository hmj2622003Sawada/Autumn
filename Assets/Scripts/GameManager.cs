using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
	[SerializeField] GameObject hpGauge;
	 

	public void DecreaseHp()
	{
		hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
