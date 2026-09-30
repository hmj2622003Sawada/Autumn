using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KuriController : MonoBehaviour
{
	GameObject player;
	GameObject gameManager;
	public static bool dropflag = false;

	public void SetPlayer(GameObject p) { player  = p; }
	public void SetGameManager(GameObject gm) { gameManager = gm; }
	private void Update()
	{
		// フレームごとに等速落下
		transform.Translate(0, -0.1f, 0);

		// 画面外に出たら廃棄
		if(transform.position.y < -5.0f)
		{
			// 落下したらフラグを立てて、hpを削る
			dropflag = true;
			// 衝突
			gameManager.GetComponent<GameManager>().DecreaseHp();
			GameManager.Hp = GameManager.Hp - 1;
			Destroy(gameObject);
			dropflag = false;
		}

		// 当たり判定
		Vector2 p1 = transform.position;		// 栗の中心
		Vector2 p2 = player.transform.position; // プレイヤーの中心
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.5f;
		float r2 = 1.0f; 

		if(d < r1 + r2)
		{
			gameManager.GetComponent<GameManager>().CacthKuri();
			Destroy(gameObject);
		}

	}
}
