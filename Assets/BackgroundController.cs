using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	private float scrollSpeed = -0.03f;	// スクロール速度
	private float deadLine = -16;		// 背景終了位置
	private float startLine = 15.8f;	// 背景開始位置

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 背景を移動する
		transform.Translate (this.scrollSpeed, 0, 0);
	
		// 画面外に出たら、画面右端に移動する
		if (this.transform.position.x < this.deadLine) {
			this.transform.position = new Vector2 (this.startLine, 0);
		}
	}
}
