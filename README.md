# 📦 택배 자동차 2D 게임 (Unity)

Unity 2D를 활용한 간단한 택배 배달 게임입니다.  
플레이어는 자동차를 조작해 패키지를 수령하고 고객에게 배달하며, 장애물과 부스터 구간을 통해 속도 변화도 체험할 수 있습니다.

---

## 🕹️ 게임 방법

- w,s 키 : 전진/후진  
- a,d 키 : 회전  
- 패키지 수령 : `Package` 태그 오브젝트와 충돌  
- 고객에게 배달 : `Customer` 태그 오브젝트와 충돌  
- 부스터 : `Boost` 태그 통과 시 속도 증가  
- 장애물 : `Obstacle` 태그 충돌 시 속도 감소

---

## 🔧 사용 기술

- Unity 2022.3 이상  
- C# 스크립트 (`Driver.cs`, `Delivery.cs`, `FollowCamera.cs`)  
- Rigidbody2D + Collider2D  
- Tag 기반 트리거 처리  
- SpriteRenderer 색상 변경  
- Debug.Log 로그 출력  
- Git + GitHub 사용

---

## 📂 프로젝트 구조

```plaintext
Assets/
├── Scripts/
│   ├── Driver.cs
│   ├── Delivery.cs
│   └── FollowCamera.cs
├── Scenes/
│   └── Main.unity

---

## 📝 참고 및 출처

이 프로젝트는 [Complete C# Unity 2D Game Development (Updated To Unity 6)]의 강의 내용을 기반으로 학습한 결과물입니다.  
저작권 보호를 위해 강의에서 제공된 이미지, 사운드, 폰트 등의 에셋은 포함되어 있지 않으며,  
해당 리포지토리는 **개인 학습 목적**으로만 사용됩니다.

> 강의 출처: https://www.udemy.com/course/unitycourse/?couponCode=MT40825

---

## 👨‍💻 제작자 정보

- 이름: 박민우  
- GitHub: https://github.com/idnku4286/MyUnityGame-.git
- 이메일: idnku1107@gmail.com

