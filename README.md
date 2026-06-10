# Pure.Diagram.RichRelationalModel.EFCore

Entity Framework Core `DbContext` for the **Pure.Diagram** RichRelationalModel — maps diagram, diagram type, and series entities to a relational database.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RichRelationalModel.EFCore)](https://www.nuget.org/packages/Pure.Diagram.RichRelationalModel.EFCore)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RichRelationalModel.EFCore` provides a ready-to-use EF Core `DbContext` for persisting diagram data modelled with the Pure.Diagram RichRelationalModel. It exposes typed `DbSet<T>` properties for every aggregate root and applies the full set of EF Core model configurations on startup.

## Public API

| Type | Kind | Description |
|------|------|-------------|
| `DiagramDbContext` | `sealed class` | EF Core `DbContext` for the diagram domain. Primary constructor accepts `DbContextOptions<DiagramDbContext>`. |

### `DiagramDbContext` — DbSets

| Property | Entity type | Description |
|----------|-------------|-------------|
| `Diagrams` | `DiagramEFCoreModel` | Root diagram aggregates |
| `Types` | `DiagramTypeEFCoreModel` | Diagram type lookup entries |
| `Series` | `DiagramSeriesEFCoreModel` | Data series belonging to diagrams |

`OnModelCreating` applies `DiagramConfiguration`, `DiagramTypeConfiguration`, and `DiagramSeriesConfiguration` from the companion configurations package.

## Dependencies

- [`Pure.Diagram.RichRelationalModel.EFCore.Models`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models) — EF Core entity records
- [`Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations) — EF Core type configurations
