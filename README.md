[README (8).md](https://github.com/user-attachments/files/31052998/README.8.md)
<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=gradient&customColorList=6,11,20&height=220&section=header&text=OOP%20Exercises%202&fontSize=50&fontColor=ffffff&animation=fadeIn&fontAlignY=35&desc=Classes%20Assignment%20%E2%80%94%20C%23%20.NET&descAlignY=55&descSize=18" width="100%"/>

<img src="https://readme-typing-svg.demolab.com?font=Cairo&size=26&pause=1000&color=00D9FF&center=true&vCenter=true&width=650&lines=%D8%AA%D9%86%D9%81%D9%8A%D8%B0+%D8%AD%D9%85%D8%B2%D8%A9+%D8%A3%D8%AD%D9%85%D8%AF+%D8%AD%D8%B3%D9%86+%D8%A5%D8%B3%D9%85%D8%A7%D8%B9%D9%8A%D9%84+%D8%B9%D9%84%D9%8A;%D8%AA%D8%AD%D8%AA+%D8%A5%D8%B4%D8%B1%D8%A7%D9%81+%D8%AF.+%D8%B9%D9%84%D9%8A+%D8%B9%D9%84%D9%8A+%D8%B3%D8%B7%D9%88%D8%AD%D9%8A;4+Projects+%E2%80%A2+Pure+OOP+%E2%80%A2+No+Shortcuts" alt="Typing SVG" />

<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![OOP](https://img.shields.io/badge/Paradigm-OOP-orange?style=for-the-badge)
[![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)]()

<br/>

<img src="https://komarev.com/ghpvc/?username=hamza-ahmed26&label=README%20Views&color=00d9ff&style=for-the-badge" alt="views"/>
![Last Commit](https://img.shields.io/github/last-commit/hamza-ahmed26/OOP-Exercises-2?style=for-the-badge&color=00d9ff)
![Repo Size](https://img.shields.io/github/repo-size/hamza-ahmed26/OOP-Exercises-2?style=for-the-badge&color=00d9ff)

</div>

<div align="center">
  <a href="#-بيانات-المشروع">البيانات</a> •
  <a href="#-عن-المشروع">عن المشروع</a> •
  <a href="#️-المشاريع-الأربعة">المشاريع</a> •
  <a href="#-مخططات-الكلاسات">مخططات الكلاسات</a> •
  <a href="#-إزاي-تشغل-المشاريع">التشغيل</a> •
  <a href="#-هيكل-الريبو">الهيكل</a>
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

الريبو ده فيه حل تمارين الـ OOP بتاعة الـ Classes Assignment، أربع مشاريع كل واحد فيهم بيطبق فكرة مختلفة من مبادئ البرمجة الكائنية بلغة **C# (.NET)**، الكود كله كونسول أبلكيشن، من غير أي مكتبات خارجية.

<div align="center">

```mermaid
%%{init: {'theme':'dark'}}%%
pie showData
    title مستوى الصعوبة لكل مشروع
    "BankAccount (عادي)" : 1
    "Student (عادي)" : 1
    "Library ⭐⭐" : 2
    "Quiz ⭐⭐⭐" : 3
```

</div>

---

## 🗂️ المشاريع الأربعة

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
- Methods: `AddBook()`, `CheckOutBook()`, `ReturnBook()`, `CheckOut()`, `Return()`

</td>
<td width="50%" valign="top">

### 🧠 4. QuizProject `⭐⭐⭐`
تطبيق كويز أونلاين، المستخدم بياخد اختبار اختيار من متعدد وبتتحسب درجته أوتوماتيك.

**الكلاسات:** `User`, `Quiz`, `Question`
- Methods: `CreateQuestion()`, `TakeQuiz()`, `ViewScores()`

</td>
</tr>
</table>

---

## 🧩 مخططات الكلاسات

مخططات UML حقيقية بتوضح الـ properties والـ methods والعلاقات بين الكلاسات في كل مشروع (GitHub بيرندرها تلقائي كـ diagram تفاعلي قابل للتكبير).

<details>
<summary><b>📚 مخطط BookProject — العلاقة بين Library و Book</b></summary>

```mermaid
classDiagram
    class Library {
        +string Name
        +string Location
        +List~Book~ Books
        +AddBook(title, author, publisher, availability)
        +CheckOutBook(title)
        +ReturnBook(title)
        +DisplayCollection()
    }
    class Book {
        +string Title
        +string Author
        +string Publisher
        +bool Availability
        +DateTime? CheckOutDate
        +DateTime? ReturnDate
        +CheckOut()
        +Return()
    }
    Library "1" o-- "many" Book : manages
```

</details>

<details>
<summary><b>🧠 مخطط QuizProject — العلاقة بين User و Quiz و Question</b></summary>

```mermaid
classDiagram
    class User {
        +string Name
        +string Email
        +string Password
        +List~Quiz~ TakenQuizzes
        +ViewScores()
    }
    class Quiz {
        +string QuizName
        +int NumberOfQuestions
        +double Score
        +List~Question~ Questions
        +CreateQuestion(text, options, answer)
        +TakeQuiz(questions)
    }
    class Question {
        +string QuestionText
        +List~string~ AnswerOptions
        +string CorrectAnswer
    }
    User "1" o-- "many" Quiz : takes
    Quiz "1" o-- "many" Question : contains
```

</details>

<details>
<summary><b>🏦 مخطط BankAccountProject</b></summary>

```mermaid
classDiagram
    class BankAccount {
        +string AccountNumber
        +double Balance
        +string AccountHolderName
        +Deposit(amount)
        +Withdraw(amount)
    }
```

</details>

<details>
<summary><b>🎓 مخطط StudentProject</b></summary>

```mermaid
classDiagram
    class Student {
        +string Name
        +int Id
        +List~double~ Grades
        +AddGrade(grade)
        +CalculateAverageGrade() double
    }
```

</details>

---

## 🔄 السيناريو التنفيذي (QuizProject)

```mermaid
sequenceDiagram
    actor U as User
    participant Q as Quiz
    participant Qs as Question

    U->>Q: CreateQuestion(text, options, answer)
    Q->>Qs: new Question()
    Q-->>Q: Questions.Add(question)
    U->>Q: TakeQuiz(questions)
    loop لكل سؤال
        Q->>U: اعرض الاختيارات
        U->>Q: يدخل رقم الإجابة
        Q-->>Q: قارن مع CorrectAnswer
    end
    Q-->>Q: احسب Score
    U->>U: ViewScores()
```

---

## 🛠️ الأدوات المستخدمة

<div align="center">
<img src="https://skillicons.dev/icons?i=cs,dotnet,visualstudio,git,github" />
</div>

---

## 🚀 إزاي تشغل المشاريع

<details>
<summary><b>دوس هنا عشان تشوف خطوات التشغيل خطوة بخطوة</b></summary>

<br/>

```mermaid
flowchart LR
    A[Clone الريبو] --> B[افتح المشروع في Visual Studio]
    B --> C[حدد المشروع كـ Startup Project]
    C --> D[دوس F5]
    D --> E[شغل التمرين وشوف النتيجة]
```

1. اعمل clone للريبو
   ```bash
   git clone https://github.com/hamza-ahmed26/OOP-Exercises-2.git
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

<img src="https://capsule-render.vercel.app/api?type=waving&color=gradient&customColorList=6,11,20&height=150&section=footer&animation=fadeIn" width="100%"/>

**تسليم مادة Object Oriented Programming — تحت إشراف د. علي علي سطوحي**

</div>
