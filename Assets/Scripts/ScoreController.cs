using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
	[SerializeField] GameObject Score;
	private void Update()
	{
		int length = GameManager.Point;
		Score.GetComponent<TextMeshProUGUI>().text = "Score:" + length.ToString("D4") + "pt";
	}
}
