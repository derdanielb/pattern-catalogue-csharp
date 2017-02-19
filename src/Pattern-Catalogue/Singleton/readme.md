# Singleton

Singletons are charecterized by the following aspects:
- Single private constructor
- Sealed class
- Static class member variable that holds the only existing instance of the class
- Public static getter for distributing the singleton instance
- Usually singletons are instanziated lazily, which means when first accessed

In this implementation additionally using a static constructor is very C#-specific. It causes to be loaded lazily. Futher information can be found on [csharpindepth](http://csharpindepth.com/Articles/General/Singleton.aspx).
