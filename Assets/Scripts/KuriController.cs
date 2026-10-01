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
	}

	 private void OnTriggerEnter2D(Collider2D collision)
	{
		gameManager.GetComponent<GameManager>().CacthKuri();
		Destroy(gameObject);
	}
}
