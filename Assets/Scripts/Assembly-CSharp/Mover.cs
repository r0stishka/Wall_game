using UnityEngine;

public class Mover : MonoBehaviour
{
	public float speed;

	private void Update()
	{
		base.transform.Translate(Vector3.back * Time.deltaTime * speed);
	}
}
