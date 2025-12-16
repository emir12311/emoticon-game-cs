# Emoticon Game 😯 (C# Remake)

This is a C# remake of my **first ever programming project**, which I originally wrote in Python.
I rebuilt it to see how much I’ve improved and to understand how the same logic translates into another language.

In the original version, I didn’t know about dictionaries, so I used parallel tuples.
In this C# version, I used a `Dictionary` to properly connect emoticons with their meanings.

## How the game works
1. The program randomly selects an emoticon and its meaning.
2. You start with **3 lives**.
3. The meaning is shown (for example: `"sad"`).
4. You must type the correct emoticon (`:(`).
5. Each wrong guess removes one life.
6. If you lose all lives, the game ends.

## What I practiced while remaking it
- Using `Dictionary<TKey, TValue>` instead of parallel structures.
- Generating random values with `Random`.
- Control flow with `while` loops.
- Translating logic from Python into C.
- Basic console input and output in C#.

### Note 📝
This repository contains **first versions only**.
I don’t go back and refactor old projects unless there’s a strong reason.

The goal is to keep a visible timeline of progress, from my earliest projects to more advanced ones later on.
