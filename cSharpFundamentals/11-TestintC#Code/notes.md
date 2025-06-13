# Testing C# Code

## Overview

- Writing unit tests

#### Writing Unit tests

- xUnit/CNunit
- [xUnit CLI](https://xunit.net/docs/getting-started/v2/netcore/cmdline)
- dotnet-dump

  > [!question]
  >
  > - [ ] isPackable
  > - [ ] coverlet.collector
  > - [ ] dotnet dump

#### xUnit

- Facts
- Theories

```c#
using Xunit;

namespace MyFirstUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
```
