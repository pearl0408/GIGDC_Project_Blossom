using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchWriter : MonoBehaviour
{
    //�۰� �̸��� ������ִ� ��ũ��Ʈ
    public char[] writerName = { '��', '��', '��', '��', '��', '��', '��', '��', '��' }; //�۰� �̸�
    public Button charButton;   //������ ���� ��ư

    private float XPosition;    //���� X ��ǥ(-300 ~ 300 ����)
    private float YPosition;    //���� Y ��ǥ(-250 ~ 250 ����)

    public Text text_Keyword;   //Ű���� �Է�â

    //������ �����ϸ�
    void Start()
    {
        ResetButton();  //��ư ���� �� �˻��� �ʱ�ȭ
    }

    //�˻� ��ư�� ���� ������ �˻���� �ܾ� ��ġ�� �ʱ�ȭ
    public void ResetButton()
    {
        text_Keyword.text = "";  //�˻�â �ʱ�ȭ

        //���� ��ư���� ���� ��ġ�� ������
        for (int i = 0; i < writerName.Length; i++)
        {
            XPosition = Random.Range(200, 900);    //X ��ǥ ����
            YPosition = Random.Range(350, 850);    //Y ��ǥ ����

            //��ư ����
            Button Btn_WriterName = (Button)Instantiate(charButton, new Vector2(XPosition, YPosition), Quaternion.identity);   //��ư ����

            GameObject myText = Btn_WriterName.gameObject.transform.GetChild(0).gameObject;  //��ư�� �ؽ�Ʈ ������Ʈ�� ������
            myText.GetComponent<Text>().text = writerName[i].ToString();  //�ؽ�Ʈ ����

            Btn_WriterName.gameObject.transform.SetParent(this.gameObject.transform); //���� ������Ʈ�� �ڽ� ������Ʈ�� ����
            Btn_WriterName.onClick.AddListener(() => TypingButtonText(myText)); //��ư Ŭ�� �̺�Ʈ �߰�
        }
    }

    //��ư�� ������ ��ư �ؽ�Ʈ �Էµ�
    public void TypingButtonText(GameObject myText)
    {
        string text = myText.GetComponent<Text>().text;
        text_Keyword.text += text;    //�˻��� �ؽ�Ʈ�� �ڽ��� �ؽ�Ʈ�� �߰���
    }
}