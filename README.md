# This is the source code of the [Custom Dependency Injection container made in .NET 6](https://github.com/Neon021/Custom-Dependency-Injection)


- [Overview](#overview)
- [How Does It Work?](#how-dos-it-work)
- [Architecture](#architecture)
- [Usage](#usage)

# Overview
<p>In this project I've created a custom DI container that supports classes with constructors.</p>

# How Does It Work?
<ul>
<li><code>ServiceCollection</code>: This is the class where we define how the registering functions will proccess as seen in <code>RegisterSingleton</code> and <code>RegisterTransient</code>. <br> We also define the instantiation of our container with the <code>GenerateContainer</code> function. <br> Lastly we store the registered services in the <code>_serviceDescriptor</code> list.</li>
<li><code>Container</code>: </li>
<li><code>ServiceDescripto</code>: </li>
</ul>
