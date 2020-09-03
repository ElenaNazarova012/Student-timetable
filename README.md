# Цели проекта
- Научить студентов командной работе 
- Дать практический опыт работы с репозиторием.
# Используемые технологии
- C#
- Microsoft .NET Framework v4.5
- Windows Forms
# Необходимые инструменты
- Visual Studio 2017 Community
- Git bush
# Жизненный цикл issue (задачи, task):
Задача - это активность за выполнение которой начисляются баллы. 1 task = 1 балл. Каждая задача может иметь любое количество меток, они определяют тип задачи, этап ее выполнения и принадлежность к функционалу разрабатываемого ПО. Если задача требует изменение исходного кода проекта, то для этой задачи создается отдельная ветка с именем соответствующим номеру задачи по шаблону task-***, например task-123. Для таких задач требуются запрос на слияние. Нельзя приступать к выполнению задачи, если связанные с ней задачи не выполнены.
## Задачи с меткой Epic, Story, Unit Test, Bug:
- Создаются преподавателем (автор) и берутся на исполнение студентом (исполнитель)
- Студент создает ветку имя которой соответствует описанному выше шаблону, где номер в имени ветки это номер задачи
- Студент реализует задачу в ветку и запрашивает запрос на слияние. При это имя запроса должно соответствовать шаблону "WIP: ИмяЗадачиДляКоторойВыполняетсяЗапрос",  а описание должно содержать текст "Закрывает #123"
- После положительной проверки изменений, студент выполняет мерж веток и перевешивает основную задачу на преподавателя.
- После заключительных проверок, преподаватель выставляет баллы в журнал, перевешивает задачу на исполнителя и закрывает задачу.
# Ответственность
## Задачи могут быть в четырех состояниях:
- Ни на кого неназначенные открытые задачи без меток состояния выполнения - эти задачи формируют список задач из которого участник проекта может взять на исполнение.
- Задача имеет исполнителя и помечена меткой To do - это значит что эта задача запланирована к исполнению. Если по задаче нет активности в течение недели, то задача будет снята с исполнителя и метка To do убрана. Не больше двух задач на одного исполнителя в этом состоянии.
- Задача имеет исполнителя и помечена меткой Doing - это значит, что к исполнению этой задачи уже приступили. Если нет активности в течение недели, то у задачи будет снята метка Doing и выставлена метка To do. Не более одной задачи на одного исполнителя в этом состоянии.
- Задача имеет исполнителя и закрыта - это значит что исполнитель закончил выполнение задачи.

## Запросы слияния
Создаются исполнителем задач с целью предоставления работы на проверку, после которой последует слияние ветки, которая сдержит изменение кода в ветку Testing. Запрос на слияние должен иметь исполнителя и проверяющего, только после положительной проверки проверяющим запрос на слияние может быть закончен мержем.

# Labels:
- Epic - Название разрабатываемой функциональности, описывающее принципы ее работы
- Story - Задача на разработку функциональности
- Bug - задача на устранения несоответствия реальной функциональности и заявленой функциональности в Story. В баге всегода указывается Story для которой заводиться этот баг.
- Controller - (MVC) Задача на разработку кода реализующий логику ПО. Если упомянут класс, который начинается с большой буквы С, например, СGroup, то задача должна быть помечена меткой Controller.
- Model - (MVC) Задача на разработку кода организующий хранение данных. Если упомянут класс, который начинается с большой буквы M, например, MGroup, то задача должна быть помечена меткой Model.
- View - (MVC) Задача на разработку кода реализующий графический интерфейс
- Unit test - Задача затрагивает модульное тестирование
- Auto test - Задачи с этой меткой предназначены для автоматизации тестирования
- Regression - Выполнение тестовых сценариев
- Script - Задача на написание сценариев

# Projects:
- Code Development - Сюда попадают задачи на разработку функционала или исправления багов
- Code review - Сюда попадают новые запросы на pull request c предыдущего проекта
- Writing test scripts - Сюда попадают задачи на разработку сценариев тестирования
- Review test scenarios - Сюда попадают задачи на проверку тестовых сценариев, переносом с предыдущего проекта
- Writing automatic tests - Сюда попадают задачи на автоматизацию тестовых сценариев
- Review automatic tests - Сюда попадают задачи на проверку автоматизированных тестовых сценариев
- Regression - Сюда попадают задачи на выполнение тестовых сценариев
- Review Regression - Сюда попадают задачи на проверку результатов выполнения тестовых сценариев, переносом с предыдущего проекта

# Branches:
- task-*** - Ветка для реализации задачи.
- Testing - Ветка в которую выполняется мерж всех task
- Release-**.**.**.** - Ветка в которую выполняется мерж из ветки Testing, когда завершен этап разработки.
- Master - Основная ветка, содержащая стабильную версию разрабатываемого ПО

# Столбцы в таблице тестовых сценариев:

## Test ID
(обязательный) Формируется по шаблону task-9-1 где 
* 9 это номер задачи, описывающий автоматизируемый функционал
* 1 это порядковый номер тестового сценария
## Test title
(обязательный) Короткое название теста, например: 
* Появление горизонтального скролла для таблицы Преподаватели
* Исчезновение вертикального скролла для таблцы Преподаватели
## Description
(обязательный) Более детальное описание Test title, например:
* Появление горизонтального скролла, при добавлении длинных значений в ячейке
* Появление горизонтального скролла, при изменении значения в ячейке на длинное
* Исчезновение вертикального скролла, при удалении неотображаемых строк
* Исчезновение вертикального скролла, при наложении фильтрации
## Pre-condition
(необязательный) Набор действий приводящих систему в необходимое состояние. Может ссылаться на другой сценарий, который приводит систему в необходимое состояние
## Test Data
(необязательный) может содержать SQL запросы, перечень объектов которые потребуются для тестирования и.д.
## Steps
(обязательный) Нумерованный перечень действий пользователей:
1. Перейти к списку преподавателей
2. Нажать на столбец "Имя"
## Expected Result
(обязательный) Описывает ожидаемый результат для указанного действия:
Step 2: Столбец "Имя" отсортирован в алфавитном порядке
## Automated
(обязательный) Указывается статус автоматизации этого теста:
* No - Если автоматизировать невозможно
* To be - Если автоматизация сценария запланирована
* In Progress - Если сценарий находится в процессе автоматизации
* Yes - Если сценарий автоматизирован
## Mapping with matrix
(необязательный) Путь к файлу в котором хранятся автоматические тесты, заполняется по завершению автоматизации

## Automation status
(необязательный) Может выполняться после автоматизации сценария или выполнения автоматических тестов и может принимать значения:
* PASSED - если сценарий не выявил сбоев
* FAILED - если сценарий выявил сбой
* BLOCKED - если невозможно выполнить сценарий
## Manual status
(необязательный) Может выполняться после написания сценария и может принимать значения:
* PASSED - если сценарий не выявил сбоев
* FAILED - если сценарий выявил сбой
* BLOCKED - если невозможно выполнить сценарий
## Comment/Related bugs
(необязательный) Содержит номера и ссылки на баг(и) или причину невозможности выполнить или автоматизировать сценарий.


