# Adapter Pattern

As it can be seen, the instance gets created (= constructor executes) lazily only when Singleton class is accessed the first time. Both static and private constructor are executed once. As we access main Singleton class we cause execution of the private constructor. Singleton class holds a instance of itself so static constructor gets called the second time.

![](https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Objektadapter.svg/640px-Objektadapter.svg.png)
