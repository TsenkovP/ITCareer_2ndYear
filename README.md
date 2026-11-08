<div align="center">

# 🚀 Обектно-ориентирано програмиране (ООП)
### Национална програма „Обучение за ИТ умения и кариера“ — 2-ра година

[![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%209.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![NUnit](https://img.shields.io/badge/Testing-NUnit%204-006699?logo=nunit&logoColor=white)](https://nunit.org/)
[![Moq](https://img.shields.io/badge/Mocking-Moq-yellow?logo=nuget&logoColor=white)](https://github.com/devlooped/moq)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE.txt)

<p align="center">
  <b>Учебни материали, демонстрации и примерни решения на практическите задачи по модул Обектно-ориентирано програмиране.</b>
</p>

</div>

---

## 📌 За проекта

Хранилището съдържа практически разработки, решения на задачи и лабораторни упражнения за учениците от програмата **IT Career**. Проектите са структурирани спрямо учебната програма на **МОН**, обхващайки както фундаментални концепции в ООП, така и съвременни стандарти за писане на качествен код (компонентно тестване, инжектиране на зависимости, шаблонни архитектури).

---

## 🧭 Учебна програма и модули

| № | Тема / Модул | Описание на концепциите | Статус |
|:---:|:---|:---|:---:|
| **01** | **Компонентно тестване (Unit Testing)** | NUnit 4, AAA шаблон, тестови изолации, Fakes & Moq | ✅ Завършена |
| **02** | **Дефиниране на класове (Defining Classes)** | Капсулация, конструктори, свойства (Properties), валидация | ⏳ Предстояща |
| **03** | **Шаблонни класове (Generics)** | Параметризирани класове/методи, constraints | ⏳ Предстояща |
| **04** | **Наследяване, абстракция и интерфейси** | Базови класове, йерархии, абстрактни методи, договори | ⏳ Предстояща |
| **05** | **Полиморфизъм (Polymorphism)** | Динамично свързване, `override`, виртуални таблици | ⏳ Предстояща |
| **06** | **Работа с обекти (Working with Objects)** | `System.Object`, `Equals`, `GetHashCode`, сравняване (`IComparable`) | ⏳ Предстояща |
| **07** | **Елементи от функционалното програмиране** | Делегати (`Func`, `Action`, `Predicate`), ламбда синтаксис, LINQ | ⏳ Предстояща |
| **08** | **Комуникация между обекти (Events)** | Шаблон Publisher-Subscriber, събития и обработчици | ⏳ Предстояща |
| **09** | **Изключения (Exceptions)** | Обработка с `try-catch-finally`, custom exceptions | ⏳ Предстояща |
| **10** | **Работа с потоци и файлове (Streams)** | `FileStream`, `StreamReader`, `StreamWriter`, `using` блокове | ⏳ Предстояща |
| **11** | **Базови шаблони за дизайн (Design Patterns)** | GoF шаблони: Singleton, Factory, Strategy, Repository | ⏳ Предстояща |

---

## 📂 Структура на хранилището

```bash
ITCareer_2ndYear/
├── Modul5_OOP/
│   └── 01_UnitTesting/
│       ├── Skeleton/                     # Домейн модел (Hero, Axe, Dummy) и интерфейси
│       ├── Skeleton.Tests/               # Базови компонентни тестове (NUnit)
│       └── Skeleton.Tests.GoodPractices/ # Рефакторирани тестове по добри практики ([SetUp], без магически числа)
├── .gitignore
├── IT Career_2ndYear.slnx
├── LICENSE.txt
└── README.md
```

---

## 🧪 Фокус върху компонентното тестване (Тема 01)

В реализирания модул са покрити ключовите принципи за автоматизирано тестване:
* **AAA модел (Arrange-Act-Assert):** Ясно разграничение на подготвителната фаза, действието и проверките.
* **NUnit 4 Constraint Model:** Използване на `Assert.That(actual, Is.EqualTo(expected))`.
* **Добри практики:** Изолиране на повторението чрез `[SetUp]`, използване на константи вместо магически числа и описателни съобщения при неуспешни твърдения.
* **Тестова изолация:** Прилагане на Dependency Injection (интерфейси `IWeapon`, `ITarget`) с фалшификати (Fakes) и динамични симулации (`Moq`).

---

## ⚙️ Изисквания и инсталация

### Предпоставки
* **Visual Studio 2022** (версия 17.8 или по-нова) с инсталиран Workload **.NET desktop development**
* **.NET 8.0 SDK** или **.NET 9.0 SDK**

### Стартиране локално
1. Клонирайте хранилището:
   ```bash
   git clone https://github.com/TsenkovP/ITCareer_2ndYear.git
   ```
2. Отворете файла на решението `IT Career_2ndYear.slnx` (или `.sln`) във Visual Studio.
3. Компилирайте проекта (`Ctrl + Shift + B`).
4. Стартирайте тестовете:
   * През менюто: `Test` -> `Run All Tests` (`Ctrl + R, A`)
   * Или отворете прозореца `Test Explorer` (`Ctrl + E, T`).

---

## 📜 Лиценз

Този проект се разпространява под **[MIT License](LICENSE.txt)**. Можете свободно да използвате, адаптирате и преглеждате решенията за образователни цели.