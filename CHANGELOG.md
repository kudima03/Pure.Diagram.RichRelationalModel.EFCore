# Changelog

All notable changes to Pure.Diagram.RichRelationalModel.EFCore are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.1.0] — 2026-06-25

- Maintenance release: dependency and build updates.

## [0.1.0-preview.2.0.1] — 2026-06-10

- Maintenance release: dependency and build updates.

## [0.1.0-preview.2.0.0] — 2026-04-20

### Changed

- **Breaking:** `DiagramDbContext.Series` changed from `DbSet<SeriesEFCoreModel>` to
  `DbSet<DiagramSeriesEFCoreModel>`.
- **Breaking:** the configuration applied to the series entity in `OnModelCreating`
  changed from `SeriesConfiguration` to `DiagramSeriesConfiguration`.

## [0.1.0-preview.1.0.1] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.1.0.0] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.3.1] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.3.0] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.2.0] — 2026-02-17

### Fixed

- `DiagramDbContext` is now `public` (previously `internal`, so it could not be
  constructed or used from outside the assembly).

## [0.1.0-preview.0.1.0] — 2026-02-17

### Added

- Initial release: `DiagramDbContext`, an EF Core `DbContext` for the Pure.Diagram
  RichRelationalModel. Exposes `Diagrams` (`DiagramEFCoreModel`), `Types`
  (`DiagramTypeEFCoreModel`), and `Series` (`SeriesEFCoreModel`) `DbSet` properties,
  and applies `DiagramConfiguration`, `DiagramTypeConfiguration`, and
  `SeriesConfiguration` in `OnModelCreating`.
