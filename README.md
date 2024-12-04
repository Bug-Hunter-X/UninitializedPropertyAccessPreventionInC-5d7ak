# Uninitialized Property Access in C# 

This repository demonstrates a common, yet subtle, error in C#: accessing uninitialized properties.  Uninitialized properties will default to their type's default value (0 for integers, null for objects, etc.), which may lead to unexpected behavior if not handled properly.  The `Bug.cs` file shows the problem, while `BugSolution.cs` demonstrates a solution.

## Reproducing the Bug

1. Clone this repository.
2. Compile and run `Bug.cs`.
3. Observe the output; you might see unexpected behavior depending on your system.

## Solution

The solution involves initializing the property to a default or suitable value either upon declaration or in the constructor, thus ensuring a well-defined initial state. Refer to `BugSolution.cs`.