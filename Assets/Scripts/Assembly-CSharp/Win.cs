using UnityEngine;

public class Win : MonoBehaviour
{
	public float win = 2f;

	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.GetComponent<Health>().getHealth(win);
	}
}
