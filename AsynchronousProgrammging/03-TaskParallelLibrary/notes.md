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

### Cancellation and Stopping a Task

```c#
async Task Process(CancellationToken token)
{
  var task = Task.Run(() => {
    // Perform an expensive operation
      return ... ;
}, token);

var result = await task;
// Use the result of the operation
}
```

### Cross-Thread Communication

```c#
var task = Task.Run(() => {

  return ... ;
});

task.ContinueWith((completedTask) => {
  Dispatcher.Invoke(() => { /* Run me on the UI */});

});
```

## Summary

- Intro: Task with Task.Run to run work on different thread
- Obtain result and exceptions in the continuation of a Task
- Configure the continuation to only run on success, failure, or cancellation
- How to combine async and await with your own asyncronous operations
- Understand the different between await and ContinueWith
