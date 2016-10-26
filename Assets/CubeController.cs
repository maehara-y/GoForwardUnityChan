using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	private AudioSource se;
	private float speed = -0.2f;	// キューブの移動速度
	private float deadLine = -10;	// 消滅位置

	// Use this for initialization
	void Start () {
		this.se = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		this.transform.Translate(this.speed, 0, 0);
		// 画面外に出たら破棄する
		if (this.transform.position.x < this.deadLine) Destroy(this.gameObject); 
	}

	void OnCollisionEnter2D (Collision2D other) {
		// ユニティちゃん以外との衝突時い、効果音再生
		if (other.gameObject.tag != "UnityChan2DTag") {
			se.Play ();
		}
	}
}
