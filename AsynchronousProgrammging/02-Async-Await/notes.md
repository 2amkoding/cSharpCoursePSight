# Using async and await

```c#
private aysnc void Search_Click(...)
{
  var store = new DataStore();

  var responseTask = store.GetStockPrices("MSFT");

  var data = await responseTask;
  // Code below will run
  // when responseTask has completed
  Stocks.ItemsSource = data;
}
```

### Await

The 'await' keyword introduces a _continuation_,  
allowing you to get back to the original context (thread).

### Creating ur own Async Method

Marking a method as 'async' introduces the capability of  
using the 'await' keyword to leverage the asynchronous principles.

#### Event Handlers

Event handlers are the only time to use async and void in a methodName

```c#
private async void SomeEventHandler()
{
}
```

#### How to indicate an async operation then?

keyword: Task - an async op wo a return value  
keyword: Task<T> - an async op w a return value

tldr: Task methods, What compiler generates

```c#
private async Task GetStocks()
{
  try
  {
    var store = new DataStore();
    var responseTask = store.GetStockPrices(StockIdentifier.Text);
    Stocks.ItemsSource = await responseTask;
  }
  catch (Exception ex)
  {
    Notes.Text = ex.Message;
  }
}
```

## Summary

- Best Practices:
- Always use async and await together
- Always return a Task from an asynchronous method
- Always await an asynchronous method to validate the operation
- use async and await all the way up the chain
- Never use async void unless its an event handler or delegate
- Never block an asynchronous operation by calling Result or Wait()
