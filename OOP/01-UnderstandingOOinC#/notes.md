# OOP in C

## Overview

- OOP
- Working w classes and objects
- The pillars of OO

### OOP

- 1960s
- c++ -> Java -> C#

### C# and OOP

- Type-safe: Once a variable type is declared, it cannot change
- Building blocks:
  - Classes, Objects, Methods, Properties, Interfaces

### Classes and Objects

- Classes

  - Classes is how we code real world concepts into types
  - Reference Type: Classes, Interfaces, Delegates
  - Everything in C# is a class
    - Top level statements || Main()
    - Classes which will be _instantiated_
  - Blueprint of an object
    - contains _members_: Constructors, Fields, Methods, Properties, Events
    - members have _access modifiers_: public, private, protected

- Types in CTS
  - Class
  - Enumeration
  - Struct
  - Interface
  - Delegate
  - Record (C#9+)

### Principles of OOP

- The 4 Pillars of OOP
  - Abstraction
    - Essential concepts, not details
    - a layer of abstraction
    - expose simple interaction without knowing the details
  - Encapsulation
    - all data and functionality is encapsulated inside object
    - only certain details are accessible
  - Polymorphism
    - allow methods to execute differently
    - keywords: _virtual_ and _override_
  - Inheritance
    - a hierarchy
      - is-A relation
      - Animal class
        - dog class: is-An animal
        - cat class: is-An animal
