using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class letter : MonoBehaviour
{
    List<string> _list = new List<string>();
    public int count = 0;
    public TextMeshProUGUI TMGui;
    public string mission;
    public string todayLetter;
    // Start is called before the first frame update
    void Start()
    {

        string str;
        str = " 동지여,\n 우리와 함께하기로 결정한것에 대하여 감사를 표하는 바이네. ";
        _list.Add(str);
        str = " 동지여,\n 부탁을 하나 들어주었으면 하네, 최근 우리 결사단의 단원중 하나가 임시정부를 조직하기 위한 단체에 들어갔다 하더군, 우리는 이들을 지원하기로했네. 때문에, 우리는 전보다 더 많은 단원들과 더 많은 자금이 필요하다네.때문에 자네또한 우리를 도와 단원들과 독립자금을 모아야 하네. 할당량은 주기적으로 편지를 통해 보내질걸세";
        _list.Add(str);
        str = " 놈들이 우리의 움직임을 눈치챈 모양이네 최근 감시의 강도가 높아졌다는것을 동지또한 느꼈을걸세. 앞으로는 놈들에게 우리의 행동을 들키지않도록 조심, 또 조심해야하네 놈들은 피도 눈물도 없는 악귀들이니 말이네"
        +"참, 그렇지 자네도 나처럼 활동하지 않는 동지들" +
        "에게 놈들의 동향을 파악하는 편지를 보내달라고" +
        "하지 않겠나? 이런 상황에서는 정보가 유용하게" +
        "쓰일걸세";

        _list.Add(str);
        str = " 동지여,\n 기쁜 소식이 있네 이번 파리 평화 회의"+
"에서 민족자결주의에 대해 논의한다는 이야기가"+
"있네 듣기에는 독립청원서를 제출하기위해 이번 "+
"회의에 참가하는 미국 대통령을 찾아갔다고도 하니, "+
"우리나라의 독립도 머지않아 찾아오게 될걸세";
        _list.Add(str);
        str = " 동지여,\n 소식을 들었는가. 우리는 아무것도 할 수 " +
"없었네 정말로 아무것도 할 수 없었어. 이번 파리" +
"회의에서 나라를 잃은 백성이 할 수 있었던 일은 " +
"아무것도 없었단 말이네. 그리도 학수고대한 평화" +
"회의는 평화라는 허울을 쓴 전쟁터였다네. 하지만 " +
"우리는 이대로 좌절하고 있지는 않을걸세 우리는 " +
"우리의 손으로 우리 나라를 되찾을걸세 조만간 " +
"신문을 통해 사람들을 모을 생각이네.";
        _list.Add(str);
        str = " 좋은 소식이 있어 이렇게 오랜만에 연락을 하게"+
"되었네. 드디어 상해에 대한민국의 임시정부가 설"+
"립되었다네. 아직 모든것이 부족하지만 만세운동"+
"을 하고있는 지금이 임시정부를 세우는 적기라 생"+
"각하네. 우리가 여기까지 온 것은 모든 결사단원이"+
"열심히해준 덕분이야. 자네에게도 큰 감사를 전하"+
"고 싶네. 정말로 고맙네.";
        _list.Add(str);
        str = "관리자님..";
        _list.Add(str);
        Debug.Log(_list.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void letterOn()
    {
        TMGui.text = _list[count];
    }

    public void goNext()
    {
        if (count < _list.Count-1) 
            TMGui.text = _list[++count];
    }

    public void goPrev()
    {
        if (count > 0) 
            TMGui.text = _list[--count];
    }
}
