using UnityEngine;
using System.Collections;


class suma
{
	public int[] sumando1 = new int[] {1,2,3,4,5,6,7,8,9,10};
	public int[] sumando2 = new int[] {1,2,3,4,5,6,7,8,9,10};
	public string[] signo = new string[]{"+","-"};

	public int num1()
	{
		return sumando1[Random.Range(0,11)];
	}
	public int num2()
	{
		return sumando2[Random.Range(0,11)];
	}
	public string sign()
	{
		return signo[Random.Range(0,2)];
	}

	public int Operacion(int n1, int n2, string s)
	{
		if (s.Contains ("+")) {
			return n1 + n2;
		} else {
			return n1 - n2;
		}
	}
}

public class ActSuma : MonoBehaviour {

	// Use this for initialization
	void Start () {

		suma s = new suma ();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
