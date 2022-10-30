## 什么是Async/Await

**C#中的Async和Await关键字是异步编程的核心**。通过这两个关键字，可以使用.NET Framework、.NET Core或Windows运行时中的资源，轻松创建异步方法(几乎与创建同步方法一样轻松)。使用async关键字定义的异步方法简称为“异步方法”。

```csharp
public async Task<int> GetUrlContentLengthAsync()
{
    var client = new HttpClient();

    Task<string> getStringTask =
        client.GetStringAsync("https://docs.microsoft.com/dotnet");

    DoIndependentWork();

    string contents = await getStringTask;

    return contents.Length;
}

void DoIndependentWork()
{
    Console.WriteLine("Working...");
}
```

## 相关文章

* [温故知新，CSharp遇见异步编程(Async/Await)，通过ILSpy反编译代码，透过现象看本质](https://www.cnblogs.com/taylorshi/p/16842376.html)