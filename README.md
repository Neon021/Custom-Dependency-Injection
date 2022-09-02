# This is the source code of the [Custom Dependency Injection container made in .NET 6](https://github.com/Neon021/Custom-Dependency-Injection)


- [Overview](#overview)
- [How Does It Work?](#how-dos-it-work)
- [Usage](#usage)

# Overview
<p>In this project I've created a custom DI container that supports classes with constructors.</p>

# How Does It Work?
<ul>
  <li><bold>ServiceCollection</bold>: This is the class where we define how the registering functions will proccess as seen in <code>RegisterSingleton</code> and <code>RegisterTransient</code>. <br> We also define the instantiation of our container with the <code>GenerateContainer</code> function. <br> Lastly we store the registered services in the <code>_serviceDescriptor</code> list.</li>
  <li><bold>Container</bold>: In the <code>GetService(Type)</code> of this class, we first query the registered <code>serviceType</code> and if it's implementation is not null we simply return the implementation. If that's not the case we get the <code>ImplementationType</code> if it exits, if not we just get the <code>ServiceType</code>. Onwards we get the first constructor of the <code>actualType</code> and make a recursive call to get it's dependencies if it has any. At the end of the function we instantiate it with the help of the <code>Activator</code> class and return it. Finally we call this function in the <code>T GetService<T>()</code> for simplicity.</li>
  <li><bold>ServiceDescripton</bold>: This the template class to store <code>ServiceType</code> <code>ImplementatşonType</code> and the <code>Lifetime</code> of our services and it's implenentation.</li>
</ul>

# Usage
Simply `git clone https://github.com/Neon021/Custom-Dependency-Injection.git` and `dotnet run --project DI_Container`.
