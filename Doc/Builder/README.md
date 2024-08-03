الگوی طراحی Builder یک الگوی ایجادی (creational pattern) است که به شما اجازه می‌دهد اشیاء پیچیده را گام به گام بسازید. این الگو به شما امکان می‌دهد که با استفاده از همان کد ساخت، انواع مختلفی از یک شیء را تولید کنید.

اجزای اصلی الگوی Builder:
Product: شیء پیچیده‌ای که قرار است ساخته شود.
Builder: یک interface یا کلاس abstract که متدهایی برای ساخت بخش‌های مختلف Product را تعریف می‌کند.
ConcreteBuilder: پیاده‌سازی Builder که مراحل ساخت را برای یک نوع خاص از Product پیاده‌سازی می‌کند.
Director: کلاسی که ترتیب مراحل ساخت را مدیریت می‌کند. این کلاس با Builder کار می‌کند.
مزایای استفاده از الگوی Builder:
ساخت اشیاء پیچیده را گام به گام انجام می‌دهد.
امکان استفاده مجدد از کد ساخت برای ایجاد انواع مختلف محصول را فراهم می‌کند.
کد client را از جزئیات ساخت محصول جدا می‌کند.


اجزای اصلی الگوی Builder:
Product: شیء پیچیده‌ای که قرار است ساخته شود.
Builder: یک interface یا کلاس abstract که متدهایی برای ساخت بخش‌های مختلف Product را تعریف می‌کند.
ConcreteBuilder: پیاده‌سازی Builder که مراحل ساخت را برای یک نوع خاص از Product پیاده‌سازی می‌کند.
Director: کلاسی که ترتیب مراحل ساخت را مدیریت می‌کند. این کلاس با Builder کار می‌کند.
مزایای استفاده از الگوی Builder:
ساخت اشیاء پیچیده را گام به گام انجام می‌دهد.
امکان استفاده مجدد از کد ساخت برای ایجاد انواع مختلف محصول را فراهم می‌کند.
کد client را از جزئیات ساخت محصول جدا می‌کند.



The Builder design pattern is a creational pattern that allows you to construct complex objects step by step. This pattern lets you produce different types and representations of an object using the same construction code.

Main Components of the Builder Pattern:
Product: The complex object that is to be built.
Builder: An interface or abstract class that defines methods for building the different parts of the Product.
ConcreteBuilder: A class that implements the Builder interface and constructs the parts of the Product for a specific type.
Director: A class that manages the construction process. It works with the Builder to construct the Product.
Benefits of using the Builder Pattern:
Allows you to construct complex objects step by step.
Enables reuse of the construction code to create different types of products.
Separates the construction code from the client code.
Example:
Let's say we want to create a system for building different types of houses (e.g., wooden house, brick house)