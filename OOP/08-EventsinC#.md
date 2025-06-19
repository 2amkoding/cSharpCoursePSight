# Events and Delegates

## What data problem does it solve?

In C#, events lets you transfer communication between objects;  
By building a Loosely Coupled Application, you can extend  
the Application without compiler error.

It's a method for avoiding Inheritance Problems;  
follows the Open/Closed Principle.

can add new Application functions without breaking existing Classes/Objects.

## How does it relate to Delegates?

Events are children derived from Class.Delegate  
Events come out-the-box with access control over data shared.

## Keywords

Publisher(Event Sender)  
Subscriber(Event Receiver)  
Event  
EventHandler

### How does the publisher notify the subsrciber ?

By invoking a method inside the subscriber
this method inside the subscriber is called by the Publisher when  
the event is raised.

### How does the publisher know WHAT method to call?

This is defined in the CONTRACT:  
 Its a Method with a specific signature  
 aka a DELEGATE

```c#
public void OnNameofEvent(object source, EventArgs e)
{}
```

## Example
