using UnityEngine;

public class Damage : MonoBehaviour
{
	public float damage = 2f;

	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.GetComponent<Health>().getDamage(damage);
	}
}
