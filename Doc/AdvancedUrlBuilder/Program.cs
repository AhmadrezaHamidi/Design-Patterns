// See https://aka.ms/new-console-template for more information
using AdvancedUrlBuilder.Domain;

Console.WriteLine("Hello, World!");

var url = new UrlBuilder().WithHost("localhost").WithQueryString(x => x.WithParamerters("page", "1").WithParamerters("SizeItem","2"));