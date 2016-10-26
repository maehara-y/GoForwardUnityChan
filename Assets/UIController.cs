using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	private GameObject gameOverText;	// ゲームオーバテキスト
	private GameObject runLengthText;	// 走行距離テキスト
	private float len = 0;				// 走った距離
	private float speed = 0.03f;		// 走る速度
	private bool isGameOver = false;	// ゲームオーバの判定

	// Use this for initialization
	void Start () {
		this.gameOverText  = GameObject.Find ("GameOver");
		this.runLengthText = GameObject.Find ("RunLength");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isGameOver == false) {
			// 走った距離を更新する
			this.len += this.speed;
			// 走った距離を表示する
			this.runLengthText.GetComponent<Text> ().text = "Distance:  "  + len.ToString ("F2") + "m";
		}

		// ゲームオーバになった場合
		if (this.isGameOver){
			// クリックされたらシーンをロードする（追加）
			if (Input.GetMouseButtonDown (0)){
				//GameSceneを読み込む（追加）
				SceneManager.LoadScene ("GameScene");
			}
		}
	}

	public void GameOver()        {
		// ゲームオーバになったときに、画面上にゲームオーバを表示する
		this.gameOverText.GetComponent<Text>().text = "GameOver";
		this.isGameOver = true;
	}
}
