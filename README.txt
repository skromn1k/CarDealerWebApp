# Core — бизнес-логика, модели, интерфейсы
dotnet new classlib -n CarDealer.Core

# Infrastructure — доступ к БД, репозитории
dotnet new classlib -n CarDealer.Infrastructure

# Web — Razor Pages + API
dotnet new webapp -n CarDealer.Web

Почему так:

Core — чистые классы, DTO, интерфейсы. Никаких зависимостей на EF или ASP.NET.

Infrastructure — здесь будет DbContext, репозитории, реализация интерфейсов Core.

Web — пользовательский интерфейс (Razor Pages) и REST API контроллеры.


Что ты должен понять и запомнить

Solution объединяет несколько проектов, помогает держать слои отдельно.

Core — бизнес-логика, интерфейсы, DTO, без зависимости от EF или ASP.NET.

Infrastructure — реализация доступа к данным, репозитории, EF DbContext.

Web — контроллеры, Razor Pages, DI-контейнер.

Ссылки всегда сверху вниз — это фундамент SOLID и чистой архитектуры.
