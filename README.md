# OOP – Task 1: Programming basics refresher

Three console exercises, each implemented in **Python** and **C#**. Each language has one file with a menu that runs the chosen exercise (`if/elif` in Python, `switch` in C#).

| # | Exercise | Constructs used |
|---|----------|-----------------|
| 1 | Two-number calculator (`+ - * /`) | input, `if/elif`, arithmetic, division-by-zero check |
| 2 | Temperature converter C ↔ F (`°F = °C * 1.8 + 32`, `°C = (°F − 32) / 1.8`) | input, `if/else` |
| 3 | Grade average (1–6), pass if average ≥ 3.0 | `for` loop, `while` validation, `if/else` |

## Run

**Python**
```bash
cd python
python3 main.py
```

**C#** (.NET 8)
```bash
cd csharp
dotnet run
```

**Online:** open the repo in GitHub Codespaces (Code → Codespaces → Create codespace; the included `.devcontainer` installs .NET 8 and Python), or browse it in [vscode.dev](https://vscode.dev/github/yxssrbj/wsb-oop-zadanie1).

## Example session

```
Choose: 1
First number: 10
Second number: 20
Operation (+, -, *, /): +
Result: 30

Choose: 2
Convert from (C = Celsius -> Fahrenheit, F = Fahrenheit -> Celsius): C
Temperature: 0
0°C = 32°F

Choose: 3
How many grades? 4
Grade 1 (1-6): 5
Grade 2 (1-6): 3
Grade 3 (1-6): 4
Grade 4 (1-6): 2
Average: 3.50
Student passed.
```

## Git workflow

Each language was developed on its own branch and merged into `main`:

- `feature/python` – Python solution
- `feature/csharp` – C# solution
- `main` – merged result (merge commits kept with `--no-ff`)

## Use of AI

AI tool used: Claude (Anthropic), https://claude.ai, 08.11.2026. Purpose: generating the program code and this README. The code was reviewed, run and tested by me with the example inputs from the task.
