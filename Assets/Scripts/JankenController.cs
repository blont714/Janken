using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankenController : MonoBehaviour
{
    public GameObject Goo;
    public GameObject Choki;
    public GameObject Paa;
    public GameObject MyGoo;
    public GameObject MyChoki;
    public GameObject MyPaa;

    public void OnClickGoo()
    {
      this.MyGoo.SetActive(true);
      this.MyChoki.SetActive(false);
      this.MyPaa.SetActive(false);
      this.EnemyHand();
    }
    
    public void OnClickChoki()
    {
      this.MyGoo.SetActive(false);
      this.MyChoki.SetActive(true);
      this.MyPaa.SetActive(false);
      this.EnemyHand();
    }

    public void OnClickPaa()
    {
      this.MyGoo.SetActive(false);
      this.MyChoki.SetActive(false);
      this.MyPaa.SetActive(true);
      this.EnemyHand();
    }



    // Start is called before the first frame update
    public void EnemyHand()
    {
        this.Goo.SetActive(false);
        this.Choki.SetActive(false);
        this.Paa.SetActive(false);

        // 1:ぐー　2:ちょき　3:ぱー
        int rand = Random.Range(1, 4);
        if(rand == 1){
            this.Goo.SetActive(true);
        }else if(rand == 2){
            this.Choki.SetActive(true);
        }else if(rand == 3){
            this.Paa.SetActive(true);
        }
    }
  }
