# Singleton Design Pattern Example

This repository provides an example implementation of the Singleton design pattern in C#. The Singleton pattern ensures that only one instance of a class is created and provides a global access point to that instance.


## Overview

The Singleton design pattern is a creational pattern that restricts the instantiation of a class to a single object. It is useful in scenarios where having multiple instances of a class can lead to problems such as resource contention or inconsistent state.

### Advantages

- **Resource optimization**: The Singleton pattern optimizes resource usage by ensuring that only one instance of the class is created.
- **Lazy initialization**: The instance is created when it is first accessed, delaying its creation until it is actually needed.
- **Global accessibility**: The single instance is globally accessible, providing a convenient way to access it throughout the application.
- **Controlled access**: The Singleton pattern allows for controlled access to the instance, making it easier to manage dependencies and configurations.

### Disadvantages

- **Testing difficulties**: The global state introduced by the Singleton pattern can make unit testing more challenging.
- **Reduced parallelism**: The use of synchronization mechanisms in Singleton implementations may limit parallel processing.
- **Potential memory leakage**: The persistence of the Singleton object throughout its lifecycle may increase the risk of memory leaks.
- **Dependency storage**: Storing dependencies within a Singleton instance can be more complex due to the limited access points.

### Purpose of Code
- The purpose of the code shows the purchase made at 3 fuel companies using the singleton pattern. Two separate users make purchases with the help of a common method (the balance in the bank account). The repetitiveness of shopping is shown with the help of loop and switch. Access to the methods was provided using the Main instance. the word "instance" is a term used to represent an instance of a class. When a class instance is created, you can access the non-static (instance) methods and properties of the class through this instance. This allows the class to contain individual data and behaviors for each instance

