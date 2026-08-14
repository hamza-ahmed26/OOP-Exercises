[README (7).md](https://github.com/user-attachments/files/31052927/README.7.md)
<div align="center">

<img src="https://readme-typing-svg.demolab.com?font=Fira+Code&size=28&pause=1000&color=00D9FF&center=true&vCenter=true&width=600&lines=Object+Oriented+Programming;تمارين+البرمجة+الكائنية;Classes+Assignment" alt="Typing SVG" />

<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![OOP](https://img.shields.io/badge/Paradigm-OOP-orange?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Done-success?style=for-the-badge)

<br/>

<img src="https://user-images.githubusercontent.com/74038190/212284100-561aa473-3905-4a80-b561-0d28506553ee.gif" width="500">

</div>

---

## 👤 بيانات المشروع

<div align="center">

| | |
|---|---|
| **تنفيذ الطالب** | حمزة أحمد حسن إسماعيل علي |
| **تحت إشراف** | د. علي علي سطوحي |
| **المادة** | Object Oriented Programming |
| **التمرين** | Exercises 2 — Classes Assignment |

</div>

---

## 📋 عن المشروع

الريبو ده فيه حل تمارين الـ OOP بتاعة الـ Classes Assignment، أربع مشاريع كل واحد فيهم بيطبق فكرة مختلفة من مبادئ البرمجة الكائنية بلغة **C# (.NET)**، من غير أي مكتبات خارجية، الكود كله كونسول أبلكيشن بسيط وواضح.

<div align="center">

| مستوى الصعوبة | يعني ايه |
|:---:|:---|
| — | تمرين عادي |
| ⭐⭐ | أصعب شوية |
| ⭐⭐⭐ | الأصعب في الأسايمنت |

</div>

---

## 🗂️ المشاريع

<table>
<tr>
<td width="50%" valign="top">

### 🏦 1. BankAccountProject
برنامج بسيط بيمثل حساب بنكي، بيسمح بالإيداع والسحب مع حماية إن السحب ميعديش الرصيد.

**الكلاس:** `BankAccount`
- Properties: `AccountNumber`, `Balance`, `AccountHolderName`
- Methods: `Deposit()`, `Withdraw()`

</td>
<td width="50%" valign="top">

### 🎓 2. StudentProject
برنامج بيدير درجات طالب في الامتحانات وبيحسب المتوسط بتاعه.

**الكلاس:** `Student`
- Properties: `Name`, `Id`, `Grades`
- Methods: `AddGrade()`, `CalculateAverageGrade()`

</td>
</tr>
<tr>
<td width="50%" valign="top">

### 📚 3. BookProject `⭐⭐`
نظام مكتبة بسيط، بيسمح بإضافة كتب واستعارتها وإرجاعها مع تسجيل التواريخ.

**الكلاسات:** `Book`, `Library`
- `Book`: `Title`, `Author`, `Publisher`, `Availability`, `CheckOutDate`, `ReturnDate`
- `Library`: `Name`, `Location`, `Books`
- Methods: `AddBook()`, `CheckOutBook()`, `ReturnBook()`, `CheckOut()`, `Return()`

</td>
<td width="50%" valign="top">

### 🧠 4. QuizProject `⭐⭐⭐`
تطبيق كويز أونلاين، المستخدم بياخد اختبار اختيار من متعدد وبتتحسب درجته أوتوماتيك.

**الكلاسات:** `User`, `Quiz`, `Question`
- `Question`: `QuestionText`, `AnswerOptions`, `CorrectAnswer`
- `Quiz`: `QuizName`, `NumberOfQuestions`, `Score`, `Questions`
- `User`: `Name`, `Email`, `Password`, `TakenQuizzes`
- Methods: `CreateQuestion()`, `TakeQuiz()`, `ViewScores()`

</td>
</tr>
</table>

---

## 🛠️ الأدوات المستخدمة

<div align="center">
<img src="https://skillicons.dev/icons?i=cs,dotnet,visualstudio,git,github" />
</div>

---

## 🚀 إزاي تشغل المشاريع

<details>
<summary><b>دوس هنا عشان تشوف خطوات التشغيل</b></summary>

<br/>

1. اعمل clone للريبو
   ```bash
   git clone https://github.com/your-username/OOP-Exercises-2.git
   ```
2. افتح المشروع اللي عايزه في **Visual Studio**.
3. حدد المشروع كـ **Startup Project**.
4. دوس `F5` أو زرار **Run** ▶️.

</details>

---

## 📂 هيكل الريبو

```
OOP-Exercises-2/
├── BankAccountProject/
│   ├── BankAccount.cs
│   └── Program.cs
├── StudentProject/
│   ├── Student.cs
│   └── Program.cs
├── BookProject/
│   ├── Book.cs
│   ├── Library.cs
│   └── Program.cs
├── QuizProject/
│   ├── Question.cs
│   ├── Quiz.cs
│   ├── User.cs
│   └── Program.cs
└── README.md
```

---

## ✨ مبادئ الـ OOP المطبقة

<div align="center">

| المبدأ | فين اتطبق |
|:---|:---|
| **Encapsulation** | كل الـ properties بـ private set ومتاحة بس عن طريق الـ public getters |
| **Constructors** | كل كلاس بيبدأ حالته من خلال constructor مخصص له |
| **Collections** | استخدام `List<T>` في الدرجات والكتب والأسئلة والكويزات |
| **Class Collaboration** | `Library` بتدير `Book`، `Quiz` بتدير `Question`، `User` بيتابع `Quiz` |
| **Input Validation** | التحقق قبل التنفيذ (زي عدم كفاية الرصيد أو الكتاب متسحب أصلاً) |

</div>

---

<div align="center">

<img src="https://user-images.githubusercontent.com/74038190/212284158-e840e285-664b-44d7-b79b-e264b5e54825.gif" width="500">

**تسليم مادة Object Oriented Programming — تحت إشراف د. علي علي سطوحي**

</div>
