using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

        //得点を表示するテキスト
        private GameObject pointText;

        //得点
        private int point = 0;


        // Use this for initialization
        void Start () {

                //シーン中のPointTextオブジェクトを取得
                this.pointText = GameObject.Find("PointText");
        }

        //衝突時に呼ばれる関数
        void OnCollisionEnter(Collision other) {
                
                if (other.gameObject.CompareTag("SmallStarTag")) {
                        this.point += 10;
                }
                else if (other.gameObject.CompareTag("LargeStarTag")) {
                        this.point += 5;
                }
                else if (other.gameObject.CompareTag("SmallCloudTag")) {
                        this.point += 50;
                }
                else if (other.gameObject.CompareTag("LargeCloudTag")) {
                        this.point += 75;
                }

                this.pointText.GetComponent<Text> ().text = "Point:" + this.point.ToString();
        }
}