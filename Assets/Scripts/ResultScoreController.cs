using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ResultScoreController : MonoBehaviour
{
	[SerializeField]GameObject ResultScore;
	private void Update()
	{
		// ポイント表示
		int length = GameManager.Point;
		ResultScore.GetComponent<TextMeshProUGUI>().text = "Score:" + length.ToString("D4") + "pt";
	}
}
