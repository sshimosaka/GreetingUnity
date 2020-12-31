using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateCheck : MonoBehaviour
{
    System.DateTime now;
    int nowMonth;
    int nowDay;
    //前回の起動日をロードする変数
    int oldMonth;
    int oldDay;

    public AudioClip voice_date0101;
    public AudioClip voice_date0115;
    public AudioClip voice_date0203;
    public AudioClip voice_date0211;
    public AudioClip voice_date0214;
    public AudioClip voice_date0303;
    public AudioClip voice_date0314;
    public AudioClip voice_date0319;
    public AudioClip voice_date0401;
    public AudioClip voice_date0421;
    public AudioClip voice_date0422;
    public AudioClip voice_date0503;
    public AudioClip voice_date0504;
    public AudioClip voice_date0505;
    public AudioClip voice_date0602;
    public AudioClip voice_date0707;
    public AudioClip voice_date0720;
    public AudioClip voice_date0813;
    public AudioClip voice_date0915;
    public AudioClip voice_date0922;
    public AudioClip voice_date1008;
    public AudioClip voice_date1010;
    public AudioClip voice_date1103;
    public AudioClip voice_date1123;
    public AudioClip voice_date1224;
    public AudioClip voice_date1225;
    public AudioClip voice_date1231;
    private AudioSource univoice;
    public AudioClip[,] voice_date;
    // Start is called before the first frame update
    void Start()
    {
        //前回の起動日をロード
        oldMonth = PlayerPrefs.GetInt("Month");
        oldDay = PlayerPrefs.GetInt("Day");
        //Debug.Log("前回起動日:" + oldMonth + "月" + oldDay + "日");

        //現在の日時を取得
        now = System.DateTime.Now;
        nowMonth = now.Month;
        nowDay = now.Day;
        univoice = GetComponent<AudioSource>();

        //今回の起動日をセーブ
        PlayerPrefs.SetInt("Month", now.Month);
        PlayerPrefs.SetInt("Day", now.Day);

        //univoice.PlayOneShot(voice_date0101);
        voice_date = new AudioClip[12 + 1, 31 + 1];
        voice_date[1, 1] = voice_date0101;
        voice_date[1, 15] = voice_date0115;
        voice_date[2, 3] = voice_date0203;
        voice_date[2, 11] = voice_date0211;
        voice_date[2, 14] = voice_date0214;
        voice_date[3, 3] = voice_date0303;
        voice_date[3, 14] = voice_date0314;
        voice_date[3, 19] = voice_date0319;
        voice_date[4, 1] = voice_date0401;
        voice_date[4, 21] = voice_date0421;
        voice_date[4, 22] = voice_date0422;
        voice_date[5, 3] = voice_date0503;
        voice_date[5, 4] = voice_date0504;
        voice_date[5, 5] = voice_date0505;
        voice_date[6, 2] = voice_date0602;
        voice_date[7, 7] = voice_date0707;
        voice_date[7, 20] = voice_date0720;
        voice_date[8, 13] = voice_date0813;
        voice_date[9, 15] = voice_date0915;
        voice_date[9, 22] = voice_date0922;
        voice_date[10, 8] = voice_date1008;
        voice_date[10, 10] = voice_date1010;
        voice_date[11, 3] = voice_date1103;
        voice_date[11, 23] = voice_date1123;
        voice_date[12, 24] = voice_date1224;
        voice_date[12, 25] = voice_date1225;
        voice_date[12, 31] = voice_date1231;
        if(oldMonth != nowMonth || oldDay != nowDay)
        {
            //該当ボイスがあるかをチェック
            if (voice_date[nowMonth, nowDay] != null)
            {
                univoice.PlayOneShot(voice_date[nowMonth, nowDay]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
