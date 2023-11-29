# SpartaTown (게더 클론)_TopDown 게임 만들기 프로젝트


</br>

## 제작 : 김국민

> Unity로 개발한 SpartaTown 만들기 프로젝트 입니다.  
> 개인 프로젝트이며, 유니티2D TopDown 게임을 개발한 내용입니다.  
> 필수 구현, 선택기능 구현 개발하였고, 개발 기간은 4일입니다.  
> 구현된 내용은 다음과 같습니다.

</br>

## 주요 기능

* 구현한 기능 목록(필수)
    * 캐릭터 만들기
    * 캐릭터 이동
    * 방 만들기
    * 카메라 따라가기

* 구현한 기능 목록(선택)
    * 캐릭터 애니메이션 추가
    * 이름 입력 시스템
    * 캐릭터 선택 시스템
    * 참석 인원 UI
    * 인게임 캐릭터 선택
    * 인게임 이름 바꾸기
    * 시간 표시
    * NPC 대화



## 기능 세부 설명
* 캐릭터 만들기 
    * 빈GameObject 만들고 안에 준비해둔 Image를 넣어서 만들었다. 
    
* 캐릭터 이동  
    * 유니티 InputSystem을 이용하여 (W, A, S, D)키에 상하좌우를
    각각 넣어주어 해결했다.
    * 캐릭터가 마우스를 바라보게 만들었는데, Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg; <br/>
    이걸 사용해서 각도를 구하고 입력값을 마우스와 캐릭터에 넘겨주고 좌우 반전을 걸어줬다.

* 방 만들기
    * 유니티 TileMap을 이용해서 맵을 만들고 꾸몄다.
    * 맵의 경계에 있는 타일들은 콜라이더를 걸어서 캐릭터가 나가지 못하게 만들었다.

* 카메라 따라가기
    * 유니티 패키지중 하나인 시네머신을 이용하여 만들었다.
    * 시네머신 중 버추얼 카메라를 이용하여 카메라가 플레이어를 따라가게 만들었다.
    * 각 방에 콜라이더로 경계를 설정하고 플레이어가 경계 안으로 들어갈 때 카메라가 스위치되는
    모습을 연출했다.

* 캐릭터 애니메이션 추가
    * 준비해둔 캐릭터 이미지를 여러개 겹쳐서 드래그 한다음 캐릭터 sprite에 넣어주면 <br/>
    자동으로 애니메이션이 만들어지고 애니메이터 애니메이션 세부 설정을 할 수 있다.
    * 가만히 있는 기능이랑 움직이는 기능은 애니메이터 내부에 파라메터를 Float값으로 하나 만들고 <br/> baseLayer에 우클릭 -> add Blend Tree
    해서 블렌드 트리 기능으로 손쉽게 설정 가능하다.

* 이름 입력 시스템
    * 유니티 hierarchy 우클릭 -> UI -> Input Field 로 만들 수 있는 인풋 필드 이용해서 작업했다.
    * 캔버스 -> 판넬 -> 인풋 필드, 버튼 순으로 만들어서 카메라에 고정시켰다.
    * 이름의 글자수가 2~10 가 아닐 경우에는 버튼을 누르지 못하게 만들었고  <br/>
    버튼을 누르면 판넬이 꺼지고 플레이어 머리위에 그 이름이 같이 적용되게 만들었다.

* 캐릭터 선택 시스템
    * 앞서 말한 캐릭터를 하나 더 만든 뒤 이름 입력하던 판넬 옆에 버튼으로 만들어줬다.
    * 버튼 이미지에 캐릭터를 넣어줘서 더 알기 쉽고 직관적으로 보이게 해줬다.
    * 해당 캐릭터(버튼)누르면 캐릭터 활성화, 다른 캐릭터는 비활성화를 걸어줘서 해결했다.

* 참석 인원 UI
    * 판넬을 하나 만들어주고 이름 입력하던 것을 그대로 받아와서 적히게 만들어 두었다. 

* 인게임 캐릭터 선택 / 인게임 이름 바꾸기
    * 게임 시작이 나오는 판넬을 버튼에 연결해서 다시 띄우게 만들어서 해결했다.

* 시간 표시
    * Datatime.Now로 현재시간을 년,월,일,시,분,초,오전,오후까지 알 수 있어서 사용했고,<br/>
    time += Time.deltaTime; 으로 인게임내 시간이 흐르게 해줬다.

* NPC 대화
    * Npc로 설정한 오브젝트에 콜라이더를 걸어 영역을 만들어주고 해당 영역에 캐릭터가 진입할시 <br/>
    해당 영역에 있던 '대화하기' 버튼이 활성화 되고 버튼 누를시 버튼 비활성화 대화창 열림 순으로 <br/>
    작업했다.



##  기술 스택

![Unity](https://img.shields.io/badge/-Unity-%23000000?style=flat-square&logo=Unity)
![C#](https://img.shields.io/badge/-C%23-%7ED321?logo=Csharp&style=flat)


### 게임 시작 화면

![GameStartScene](Images/a1.png)

* 현재 이름입력창에 아무것도 적지않아 버튼이 비활성화 된것을 볼 수 있다.
* 이름 입력창 옆에 있는 이미지를 클릭하면 캐릭터를 바꿀 수 있다.

<br/>

 __이름 입력시 버튼 활성화__  

![active](Images/a2.png)

* 이름을 입력하니 버튼이 활성화 되는걸 볼 수 있다.

<br/>

__캐릭터 선택__  

![select](Images/a3.png)

* 캐릭터 선택창이다.
* 원하는 캐릭터 선택시 시작화면 이미지가 바뀐다.

![select](Images/a4.png)

* 다른 캐릭터를 선택해도 이름이 유지되고 시작화면 이미지가 변경되는 모습이다.

<br>

__메인 화면__  

![MainScene](Images/a5.png)

* 이름 / 캐릭터 버튼을 누르면 시작판넬을 다시 불러올 수 있고, <br/>
    참석 인원 버튼을 누르면 유저와 Npc의 이름을 볼 수 있다.

__참석 인원__  

![Pause](Images/a6.png)

* 유저의 이름과 Npc의 이름이 잘 들어있다.
* 위의 x 버튼을 누르면 다시 비활성화 시킬 수 있다.

<br/>  

__Npc 대화__  

![Talk](Images/a7.png)

![NormalEndPanel](Images/a8.png)

* Npc에게 다가가면 '대화하기' 버튼이 활성화 되는걸 볼 수 있다.

![NormalEndPanel](Images/a9.png)

* 대화하기를 눌르면 대화창이 나온다. 아래 유저의 말로 정해진것을 누를시 대화창을 벗어 날 수 있다.
<br/>

<br>

__시간 표시__  

![Timer](Images/a10.png)

* 현재 시간을 보여주는 기능이다.






## 프로젝트 시 일어난 문제와 해결?

* 어렵다기 보다는 모르는 느낌이 많아서 많이 헤맸는데 결국 조금 알고 있던 기능으로 모든걸 만들었다. 

## 프로젝트 소감

* 이번 프로젝트는 유니티로 작업을 했는데 유니티라는 툴을 잘 다루지 못하고, 잘 알지 못하다 보니까, <br/>
    어려움보다는 답답하고 찝찝한 기분을 많이 느꼈다. 좀 더 공부해서 잘 다룰 수 있게 되면 더 즐겁게 임할 수 있을 거 같다.