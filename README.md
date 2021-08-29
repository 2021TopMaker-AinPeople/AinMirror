## 팀명 및 팀원
* 팀명 : AinPeople
* 팀원 : 강동훈(H/W 개발), 임도현(S/W 개발), 윤태경(개발보조 및 테스트), 최준영(개발보조 및 테스트)

## 프로젝트 제목
* AinMirror : 동화를 현실로 스마트미러 DIY 키트(feat. 백설공주)

## 프로젝트 배경 혹은 목적
* 사물인터넷(IoT) 관련 프로젝트에서 가장 많이 활용되고 있는, 라즈베리파이 판매량이 최근 누적 3천만대를 돌파하였지만, 운영체제(OS)는 기존 데스크탑 리눅스와 유사한 라즈베리 파이 OS를 공식적으로 제공하고 있음, 이로 인해 IoT기기에 적합하지 않은 사용자 인터페이스(UI)와 시스템을 사용하게 됨
* 기존 데스크탑 OS(리눅스, Windows 10)나 스마트폰 OS(안드로이드) 또한 라즈베리파이로 이식되었으나, 공식적으로 지원하는 OS가 아니며, 라즈베리 파이 OS와 마찬가지로 IoT기기에 적합하지 않음
* 최근 만화나 동화 속에 나오던 자율주행 자동자, 말하는 스피커 등, 상상으로만 존재하던 많은 IoT 기기들이 속속 등장하고 있음, 이에 따라 어느 때보다 IoT 기기들에 대한 일반인들의 관심이 높아지고 있으며, 이와 관련된 각종 개발 키트와 교육들이 활발하게 만들어지고 있음
* 제안한 제품은 AR기술을 이용하여, 동화 속 스마트미러를 직접 현실로 만들어 볼 수 있는 DIY 키트임

## 타이젠 오픈소스에 컨트리뷰션한 내역
* 강동훈 : TizenFX Camera, CameraView를 사용하여 프리뷰 화면을 출력, 반영완료
* 임도현 : AinMirror 앱의 기본 UI(버튼들)를 배치함, 반영완료
* 커밋한 내용을 확인할 수 있는 주소 : https://github.com/2021TopMaker-AinPeople/AinMirror.git

## 파일 리스트
* MainApp.cs
* MainAppPage.xaml
* MainAppPage.xaml.cs

## 코드 기여자
* 강동훈
  * MainApp.cs : 카메라 프리뷰 구현
* 임도현
  * MainAppPage.xaml : UI 구현

## 보드
* RPI4 : AinMirror UI 구현, 카메라, HDMI 디스플레이 장치 연동,https://github.com/2021TopMaker-AinPeople/AinMirror.git
  * 13인치 HDMI 디스플레이 : UI 및 사운드 출력
  * 라즈베리파이 공식카메라 : 열굴 영상 촬영용

## 구현사항(가산점)
* Peripheral GPIO / I2C / UART / SPI 중 사용한 프로토콜 없음