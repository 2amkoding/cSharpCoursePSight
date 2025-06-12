# Arrays and Lists

oOOoo pointers and linked lists

## Overview

- array stuff
- working w collections

### arrays

> [!note]
> the variables in Array must be of same type.

- Syntax

  - ```c#
    int[] employeeIds = new int[4];
    int[] employddIds = new int [] {1, 2, 3, 4, 5};
    ```

  ```

  ```

- Determining the Array Size at Runtime

  - ```c#
    int size = int.Parse(Console.ReadLine());

    int[] employeeIds = new int[size];
    ```

  ```

  ```

### Collections

- Syntax

  - ```c#
    List<int> employeeIds = new List<int>();
    ```

  ```

  ```

- Lists are Type-safe
- has API of Methods (employeeIds.Add(22);)
