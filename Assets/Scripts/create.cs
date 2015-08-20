//TODO

/*Make the walls come down in a grid
 * Set up some GUI showing what skill you're using
 */

using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class create : MonoBehaviour {
	
	public GameObject firewall;
	private Transform hitTransform;
	Vector3 hitPoint;
	Ray ray;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
			hitTransform = FindClosestHit(ray, out hitPoint);
			
			if(hitTransform != null && hitTransform.name == "level1" )
			{
				//Debug.Log("You hit: " + hitTransform.name + " at " + hitPoint);
				Instantiate (firewall, hitPoint, Quaternion.identity);
			}
			
		}

		if (Input.GetButtonDown ("Fire2")) 
		{
			ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
			hitTransform = FindClosestHit(ray, out hitPoint);

			if (hitTransform != null && hitTransform.name != "level1")
			{
				useSkill();
			}
		}
	}
	
	Transform FindClosestHit(Ray ray, out Vector3 hitPoint)
	{
		RaycastHit[] hits;
		hits = Physics.RaycastAll(ray);

		Transform closestHit = null;
		float distance = 0f;
		hitPoint = Vector3.zero;
		
		foreach(RaycastHit hit in hits)
		{
			if (hit.transform != this.transform && (closestHit == null || hit.distance < distance))
			{
				closestHit = hit.transform;
				distance = hit.distance;
				hitPoint = hit.point;
			}
		}
		return closestHit;
	}

	void useSkill()
	{
		SkillHandler handler = GameObject.FindObjectOfType(typeof(SkillHandler)) as SkillHandler;
		if (handler.active >= 0)
		{
			handler.skills[handler.active].effect();
		}
	}
}
