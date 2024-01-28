# ИС для зоопарка на WinForms

### [2021] КУРСОВАЯ РАБОТА

Программа позволяет работать с данными о животных и сотрудниках в зоопарке. Она подключается к базе данных, созданной на Microsoft SQL Server и позволяет добавлять, изменять, удалять записи в базе данных.

## Обзор программы

Интерфейс программы состоит из двух сегментов:

1) первый содержит окно с вкладками, где в зависимости от выбранной вкладки отображается таблица, в которой необходимо произвести операции с записями;

2) второй отображает доступные операции для работы с данными: удаление, изменение, добавление и обновление.

![Главное меню](/readme/main-menu.png)
<p style="text-align:center;font-style:italic">Главное меню</p>
<br>

Для того, чтобы удалить или изменить запись, необходимо в верхнем сегменте выбрать интересующую вкладку (таблицу), выделить запись и нажать соответствующую кнопку.

При нажатии кнопки "Изменить" появляется отдельное окно с полями под каждый изменяемый атрибут. Начальные данные в таком окне основываются на данных выделенной ранее записи. После ввода новых значений необходимо нажать кнопку "Принять" для того, чтобы изменения вступили в силу.

![Окно изменения записи](/readme/update-window.png)
<p style="text-align:center;font-style:italic">Окно изменения записи</p>
<br>

При нажатии кнопки "Добавить" откроется окно подобно тому, что вызывается при нажатии кнопки "Изменить", но с пустыми значениями. После ввода значений необходимо нажать кнопку "Принять", чтобы новая запись была добавлена в базу.

![Окно добавления записи](/readme/insert-window.png)
<p style="text-align:center;font-style:italic">Окно добавления записи</p>
<br>

Кнопка "Обновить" обновляет содержимое верхнего сегмента для того, чтобы получить из базы данных актуальные данные выбранной таблицы.

## Схемы базы данных

Логическая и физическая схемы баы данных проектировались с помощью программы SQL Developer Data Modeler от Oracle.

Логическая схема иллюстрирует сущности, их свойства (атрибуты) и связи сущностей между собой.

![Логическая схема БД](/readme/logical-scheme.png)
<p style="text-align:center;font-style:italic">Логическая схема БД</p>
<br>

Физическая схема создавалась на основе логической и демонстрирует все создаваемые сущности, их атрибуты, отношения, ограничения по типам данных, первичные и внешние ключи.

![Физическая схема БД](/readme/physical-scheme.png)
<p style="text-align:center;font-style:italic">Физическая схема БД</p>
<br>

На основе физической схемы был создан скрипт генерации БД, с помощью которого она была сгенерирована на MS SQL Server.

![Диаграмма БД на MS SQL Server](/readme/diagarm.png)
<p style="text-align:center;font-style:italic">Диаграмма БД на MS SQL Server</p>
<br>

## Структура решения

Приложение имеет одну главную форму, из которой по нажатию кнопок "Изменить" и "Добавить" вызываются другие формы, индивидуальные для каждой из выбранных вкладок, которые в проекте называются, например, "AnimalUpdate" и "AnimalInsert" соответственно.

В коде главного окна для каждой кнопки определен код удаления, изменения, добавления и обновления записей. Так для функций удаления и изменения вначале определяется, какая вкладка открыта (с какой таблицей необходимо работать) и какая строчка выделена (получаем номер строки). В зависимости от названия выбранной вкладки, выполняется соответствующий код, позволяющий удалить/изменить запись.

### Удаление записи

Код кнопки "Удалить" в главном окне:

```csharp
private void Delete_Click(object sender, EventArgs e)
{
    DataGridView selected = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First();
    DataGridViewRow row = selected.Rows[selected.SelectedCells[0].RowIndex];
    switch (selected.Name)
    {
        case "animalSetDataGridView":
            CRUDAnimal.Instance.Delete((Int32)row.Cells[0].Value);
            break;
        case "animal_AnalysisSetDataGridView":
            CRUDAnimal_Analysis.Instance.Delete((Int32)row.Cells[0].Value);
            break;
        // ...
        case "zoo_InformationSetDataGridView":
            CRUDZoo_Information.Instance.Delete((String)row.Cells[0].Value);
            break;
    }
    Form1_Load(sender, e);
}
```

В каждом кейсе оператора switch с помощью класса "CRUD[название таблицы]" и его метода "Delete", который принимает значение первичного ключа выбранной строки, происходит удаление записи из БД.

Код метода "Delete" на примере класса "CRUDAnimal":

```csharp
public void Delete(Int32 id)
{
    Animal animal = ZooRepository.Instance.AnimalSet.First(i => i.animal_code == id);
    ZooRepository.Instance.AnimalSet.Remove(animal);
    ZooRepository.Instance.SaveChanges();
}
```

### Изменение записи

Код кнопки "Изменить" в главном окне:

```csharp
private void Update_Click(object sender, EventArgs e)
{
    DataGridView selected = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First();
    DataGridViewRow row = selected.Rows[selected.SelectedCells[0].RowIndex];
    switch (selected.Name)
    {
        case "animalSetDataGridView":
            AnimalUpdate animalUpdate = new AnimalUpdate((Int32)row.Cells[0].Value);
            animalUpdate.Show();
            break;
        case "animal_AnalysisSetDataGridView":
            Animal_AnalysisUpdate animal_AnalysisUpdate = new Animal_AnalysisUpdate((Int32)row.Cells[0].Value);
            animal_AnalysisUpdate.Show();
            break;
        // ...
        case "zoo_InformationSetDataGridView":
            Zoo_InformationUpdate zoo_InformationUpdate = new Zoo_InformationUpdate((string)row.Cells[0].Value);
            zoo_InformationUpdate.Show();
            break;
    }
}
```
В каждом кейсе оператора switch создаётся объект класса "[название таблицы]Update", который в своём конструкторе принимает значение первичного ключа выбранной строки, а также отображается соответствующее этому классу окно с изменяемыми полями. В данном окне можно изменить все интересующие поля, после чего при нажатии кнопки "Принять" запись будет изменена и эти изменения отобразятся и в БД:

```csharp
AnimalUpdate.animalSetTableAdapter.Update(
    this.dataSet1.AnimalSet);
```

### Добавление записи

Для функции добавления записи так же определяется, какая вкладка открыта (с какой таблицей необходимо работать). В зависимости от названия выбранной вкладки, выполняется соответствующий код, позволяющий добавить новую запись в таблицу.

Код кнопки "Добавить" в главном меню:

```csharp
private void Insert_Click(object sender, EventArgs e)
{
    DataGridView selected = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First();
    switch (selected.Name)
    {
        case "animalSetDataGridView":
            AnimalInsert animalInsert = new AnimalInsert();
            animalInsert.Show();
            break;
        case "animal_AnalysisSetDataGridView":
            Animal_AnalysisInsert animal_AnalysisInsert = new Animal_AnalysisInsert();
            animal_AnalysisInsert.Show();
            break;
        // ...
        case "zoo_InformationSetDataGridView":
            ZooInformationInsert zooInformationInsert = new ZooInformationInsert();
            zooInformationInsert.Show();
            break;
    }
}
```

После появления окна добавления записи необходимо заполнить все имеющиеся в нём поля, после чего при нажатии кнопки "Принять" в БД будет добавлена запись со значениями данных полей:

```csharp
AnimalInsert.animalSetTableAdapter.Insert(animalName, 
    animalGender, color, dateTime, species, aviary);
```