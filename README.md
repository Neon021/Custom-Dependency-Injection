# This is the source code of the [Custom Dependency Injection container made in .NET 6](https://github.com/Neon021/Custom-Dependency-Injection)


- [Overview](#overview)
- [How Does It Work](#how-does-it-work)
- [Usage](#usage)

# Overview
<p>In this project I've created a custom DI container that supports classes with constructors.</p>

# How Does It Work
<ul>
  <li><b>ServiceCollection</b>: This is the class where we define how the registering functions will proccess as seen in <code>RegisterSingleton</code> and <code>RegisterTransient</code>. <br> We also define the instantiation of our container with the <code>GenerateContainer</code> function. <br> Lastly we store the registered services in the <code>_serviceDescriptor</code> list.</li>
  <li><b>Container</b>: In the <code>GetService(Type)</code> of this class, we first query the registered <code>serviceType</code> and if there's already an implementation for this service we simply return the implementation. <br> Otherwise we get the <code>ImplementationType</code> if it exits, else if we just get the <code>ServiceType</code>. <br>Onwards we get the first constructor of the <code>actualType</code> and make a recursive call to get it's dependencies if it has any. At the end of the function we instantiate it with the help of the <code>Activator</code> class and return it. <br> Finally we make a call to this function in the <code>T GetService<T>()</code> in order to write just the <code>ServiceType</code> when executed.</li>
  <li><b>ServiceDescription</b>: This the template class to store <code>ServiceType</code> <code>ImplementatşonType</code> and the <code>Lifetime</code> of our services and it's implenentation.</li>
</ul>

# Usage
Simply `git clone https://github.com/Neon021/Custom-Dependency-Injection.git` and `dotnet run --project DI_Container`.
