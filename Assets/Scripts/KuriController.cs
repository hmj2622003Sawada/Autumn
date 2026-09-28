using UnityEngine;

public class KuriController : MonoBehaviour
{
	[SerializeField] GameObject player;
	private void Update()
	{
		// フレームごとに等速落下
		transform.Translate(0, -0.1f, 0);

		// 画面外に出たら廃棄
		if(transform.position.y < -5.0f)
		{
			Destroy(gameObject);
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
			Destroy(gameObject);
		}

	}
}
