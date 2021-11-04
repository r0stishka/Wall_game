using System.Collections;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(Rotate(Vector3.up, 90f));
		}
	}

	private IEnumerator Rotate(Vector3 axis, float angle, float duration = 1f)
	{
		Quaternion from = base.transform.rotation;
		Quaternion to = base.transform.rotation;
		to *= Quaternion.Euler(axis * angle);
		float elapsed = 0.8f;
		while (elapsed < duration)
		{
			base.transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
			elapsed += Time.deltaTime;
			yield return null;
		}
		base.transform.rotation = to;
	}
}
