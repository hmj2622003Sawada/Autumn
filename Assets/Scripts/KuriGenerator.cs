using UnityEngine;

public class KuriGenerator : MonoBehaviour
{
	[SerializeField] GameObject KuriPrefab;
	[SerializeField] GameObject player;
	[SerializeField] GameObject gameManager;
	[SerializeField] float span = 1.0f;
	[SerializeField] float delta = 0;

	private void Update()
	{
		delta += Time.deltaTime;
		if(delta>span)
		{
			delta = 0;
			GameObject go = Instantiate(KuriPrefab);
			go.transform.SetParent(transform);
			go.GetComponent<KuriController>().SetPlayer(player);
			go.GetComponent<KuriController>().SetGameManager(gameManager);
			int px = Random.Range(-6, 6);
			go.transform.position = new Vector3(px, 6, 0);
			
		}
	}
}
