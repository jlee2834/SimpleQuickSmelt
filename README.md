# SimpleQuickSmelt

**Rust Oxide/uMod Plugin**  
A lightweight plugin that makes all furnaces and smelting devices operate at **2x speed**.

---

## ⚡ What It Does

This plugin halves the smelting interval of all `BaseOven` entities (furnace, large furnace, campfire, BBQ, etc.).

- 🔥 **Vanilla interval:** 2.0 seconds
- 🚀 **New interval:** 1.0 second (2x faster)

---

## ✅ Features

- No config, no bs — just faster smelting
- Automatically applies to all ovens on server start and spawn
- Supports modded or custom ovens using `BaseOven`

---

## 🔧 Installation

1. Download `QuickSmeltSimple.cs`
2. Drop it into your `oxide/plugins` folder
3. Reload the plugin or restart your server:

```bash
oxide.reload QuickSmeltSimple
