using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
	public BirdsJump BirdScript;
    public GameObject Borular;
    public float height;
	public float time;
	public void Start()
	{
		StartCoroutine/*ürekli çağrılma durumu yerine, verdiğimiz sürelerde beklemeye geçip, komutlarımızın çalışmasını sağlamaktadır*/(ObjectSpawn(time));
	}
	public IEnumerator/*sureli seyleri kullanmak icin bu ucubeyi kullaniyoruz*/ ObjectSpawn(float time)
	{
        while (BirdScript.isDead == false) 
        {
			
			Instantiate/*objeleri tekrar tekrar oluşturmak yerine bir defa oluşturup sahnede bu objeyi kullanmamıza yarar*/(Borular, new Vector3(3,Random.Range(-height,height),0), Quaternion.identity /*objenin konumunu 0,0,0 a çekiyor*/);
			yield /* bu yield da delay atar*/ return new WaitForSeconds(time);
		}
	}
}
