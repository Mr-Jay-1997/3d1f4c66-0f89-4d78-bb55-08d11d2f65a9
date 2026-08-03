# Longest Increasing Subsequence (LIS)

## Overview

This project provides a solution for finding the **Longest Increasing Subsequence (LIS)** from a sequence of integers.

The application accepts a single string containing integers separated by spaces and returns the longest increasing subsequence.

If multiple subsequences have the same maximum length, the earliest occurring subsequence is returned.

---

## Technology Stack

- .NET 10
- C#
- xUnit
- FluentAssertions

---

## Project Structure

```
src/
    LIS.Domain
    LIS.Application

tests/
    LIS.Application.Tests
        Services
        TestData
```

---

## Solution Approach

The solution consists of four main steps:

1. Validate the input.
2. Parse the input string into integer array.
3. Compute the Longest Increasing Subsequence.
4. Reconstruct and return the sequence.

---

## Running the Project

Clone the repository

```bash
git clone <repository-url>
```

Navigate to the project

```bash
cd <repository-folder>
```

Restore packages

```bash
dotnet restore
```

Build

```bash
dotnet build
```

Run all unit tests

```bash
dotnet test
```

---

## Sample Input

```
6 1 5 9 2
```

Output

```
1 5 9
```

---

Input

```
6 2 4 6 1 5 9
```

Output

```
2 4 6
```

---

Input

```
6 2 4 3 1 5 9
```

Output

```
1 5 9
```

---

## Unit Tests

The project contains **11 unit tests** covering:

- Small inputs
- Large inputs
- Duplicate values
- Multiple valid subsequences
- Earliest subsequence selection
- File-based test inputs

Large test data is stored under:

```
tests/LIS.Application.Tests/TestData
```

---

## Validation

Input validation ensures:

- Input is not null
- Input is not empty
- Input contains only integers
- Numbers are separated by single spaces

---

## Commands

Restore

```bash
dotnet restore
```

Build

```bash
dotnet build
```

Run Tests

```bash
dotnet test
```

Clean

```bash
dotnet clean
```

---

## Test Result

```
Total Tests : 11
Passed      : 11
Failed      : 0
Skipped     : 0
```

---

## Future Improvements

- GitHub Actions CI
- Docker support
- Code coverage reporting
- Benchmark performance for large datasets

---

## Author

Jayadurga Prasad