# Debugging Data and Inputs

## Overview

- Common traps in debugging
- An effective approach to debugging
- Testing and stabalizing the error
- Inspecting data with the debugger
- MOdifying data in the debugger
- Fixing the dfect
- VSC data debugging features

### effective approach

#### Scientific method

- gather data through repeatable experiements
- form hyphtoesis that accounts for the relevant data
- design an experiement to prove or disprove the hyphtoesis
- execute the experiement
- Analyze, refine and repeat

#### Debugging Code

- Stabalize the error
  - Using the Scientific Method
- Locate the source of the error
  - Using the Scientific method
- Fix the code
- Test the fix
- Look for similar mistakes elsewhere in the code
  source: some guy on pluralsight HA!
  steve mcconnell: code complete

##### Stabalize the error

- think and narrow the scope
- experiement and keep notes
- reproduce the problem locally
- Logs

> [!tldr]
> Intermittent Errors

> [!BUG]
> SQL Server LocalDB unavailable for mac
> Updated DB connection to SQLite
> Website runs but on unsecure connection

- TraceListner 0_o

> [!todo]
>
> ##### Essential
>
> - .Net Trace Viewer (Plug-in)
> - Debug Helper (plugin)
> - Memory Profiler (built-in)
> - Memory Profiler (built-in)
>
> ##### Perofrmance & Analysis
>
> - Performance Profiler (Plug-in)
> - Entity Framework Core UI (Plug-in)
>
> ##### Code Quality & Debugging
>
> - SonarLint(Plug-in)
> - ReSharper (built-in)
> - Unit Test Coverage (built-in)
>
> ##### Development Workflow
>
> - GitToolBox (plug-in)
> - Database Tools (built-in)
> - Sequence Diagram (plug-in)

##### Critical

> - Start w built-ins
>   - Breakpoint management
>   - Watch windows
>   - Call stack Inspection
>   - Memory dumps
>   - Performance profiler
>   - Unit test debugging
> - .NET Trace Viewer
> - Performance Profiler
> - SonarLint
> - Entity Framework UI
> - Memory Profiler
