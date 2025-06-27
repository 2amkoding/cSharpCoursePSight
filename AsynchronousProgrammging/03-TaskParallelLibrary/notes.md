# Using the Task Parallel Library (TPL) for Async Programming

## Using Task without async and await

- [ ] Obtain a result
- [ ] Capture exceptions
- [ ] Running continuations depnding on Sucess / Failture
- [ ] Cancelling an async operation

- [ ] Load files by disk synchronously
- [ ] Load ... asynchronously

### Handling Exceptions

```c#
try
{
  await task;
}
catch(Exception ex)
{
  // log ex.Message
}

task.ContinueWith((t) => {
  // log ex.InnterException.Message
}, TaskContinuationOptions.OnlyOnFaulted);
```
