using UnityEngine;
using System.Collections;

public class ShipTypeManager : MonoBehaviour
{
	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		singleton = this;
	}
	
	static ShipTypeManager singleton;

	public ShipType[] tanks;
	
	static public ShipType Random()
	{
		int index = UnityEngine.Random.Range(0,singleton.tanks.Length);
		return singleton.tanks[index];
	}
	
	static public ShipType Lookup(string name)
	{
		foreach (var tt in singleton.tanks)
		{
			if (tt.ShipTypeName == name)
				return tt;
		}
		return null;
	}
}
