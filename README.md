CoverCard

Digital proof-of-insurance delivery platform for brokers — built with Angular and ASP.NET Core.

Overview

CoverCard lets insurance brokers securely upload and send proof-of-insurance documents to customers via a unique link, with real-time delivery and view-status tracking on the broker's dashboard.

Two user roles:

Broker — logs in, uploads/sends policy documents, tracks delivery status
Customer — receives a secure link, views/downloads their proof-of-insurance document (no login required)
Tech Stack

Frontend

Angular (standalone components, Signals, RxJS)
TypeScript
Angular Router with route guards

Backend

ASP.NET Core Web API (.NET 10)
C#
Entity Framework Core
ASP.NET Core Identity + JWT authentication
SignalR (real-time delivery/view status updates)
SQL Server

Tools

Visual Studio 2022 (backend)
VS Code (frontend)
Git / GitHub