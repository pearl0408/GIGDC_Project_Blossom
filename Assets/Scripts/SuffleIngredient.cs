using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuffleIngredient : MonoBehaviour
{
    //마트 어플에서 재료 목록을 랜덤으로 섞는 함수

    public Button[] IngredientList;   //재료 버튼 목록

    void Start()
    {
        Shuffle(IngredientList);  //배열 셔플

        //재료 버튼 생성
        for (int i = 0; i < IngredientList.Length; i++)
        {
            //버튼 생성
            Button Btn_Ingredient = (Button)Instantiate(IngredientList[i]);   //버튼 생성
            Btn_Ingredient.gameObject.transform.SetParent(this.gameObject.transform); //현재 오브젝트의 자식 오브젝트로 생성
        }
    }

    //셔플 함수
    void Shuffle(Button[] btnArray)
    {
        int random1, random2;   //인덱스
        Button tempBtn; //임시 버튼

        for (int i = 0; i < btnArray.Length; i++)
        {
            random1 = Random.Range(0, btnArray.Length);    //랜덤 인덱스 생성
            random2 = Random.Range(0, btnArray.Length);    //랜덤 인덱스 생성

            tempBtn = btnArray[random1];    //임시 버튼 저장
            btnArray[random1] = btnArray[random2];  //버튼 변경
            btnArray[random2] = tempBtn;    //임시 버튼 변경
        }
    }
}
