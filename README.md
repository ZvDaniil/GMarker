# Проект "GMarker"

Проект "GMarker" представляет собой приложение, разработанное с использованием библиотеки GMap.NET и базы данных Microsoft SQL Server.
Отображает на главной форме карту с маркерами, содержащими географические координаты техники, с возможностью перемещать маркеры (Drag&Drop) и сохранять изменения.

## Технологии

В проекте "GMarker" используются следующие технологии и инструменты:

- **C#**
- **.NET Framework**
- **Windows Forms**
- **GMap.NET**
- **MS SQL Server**

## Принципы и архитектура

- **SOLID**: Проект разработан с соблюдением принципов SOLID (Принципы единственной ответственности, открытости/закрытости, подстановки Барбары Лисков, разделения интерфейса и инверсии зависимостей).
- **Чистая архитектура**: Проект следует принципам чистой архитектуры, которые помогают достичь высокой степени разделения ответственности и упрощения тестирования.
- **MVP**: Проект использует паттерн MVP (Model-View-Presenter), который помогает отделить логику приложения от его представления и модели.

## Функциональность

- Отображение карты с возможностью перемещения и масштабирования.
- Отображение юнитов на карте в виде маркеров.
- Перемещение юнитов по карте путем перетаскивания маркеров.
- Сохранение изменений в базе данных.

## Требования

- .NET Framework 4.8 или выше.
- База данных MS SQL Server.

## Установка и настройка

1. Склонируйте репозиторий проекта или загрузите его архивную версию.
2. Откройте проект в Visual Studio или другой среде разработки, поддерживающей C#.
3. Установите необходимые пакеты NuGet, если требуется.
4. Создайте базу данных и настройте подключение к ней в файле `app.config`.
5. Скомпилируйте проект.

## Использование

1. Запустите скомпилированное приложение.
2. На главной форме будет отображена карта.
3. Щелкните левой кнопкой мыши по существующему маркеру и перетащите его, чтобы переместить юнит.
4. Для сохранения всех изменений в базе данных нажмите кнопку "Сохранить изменения".

## Авторы

    Даниил Владимирович - mr.danil.zverev@mail.ru

Свяжитесь со мной по указанному адресу электронной почты для обратной связи или дополнительной информации.
