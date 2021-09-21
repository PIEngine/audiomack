using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour {
	
	public GameObject personPrefab;
	public int populationSize = 10;
	List<GameObject> population = new List<GameObject>();
	public static float elapsed = 0;

	void Start(){
		for(int i =0; i< populationSize; i++){
			Vector3 pos = new Vector3(Random.Range(-9, 9), Random.Range(-4.5f, 4.5f), 0); // Returns Min(inclusive) and Max(exclusive)
			GameObject go = Instantiate(personPrefab, pos, Quaternion.identity);
			go.GetComponent<DNA>().r = Random.Range(0.0f, 1.0f);
			go.GetComponent<DNA>().g = Random.Range(0.0f, 1.0f);
			go.GetComponent<DNA>().b = Random.Range(0.0f, 1.0f);
			population.Add(go);
		}
	}

	void Update(){

	}
	
}
