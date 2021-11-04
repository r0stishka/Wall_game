using UnityEngine;

public class Rotate1 : MonoBehaviour
{
	public GameObject target;

	public float rotation = 90f;

	public void posZ()
	{
		base.transform.Rotate(0f, 0f, rotation);
	}

	public void negZ()
	{
		base.transform.Rotate(0f, 0f, 0f - rotation);
	}

	public void posX()
	{
		base.transform.Rotate(rotation, 0f, 0f);
	}

	public void negX()
	{
		base.transform.Rotate(0f - rotation, 0f, 0f);
	}

	public void posY()
	{
		base.transform.Rotate(0f, rotation, 0f);
	}

	public void negY()
	{
		base.transform.Rotate(0f, 0f - rotation, 0f);
	}
}
