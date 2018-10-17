using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class API_HGWeather : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string uri = "https://api.hgbrasil.com/weather/?format=json&woeid=455822";

        StartCoroutine(CarregarDadosClima(uri));
	}
	
    IEnumerator CarregarDadosClima(string uri)
    {
        UnityWebRequest request = UnityWebRequest.Get(uri);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("Erro ao conectar API");

        }
        else
        {
            string response = request.downloadHandler.text;

            RootObject infoClima = JsonUtility.FromJson<RootObject>(response);

            Debug.Log("Cidade:" + infoClima.results.city_name);
            Debug.Log("Temperatura:" + infoClima.results.temp);
        }
    }
	
}
